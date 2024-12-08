using SongsApp.Models;

namespace SongsApp
{
    public partial class Form1 : Form
    {
        private List<Song>? songs;
        private int currentSongIndex = 0;
        private ISongRepo songRepo = new FileSongRepo();
        //private ISongRepo songRepo = new SqliteSongRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songs = songRepo.GetAllSongs().ToList();
            if (songs.Count > 0)
            {
                DisplayCurrentSong();
            }
            else
            {
                MessageBox.Show("No songs found");
            }

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
            lbAlbum.Text = currentSong.Album;
            lbSongsNumber.Text = currentSong.SongNumber.ToString() + " utworów";
            lbYear.Text = currentSong.Year.ToString();
            lbdownloadsNumber.Text = currentSong.DownloadNumber.ToString();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (songs.Count > 0)
            {
                songs[currentSongIndex].DownloadNumber++;
                DisplayCurrentSong();
                if (songRepo is SqliteSongRepo)
                {
                    songRepo.UpdateSong(songs[currentSongIndex]);
                }
                else
                {
                    MessageBox.Show("Downloaded");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(songRepo is FileSongRepo)
            {
                (songRepo as FileSongRepo)?.SaveAllSongs(songs);
            }
        }
    }

}
