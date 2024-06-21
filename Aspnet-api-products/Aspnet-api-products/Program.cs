var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapGet("/", () => ("Hello world!"));

app.UseAuthorization();

app.MapControllers();

app.Run();
