using cw5.Models;

namespace cw5
{
    public partial class Form1 : Form
    {
        private ContactsRepo _contacts;
        public Form1()
        {
            InitializeComponent();
            _contacts = new ContactsRepo();
            panelInfo.BackColor = Color.AliceBlue;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _contacts.GetFromFile(openFileDialog1.FileName);
                    lbContacts.DataSource = _contacts.People;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d otwarcia pliku: {ex.Message}");
            }

        }

        private void lbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UpdateForm(lbContacts.SelectedIndex);
        }

        private void UpdateForm(int index) {
            if (index != -1 && index < _contacts.People.Count) {
                tbPersonFirstName.Text = _contacts.People[index].FirstName;
                tbPersonLastName.Text = _contacts.People[index].LastName;
                tbPersonAge.Text = _contacts.People[index].Age.ToString();
                tbPersonPhone.Text = _contacts.People[index].Phone;
                panelInfo.BackColor = _contacts.People[index].IsFamily 
                    ? Color.Aquamarine 
                    : Color.AliceBlue;
            }
        }
    }
}
