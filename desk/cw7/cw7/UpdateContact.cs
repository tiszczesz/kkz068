﻿using System;
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
    public partial class UpdateContact : Form
    {
        private MainWindow _window;
        public UpdateContact(MainWindow window)
        {
            InitializeComponent();
            _window = window;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Zmieniono tekst");
        }
    }
}
