using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw1
{
    public partial class Form2 : Form {
        private Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _form1.button1.Enabled = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            _form1.button1.Enabled = true;
        }
    }
}
