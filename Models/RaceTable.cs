namespace F1Data.Models;

public class RaceTable
{
    public string? season { get; set; }
    public string? round { get; set; }
    public List<Race>? Races { get; set; }
}