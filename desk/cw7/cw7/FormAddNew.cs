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
    }
}
