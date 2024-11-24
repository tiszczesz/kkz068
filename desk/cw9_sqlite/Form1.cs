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
        //panelAdd.Visible = false;
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
        var movie = getMovieFromForm();
        if (movie != null)
        {
            _repo.AddMovie(movie);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _repo.GetMovies();
        }
    }

    private Movie? getMovieFromForm()
    {
        if (string.IsNullOrEmpty(tbTitle.Text.Trim())
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

    private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
            && e.KeyChar != ',')
        {
            e.Handled = true;
        }
    }

    private void btnDeletMovie_Click(object sender, EventArgs e)
    {
        if(dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Zaznacz film do usuniêcia");
            return;
        }
        var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
        _repo.RemoveMovie(id);
        //Movie? movieToDelete = dataGridView1.SelectedRows[0].DataBoundItem as Movie;
        //if(movieToDelete != null)
        //{
        //    _repo.RemoveMovie(movieToDelete.Id);
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = _repo.GetMovies();
        //}
    }
}
