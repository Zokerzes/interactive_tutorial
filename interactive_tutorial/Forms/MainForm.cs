using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interactive_tutorial.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

     

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           MessageBox.Show(numericUpDown1.Value.ToString());
        }
    }
}
