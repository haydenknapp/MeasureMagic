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
    public partial class Dimensions : Form
    {
        public Dimensions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Dimensions_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            double yards=calc_yard();
            var form2 = new fabrics(yards);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private double calc_yard()
        {
            double shoulderWidth = Convert.ToDouble(shobox.Value);
            double chestCircumference = Convert.ToDouble(chestbox.Value);
            double waistAround = Convert.ToDouble(waibox.Value);
            double biggestFactor = Math.Max(shoulderWidth, Math.Max(chestCircumference, waistAround));
            double sleeveLength = Convert.ToDouble( slebox.Value);
            double seamAllowance = Convert.ToDouble(seambox.Value);
            double shirtLength = Convert.ToDouble(shrbox.Value);
            double bicepCircumference = Convert.ToDouble(bicbox.Value);

            if ((sleeveLength + seamAllowance * 2 + shirtLength) <= 45)
                return (biggestFactor * 2)/36;
            else
                return (biggestFactor * 2 + bicepCircumference)/36;


        }
    }
}
