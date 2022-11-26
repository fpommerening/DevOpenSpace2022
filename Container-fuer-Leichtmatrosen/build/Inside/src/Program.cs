var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/", () => $"Hallo zum Docker-Training {DateTime.UtcNow:G}");

app.Run();