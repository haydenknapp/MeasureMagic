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
    public partial class fabrics : Form
    {
        double yard;

        public fabrics(double yards)
        {
            InitializeComponent();
            yard = yards;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new result(yard,comboBox1.Text,material());
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string material()
        {
            if (Silk.Checked)
                return "Silk";
            if (Cotton.Checked)
                return "Cotton";
            if (Denim.Checked)
                return "Denim";
            if (Fleece.Checked)
                return "Fleece";
            if (Linen.Checked)
                return "Linen";
            if (Polyester.Checked)
                return "Polyester";
            return "";
        }
    }
}
