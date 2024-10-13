using cw7.Models;
using System.Windows.Forms;

namespace cw7
{
    public partial class MainWindow : Form
    {
        private PeopleRepo _repo;
        public MainWindow()
        {
            InitializeComponent();
            //_repo = new PeopleRepo();
            // string path = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _repo = new PeopleRepo();
            var people = _repo.People;
            dgvPeople.DataSource = people;
            dgvPeople.Columns["Id"].Visible = false;
            dgvPeople.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var addForm = new FormAddNew(this);
            addForm.ShowDialog();
        }
    }
}
