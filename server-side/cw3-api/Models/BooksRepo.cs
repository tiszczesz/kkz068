using Microsoft.Data.Sqlite;

namespace cw3_api;

public class BooksRepo
{
    private string _connString;
    public BooksRepo(string connString)
    {
        _connString = connString;
    }
    public List<Book> GetBooks()
    {
        var books = new List<Book>();
        using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Books";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                books.Add(
                    new Book
                    {
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Author = rd.GetString(2),
                        Price = rd.GetDecimal(3)
                    }
                );
            }
        }
        return books;
    }
    public Book? GetBookById(int? id)
    {
        if (id == null) return null;
        Book book;
        using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT id,title,author,price FROM Books WHERE id={id}";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            if(!rd.HasRows) return null;
            rd.Read();
            book = new Book
            {
                Id = rd.GetInt32(0),
                Title = rd.GetString(1),
                Author = rd.GetString(2),
                Price = rd.GetDecimal(3)
            };
        }
        return book;
    }
    public void DeleteBook(int? id){
        if (id == null) return;
        using (SqliteConnection conn = new SqliteConnection(_connString)){
            SqliteCommand command = conn.CreateCommand();
            command.CommandText=$"DELETE FROM Books WHERE id={id}";
            conn.Open();
            var result = command.ExecuteNonQuery();
        }
    }
}
