using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class PanelControl1 : UserControl
    {
        public PanelControl1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var oneOutput = this.oneOutput.Text;
            var twoOutput = this.twoOutput.Text;

            //Parent
            var parent = this.Parent as Form1;
            parent.panelDataInput = oneOutput;
            parent.panelDataInput1 = twoOutput;
        }
    }
}
