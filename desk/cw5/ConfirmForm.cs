﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw5
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm(string info="")
        {
            InitializeComponent();
            lbQuestion.Text = info;
        }
    }
}
