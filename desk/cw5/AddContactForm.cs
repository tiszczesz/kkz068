using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw5.Models;

namespace cw5
{
    public partial class AddContactForm : Form
    {
        private Form1 _parent;
        public AddContactForm(Form1 form1)
        {
            InitializeComponent();
            _parent = form1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            btnAddContact.Enabled = (
                tbFirstName.Text.Trim().Length > 0 &&
                tbLastName.Text.Trim().Length > 0
                && tbPhone.Text.Trim().Length > 0
                );
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Person p = new Person
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Phone = tbPhone.Text,
                Age = Convert.ToInt32(tbAge.Value),
                IsFamily = cbIsFamily.Checked
            };
            _parent.AddPerson(p);
            Close();
        }
    }
}
