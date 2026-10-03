using System.Collections.Generic;
using System.Threading.Tasks;
using SiemTracker.Domain.Entities;

namespace SiemTracker.Application.Interfaces;

public interface ILogRepository
{
    Task AddLogAsync(LogEvent logEvent);
    Task<IEnumerable<LogEvent>> GetAllLogsAsync();
}