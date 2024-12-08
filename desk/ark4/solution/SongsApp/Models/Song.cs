namespace SongsApp.Models
{
    public class Song
    {
        private static int nextId = 1;
        public Song()
        {
            Id = nextId++;
        }
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int SongNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }
    }
}