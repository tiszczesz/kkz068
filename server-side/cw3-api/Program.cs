using cw3_api;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var connString = builder.Configuration
             .GetConnectionString("SqliteString")
              ?? "Data Source=mydb.db"; //gdyby byl null to uzyj tego
BooksRepo repo = new BooksRepo(connString);
builder.Services.AddCors(options =>
    {
        options.AddPolicy(MyAllowSpecificOrigins,
            policy =>
            {
                policy.WithOrigins("*");
                policy.AllowAnyMethod().AllowAnyHeader();
            }
        );
    }
 );
var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
app.MapGet("/", () => repo.GetBooks());
app.MapGet("/{id}", (int id) => repo.GetBookById(id));
app.MapDelete("/{id}", (int? id) => repo.DeleteBook(id));
app.MapPost("/", (Book book) => repo.InsertBook(book));


app.Run();
