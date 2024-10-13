using cw7.Models;
using System.Windows.Forms;

namespace cw7
{
    public partial class MainWindow : Form
    {
        public PeopleRepo repo;
        public MainWindow()
        {
            InitializeComponent();
            //_repo = new PeopleRepo();
            // string path = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            repo = new PeopleRepo();
            var people = repo.People;
            RefreshData();
            
            dgvPeople.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (repo == null || repo?.People == null)
            {
                MessageBox.Show("Pobierz dane z pliku");
                return;
            }
            var addForm = new FormAddNew(this);
            addForm.ShowDialog();
        }
        public void RefreshData()
        {
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = repo.People;
            dgvPeople.Columns["Id"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvPeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz wiersz do usuniêcia");
                return;
            }
            Person toRemove = (Person)dgvPeople.SelectedRows[0]
                      .DataBoundItem;
            if(toRemove != null)
            {
                repo.People.Remove(toRemove);
                RefreshData();
            }

        }
    }
}
