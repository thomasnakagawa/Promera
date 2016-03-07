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
        resultForm myOutput;
        data myData;
        String rawData;
        public Form1()
        {
            InitializeComponent();
            locationBox.Enabled = false;
            groupBox.SelectedIndex = 0;
            activityBox.SelectedIndex = 1;
            budgetBox.SelectedIndex = 1;
            myData = new data();
            rawData = myData.getData();
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
            if(myOutput != null && !myOutput.IsDisposed)
            {
                myOutput.Dispose();
            }
            myOutput = new resultForm(rawData);
            myOutput.Show();
        }
    }
}