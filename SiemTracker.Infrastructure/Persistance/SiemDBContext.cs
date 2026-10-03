using Microsoft.EntityFrameworkCore;
using SiemTracker.Domain.Entities;
namespace SiemTracker.Infrastructure.Persistance;
public class SiemDBContext : DbContext
{
    public SiemDBContext(DbContextOptions<SiemDBContext> options) : base(options) { }
    public DbSet<LogEvent> LogEvents => Set<LogEvent>();
    public DbSet<SecurityAlert> SecurityAlerts => Set<SecurityAlert>();
}