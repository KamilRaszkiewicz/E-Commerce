using E_Commerce.API;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureServices();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
