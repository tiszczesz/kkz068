using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsApp.Models
{
    
    public class SqliteSongRepo : ISongRepo
    {
        private readonly string _connectionString;
        public SqliteSongRepo() {
            _connectionString = "Data Source=DbSongs.db";
        }
        public void AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public void DeleteSong(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();
            using SqliteConnection connection = new SqliteConnection(_connectionString);
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Songs";
            connection.Open();
            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Song song = new Song
                {
                    Id = reader.GetInt32(0),
                    Artist = reader.GetString(1),
                    Album = reader.GetString(2),
                    SongNumber = reader.GetInt32(3),
                    Year = reader.GetInt32(4),
                    DownloadNumber = reader.GetInt32(5)
                };
                songs.Add(song);
            }
            return songs;
        }

        public Song GetSongById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSong(Song song)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionString);
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Songs SET Artist = @Artist, Album = @Album, SongNumber = @SongNumber, Year = @Year, DownloadNumber = @DownloadNumber WHERE Id = @Id";
            command.Parameters.AddWithValue("@Artist", song.Artist);
            command.Parameters.AddWithValue("@Album", song.Album);
            command.Parameters.AddWithValue("@SongNumber", song.SongNumber);
            command.Parameters.AddWithValue("@Year", song.Year);
            command.Parameters.AddWithValue("@DownloadNumber", song.DownloadNumber);
            command.Parameters.AddWithValue("@Id", song.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
