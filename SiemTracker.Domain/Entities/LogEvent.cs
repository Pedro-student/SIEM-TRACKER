namespace SiemTracker.Domain;

public class LogEvent
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string Source {get; set;} = string.Empty;
    public string Message {get; set;} = string.Empty;
    public string IPAdress {get; set;} = string.Empty;
    public string Severity {get; set;} = "INFO";
    public DateTime Timestamp {get; set;} = DateTime.UtcNow;
}
