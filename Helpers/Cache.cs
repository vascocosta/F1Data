namespace F1Data.Helpers;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

public abstract class Cache : ComponentBase
{
    [Inject]
    IJSRuntime? JS { get; set; }

    public async Task WriteCache<T>(string key, T value)
    {
        if (JS != null)
            await JS.InvokeVoidAsync("localStorage.setItem", key,  JsonSerializer.Serialize(value));
    }

    public async Task<T?> ReadCache<T>(string key)
    {
        T? result;
        if (JS != null)
        {
            var raceStandingsJson = await JS.InvokeAsync<string>("localStorage.getItem", key);
            try
            {
                result = JsonSerializer.Deserialize<T>(raceStandingsJson);
                return result;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (JsonException)
            {
                throw;
            }
        }
        else
        {
            return default(T);
        }
    }
}