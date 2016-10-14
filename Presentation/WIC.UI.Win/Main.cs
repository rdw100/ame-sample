using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIC.UI.Win.Presenters;
using WIC.UI.Win.Views;

namespace WIC.UI.Win
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            FormMember settingsForm = new FormMember();

            // Show the settings form
            settingsForm.Show();
        }
    }
}
