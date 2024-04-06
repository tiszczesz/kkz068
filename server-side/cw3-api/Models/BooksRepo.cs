using Microsoft.Data.Sqlite;

namespace cw3_api;

public class BooksRepo
{
    public static List<Book> GetBooks(string connString)
    {
        var books = new List<Book>();
        using (SqliteConnection conn = new SqliteConnection(connString))
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
}
