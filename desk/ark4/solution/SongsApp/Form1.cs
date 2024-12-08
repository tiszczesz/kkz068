using SongsApp.Models;

namespace SongsApp
{
    public partial class Form1 : Form
    {
        private List<Song> songs;
        private ISongRepo songRepo = new FileSongRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songs = songRepo.GetAllSongs().ToList();
        }
    }
}
