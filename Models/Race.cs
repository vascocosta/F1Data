namespace F1Data.Models;

public class Race
{
    public string? season { get; set; }
    public string? round { get; set; }
    public string? url { get; set; }
    public string? raceName { get; set; }
    public Circuit? Circuit { get; set; }
    public string? date { get; set; }
    public string? time { get; set; }
    public List<QualifyingResult>? QualifyingResults { get; set; }
    public List<Result>? Results { get; set; }
}