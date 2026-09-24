
public record LogEntry
{
    private static readonly HashSet<string> _valid = new(){"INFO", "WARN", "ERROR"};
    public required string Message {get; init;}
    public required string Source{get; init;}
    private string _level = string.Empty;
    public string Level
    {
        get => _level;
        init
        {
            if(!_valid.Contains(value)){
                throw new ArgumentException($"Invalid status {value}", nameof(value));
                

            }
            _level = value;
        }
    }
    
}
public class LogAnalyzer
{
    public List<LogEntry> logs = [];

    public void LoadLogs(IEnumerable<LogEntry> entries)
    {
        logs.AddRange(entries);
    }
    public int GetCountByLevel(string level)
    {
        var count = logs.Count(s=> s.Level == level);
        return count;
    }

    public Dictionary<string, int> GetCountsPerLevel()
    {
        return logs.GroupBy(log => log.Level).ToDictionary(g=> g.Key, g=> g.Count());
    }
    public List<string> GetCriticalSources()
    {
        return logs.Where(log => log.Level == "ERROR").Select(log => log.Source).Distinct().ToList();
    }
    
}