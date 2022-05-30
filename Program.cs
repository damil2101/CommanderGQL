var builder = WebApplication.CreateBuilder(args);

builder.Services.InitConfiguration(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
