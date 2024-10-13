using cw7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw7
{
    public partial class FormAddNew : Form
    {
        private MainWindow _form;
        public FormAddNew(MainWindow form)
        {
            InitializeComponent();
            _form = form;
        }

        private void tbFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                   && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = tbFirstname.Text;
            string lastname = tbLastname.Text;
            string email = tbEmail.Text;
            DateTime birthday = mcDate.SelectionStart;
            int id = _form.repo.GetLastId() + 1;
            var person = new Person
            {
                Id = id,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                BirthDay = DateOnly.FromDateTime(birthday)
            };
            _form.repo.People.Add(person);
            _form.RefreshData();
            Close();
        }
    }
}
