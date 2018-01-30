using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuff
{
    public partial class result : Form
    {
        string colors;
        string mate;
        public result(double yards, string color, string material)
        {
            InitializeComponent();
            label1.Text = "You will need "+Convert.ToString(yards)+" yards of Fabric";
            colors = color;
            mate = material;
            label2.Text = "this can be found at";
            linkLabel1.Text="http://www.joann.com/search?q="+colors+"+"+mate;
            label3.Text = "price esitmage upcoming";
        }

        private void result_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Dimensions();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
