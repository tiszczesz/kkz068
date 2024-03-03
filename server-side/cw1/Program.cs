var builder = WebApplication.CreateBuilder(args);
//tutaj wstrzykiwanie dodatkowych ..
builder.Services.AddRazorPages();

var app = builder.Build();
//używanie funkcjonalnosci
app.UseStaticFiles();
app.MapRazorPages();
//app.MapGet("/nowe", () => "Nowa wersja");
// app.MapGet("/", () => "ddddd");

app.Run();
