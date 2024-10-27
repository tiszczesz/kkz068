
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw9_sqlite.Models
{
    public class MoviesRepo
    {
        private string _connectionString;
        public MoviesRepo()
        {
            _connectionString = "Data Source=mydb.db";
        }
        public List<Movie> GetMovies() { 
            var movies = new List<Movie>();
            using SqliteConnection conn = new SqliteConnection(_connectionString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Movies";
            conn.Open();
            SqliteDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                movies.Add(new Movie
                {
                    Id = reader.GetInt32("id"),
                    Title = reader.GetString("title"),
                    Director = reader.GetString("director"),
                    Year = reader.GetInt32("year"),
                    Price = reader.GetDecimal("price")
                });
            }
            conn.Close();
            return movies;
        }
    }
}
