var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("SqliteString");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
