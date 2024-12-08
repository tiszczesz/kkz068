using SongsApp.Models;

namespace SongsApp
{
    public partial class Form1 : Form
    {
        private List<Song> songs;
        private int currentSongIndex = 0;
        private ISongRepo songRepo = new FileSongRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songs = songRepo.GetAllSongs().ToList();
            DisplayCurrentSong();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentSongIndex--;
            if (currentSongIndex < 0)
            {
                currentSongIndex = songs.Count - 1;
            }
            DisplayCurrentSong();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentSongIndex++;
            if (currentSongIndex >= songs.Count)
            {
                currentSongIndex = 0;
            }
            DisplayCurrentSong();
        }
        private void DisplayCurrentSong()
        {
            Song currentSong = songs[currentSongIndex];
            lbArtist.Text = currentSong.Artist;
            lbTitle.Text = currentSong.Album;
            lbSongsNumber.Text = currentSong.SongNumber.ToString();
            lbYear.Text = currentSong.Year.ToString();
            lbdownloadsNumber.Text = currentSong.DownloadNumber.ToString();
        }
    }
}
