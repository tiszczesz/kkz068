using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsApp.Models
{
    public interface ISongRepo
    {
        public IEnumerable<Song> GetAllSongs();
        public Song GetSongById(int id);
        public void AddSong(Song song);
        public void UpdateSong(Song song);
        public void DeleteSong(int id);

    }
}
