using cw7.Models;

namespace cw7
{
    public partial class Form1 : Form
    {
        private PeopleRepo _repo;
        public Form1()
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
        }
    }
}
