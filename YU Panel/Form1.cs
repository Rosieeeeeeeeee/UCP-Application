using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string panelDataInput
        {
            set 
            {
                oneOutput.Text = value;

            }
        
        }

        public string panelDataInput1
        {
            set
            {
 
                twoOutput.Text = value;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelOneBtn_Click(object sender, EventArgs e)
        {
            panelControl11.Show();
            panelControl11.BringToFront();

            panelControl21.Hide();
        }

        private void panelTwoBtn_Click(object sender, EventArgs e)
        {
            panelControl21.Show();
            panelControl21.BringToFront();

            panelControl11.Hide();

        }
    }
}
