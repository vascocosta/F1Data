namespace F1Data.Models;

public class QualifyingScores
{
    public string? Code { get; set; }
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
    public string? Constructor { get; set; }
    public List<double> Q1 { get; set; } = new List<double>();
    public List<double> Q2 { get; set; } = new List<double>();
    public List<double> Q3 { get; set; } = new List<double>();
    public double Q1Score { get; set; }
    public double Q2Score { get; set; }
    public double Q3Score { get; set; }
}