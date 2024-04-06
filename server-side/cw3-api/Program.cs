using cw3_api;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("SqliteString");
List<Book> books = BooksRepo.GetBooks(connString);
var app = builder.Build();

app.MapGet("/", () => books);

app.Run();
