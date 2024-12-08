using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsApp.Models
{
    public class FileSongRepo : ISongRepo
    {
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
            var lines = System.IO.File.ReadAllLines("Files/Data.txt");
            
            List<Song> songs = new List<Song>();
            for (int i = 0; i < lines.Length; i += 6)
            {
                try
                {
                    Song song = new Song
                    {
                        Artist = lines[i],
                        Album = lines[i + 1],
                        SongNumber = Convert.ToInt32(lines[i + 2]),
                        Year = Convert.ToInt32(lines[i + 3]),
                        DownloadNumber = Convert.ToInt32(lines[i + 4])
                    };
                    songs.Add(song);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return songs;
        }

        public Song GetSongById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSong(Song song)
        {
            throw new NotImplementedException();
        }
        public void SaveAllSongs(IEnumerable<Song> songs)
        {
            List<string> lines = new List<string>();
            foreach (var song in songs)
            {
                lines.Add(song.Artist);
                lines.Add(song.Album);
                lines.Add(song.SongNumber.ToString());
                lines.Add(song.Year.ToString());
                lines.Add(song.DownloadNumber.ToString());
                lines.Add("");
            }
            System.IO.File.WriteAllLines("Files/Data.txt", lines);

        }
    }
}
