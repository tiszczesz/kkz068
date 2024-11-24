
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

        public void AddMovie(Movie movie)
        {
            using SqliteConnection conn = new SqliteConnection(_connectionString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Movies (title, director, year, price) "
                                 +" VALUES (@title, @director, @year, @price)";
            cmd.Parameters.AddWithValue("@title", movie.Title);
            cmd.Parameters.AddWithValue("@director", movie.Director);
            cmd.Parameters.AddWithValue("@year", movie.Year);
            cmd.Parameters.AddWithValue("@price", movie.Price);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void RemoveMovie(int id) {
            using SqliteConnection conn = new SqliteConnection(_connectionString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Movies WHERE Id=@movieId";                                
            cmd.Parameters.AddWithValue("@movieId", id);       
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateMovie(Movie movie)
        {
            using SqliteConnection conn = new SqliteConnection(_connectionString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Movies SET title=@title, "
                +"director=@director, year=@year, price=@price WHERE Id=@movieId";
            cmd.Parameters.AddWithValue("@title", movie.Title);
            cmd.Parameters.AddWithValue("@director", movie.Director);
            cmd.Parameters.AddWithValue("@year", movie.Year);
            cmd.Parameters.AddWithValue("@price", movie.Price);
            cmd.Parameters.AddWithValue("@movieId", movie.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Movie> GetMoviesWithSort(int? columnId)
        {
            if (columnId == null)
                return GetMovies();
            var movies = new List<Movie>();
            using SqliteConnection conn = new SqliteConnection(_connectionString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Movies ORDER BY {columnId+1}";
            conn.Open();
            SqliteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
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
