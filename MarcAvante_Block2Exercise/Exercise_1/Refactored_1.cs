using System;

public class MatchData
{
    public int Score;
    public int EnemiesKilled;
    public int TimePlayedInSeconds;
}

public class MatchPerformanceCalculator
{
    public float GetPerformance(MatchData data)
    {
        return data.Score / (float)(data.TimePlayedInSeconds + 1);
    }
}

public class MatchSummaryBuilder
{
    public string BuildSummaryText(MatchData data, float performance)
    {
        return $"Score: {data.Score} | Kills: {data.EnemiesKilled} | Performance: {performance}";
    }
}

public interface IMatchExporter
{
    void Export();
}

public class JsonMatchExporter : IMatchExporter
{
    public void Export()
    {
        Console.WriteLine("Exporting match summary to JSON...");
    }
}

public class XmlMatchExporter : IMatchExporter
{
    public void Export()
    {
        Console.WriteLine("Exporting match summary to XML...");
    }
}