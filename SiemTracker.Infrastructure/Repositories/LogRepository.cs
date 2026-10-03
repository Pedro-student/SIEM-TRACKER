using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiemTracker.Application.Interfaces;
using SiemTracker.Domain.Entities;
using SiemTracker.Infrastructure.Persistance;

namespace SiemTracker.Infrastructure.Repositories;

public class LogRepository : ILogRepository
{
    private readonly SiemDBContext _context;
    public LogRepository(SiemDBContext context)
    {
        _context = context;
    }

    public async Task AddLogAsync(LogEvent logEvent)
    {
        await _context.LogEvents.AddAsync(logEvent);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<LogEvent>> GetAllLogsAsync()
    {
        return await _context.LogEvents.ToListAsync();
    }
}