namespace SiemTracker.Domain.Entities;
public class SecurityAlert
{
    public Guid Id {get;set;} = Guid.NewGuid();
    public string Title {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public string Severity {get;set;} = "ALTO/CRITICO";
    public bool Resolvido {get;set;} = false;
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
}