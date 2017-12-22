using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIC.Framework;

namespace WIC.UI.Win
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            numWeight.Maximum = 1400;
            numHeight.Maximum = 108;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            BodyMassIndex bmi = new BodyMassIndex((double)numWeight.Value, (double)numHeight.Value);
            bmi.CalculateBMI();
            lblBMI.Text = bmi.getBMI().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
