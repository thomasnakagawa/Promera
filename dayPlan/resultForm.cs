﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dayPlan
{
    public partial class resultForm : Form
    {
        public resultForm(String input)
        {
            InitializeComponent();
            richTextBox1.Text = input;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
