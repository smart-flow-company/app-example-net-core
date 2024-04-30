var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => { return "Timeweb Cloud + .NET Core = ❤️"; });
app.MapGet("/version", () => { return "1.0.0.0"; });

app.Run();