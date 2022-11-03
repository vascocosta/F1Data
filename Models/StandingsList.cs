namespace F1Data.Models;

public class StandingsList
{
    public string? season { get; set; }
    public string? round { get; set; }
    public List<DriverStanding>? DriverStandings { get; set; }
    public List<ConstructorStanding>? ConstructorStandings { get; set; }
}