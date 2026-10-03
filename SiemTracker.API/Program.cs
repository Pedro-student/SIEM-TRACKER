using Microsoft.EntityFrameworkCore;
using SiemTracker.Application.Interfaces;
using SiemTracker.Infrastructure.Persistance;
using SiemTracker.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SiemDBContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILogRepository, LogRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();