using cw5.Models;

namespace cw5 {
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
            var confirm = new ConfirmForm("Czy usun¹æ dane z listy kontaktów");
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                lbContacts.DataSource = null;
                _contacts.People.Clear();
            }
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _contacts.GetFromFile(openFileDialog1.FileName);
                    lbContacts.DataSource = null;
                    lbContacts.DataSource = _contacts.People;
                    btnSaveContacts.Enabled = true;
                    btnRemove.Enabled = true;
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

        private void UpdateForm(int index)
        {
            if (index != -1 && index < _contacts.People.Count)
            {
                tbPersonFirstName.Text = _contacts.People[index].FirstName;
                tbPersonLastName.Text = _contacts.People[index].LastName;
                tbPersonAge.Text = _contacts.People[index].Age.ToString();
                tbPersonPhone.Text = _contacts.People[index].Phone;
                if (_contacts.People[index].IsFamily)
                {
                    panelInfo.BackColor = Color.Aquamarine;
                    pbSmileImage.Visible = true;
                }
                else
                {
                    panelInfo.BackColor = Color.AliceBlue;
                    pbSmileImage.Visible = false;
                }
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            new AddContactForm(this).ShowDialog();
        }

        public void AddPerson(Person person)
        {
            _contacts.People.Add(person);
            lbContacts.DataSource = null;
            lbContacts.DataSource = _contacts.People;
            btnSaveContacts.Enabled = true;
        }

        private void btnSaveContacts_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _contacts.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbContacts.SelectedIndex != -1) {
                _contacts.People.RemoveAt(lbContacts.SelectedIndex);
                lbContacts.DataSource = null;
                lbContacts.DataSource = _contacts.People;
            }
        }
    }
}