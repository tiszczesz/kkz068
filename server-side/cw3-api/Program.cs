using cw3_api;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration
             .GetConnectionString("SqliteString")
              ?? "Data Source=mydb.db"; //gdyby byl null to uzyj tego
BooksRepo repo = new BooksRepo(connString);
List<Book> books = repo.GetBooks();
var app = builder.Build();

app.MapGet("/", () => books);
app.MapGet("/{id}",(int id) => repo.GetBookById(id));
app.MapDelete("/{id}",(int? id) => repo.DeleteBook(id));

app.Run();
