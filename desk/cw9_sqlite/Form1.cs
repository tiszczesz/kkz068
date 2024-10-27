using cw9_sqlite.Models;

namespace cw9_sqlite;

public partial class Form1 : Form
{
    private MoviesRepo _repo = new MoviesRepo();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = _repo.GetMovies();
    }
}
