using Microsoft.AspNetCore.Mvc;
using SiemTracker.Application.Interfaces;
using SiemTracker.Domain.Entities;

namespace SiemTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogsController : ControllerBase
{
    private readonly ILogRepository _logRepository;

    public LogsController(ILogRepository logRepository)
    {
        _logRepository = logRepository;
    }

    // POST: api/logs -> Usado para cadastrar um novo log de segurança
    [HttpPost]
    public async Task<IActionResult> CreateLog([FromBody] LogEvent logEvent)
    {
        if (logEvent == null)
        {
            return BadRequest("Os dados do log são inválidos.");
        }

        await _logRepository.AddLogAsync(logEvent);
        
        return Ok(new { message = "Log registrado com sucesso!", data = logEvent });
    }

    // GET: api/logs -> Usado para listar todos os logs salvos no banco
    [HttpGet]
    public async Task<IActionResult> GetAllLogs()
    {
        var logs = await _logRepository.GetAllLogsAsync();
        return Ok(logs);
    }
}