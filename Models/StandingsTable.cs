namespace F1Data.Models;

public class StandingsTable
{
    public string? round { get; set; }
    public string? season { get; set; }
    public List<StandingsList>? StandingsLists { get; set; }
}