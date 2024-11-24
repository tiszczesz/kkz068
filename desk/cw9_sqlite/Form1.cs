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
        dataGridView1.Columns["Id"].Visible = false;
        //var columns = dataGridView1.Columns;

    }

    private void btnShow_Click(object sender, EventArgs e)
    {
        if (panelAdd.Visible == true)
        {
            btnShow.Text = "Poka¿";
            panelAdd.Visible = false;
        }
        else
        {
            btnShow.Text = "Ukryj";
            panelAdd.Visible = true;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private Movie? getMovieFromForm()
    {
        if(string.IsNullOrEmpty(tbTitle.Text.Trim()) 
            || string.IsNullOrEmpty(tbDirector.Text.Trim()) 
            || string.IsNullOrEmpty(dataYear.Text.Trim()) 
            || string.IsNullOrEmpty(tbPrice.Text.Trim()))
        {
            MessageBox.Show("Wype³nij wszystkie pola");
            return null;
        }
        return new Movie
        {
            Title = tbTitle.Text,
            Director = tbDirector.Text,
            Year = Convert.ToInt32(dataYear.Text),
            Price = Convert.ToDecimal(tbPrice.Text)
        };
    }
}
