using cw9_sqlite.Models;

namespace cw9_sqlite;

public partial class Form1 : Form
{
    private MoviesRepo _repo = new MoviesRepo();
    private bool _isEditMode = false;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //panelAdd.Visible = false;
        fillDataGridView();
        //var columns = dataGridView1.Columns;
        fillComboBoxItems();

    }
    private void fillDataGridView(int columnId = -1)
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = columnId == -1
            ? _repo.GetMovies() :
            _repo.GetMoviesWithSort(columnId);
        dataGridView1.Columns["Id"].Visible = false;
    }

    private void fillComboBoxItems()
    {
        for (int i = 1; i < dataGridView1.Columns.Count; i++)
        {

            cbHeader.Items.Add(new ComboBoxItem
            {
                ColumnId = i,
                HeaderText = dataGridView1.Columns[i].HeaderText,
                ColumnName = dataGridView1.Columns[i].DataPropertyName
            });

        }
        cbHeader.DisplayMember = "HeaderText";
        cbHeader.ValueMember = "ColumnId";
        cbHeader.SelectedIndex = 0;

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
            _isEditMode = false;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var movie = getMovieFromForm();
        if (movie != null)
        {
            if (_isEditMode)
                _repo.UpdateMovie(movie);
            else
                _repo.AddMovie(movie);
            fillDataGridView();
            panelAdd.Visible = false;
            btnShow.Text = "Poka¿";
            tbTitle.Text = "";
            tbDirector.Text = "";
            dataYear.Value = DateTime.Now;
            tbPrice.Text = "";
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
            Id = _isEditMode ? (int)dataGridView1.SelectedRows[0].Cells["Id"].Value : 0,
            // Id = _isEditMode ? Convert.ToInt32(lbId.Text) : 0,
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
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Zaznacz film do usuniêcia");
            return;
        }
        var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
        _repo.RemoveMovie(id);
        fillDataGridView();

        //Movie? movieToDelete = dataGridView1.SelectedRows[0].DataBoundItem as Movie;
        //if(movieToDelete != null)
        //{
        //    _repo.RemoveMovie(movieToDelete.Id);
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = _repo.GetMovies();
        //}
    }

    private void dataGridView1_DoubleClick(object sender, EventArgs e)
    {
        // MessageBox.Show("Double click");
        if (dataGridView1.SelectedRows.Count > 0)
        {
            panelAdd.Visible = true;
            btnShow.Text = "Ukryj";
            Movie? movie = dataGridView1.SelectedRows[0].DataBoundItem as Movie;
            if (movie != null)
            {
                lbId.Text = movie.Id.ToString();
                tbTitle.Text = movie.Title;
                tbDirector.Text = movie.Director;
                var date = movie.Year;
                dataYear.Value = new DateTime(date, 1, 1);

                tbPrice.Text = movie.Price.ToString();
                _isEditMode = true;
            }
        }
    }

    private void btnSort_Click(object sender, EventArgs e)
    {
        //MessageBox.Show($"value: {(cbHeader.SelectedItem as ComboBoxItem)?.ColumnId}" );

        var columnId = (cbHeader.SelectedItem as ComboBoxItem)?.ColumnId;
        if (columnId == null)
            return;
        fillDataGridView((int)columnId);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new FormByRecord().ShowDialog();
    }
}
