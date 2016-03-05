using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            locationBox.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if any of the input boxes are blank, then show the error label.
            if(locationBox.Text == "" ||
                groupBox.Text == "" ||
                activityBox.Text == "" ||
                budgetBox.Text == "")
            {
                errorLabel.Visible = true;
                return;
            }

            //no bad inputs, so turn the error label off
            errorLabel.Visible = false;
        }
    }
}