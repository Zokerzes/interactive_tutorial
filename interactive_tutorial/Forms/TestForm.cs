using interactive_tutorial.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interactive_tutorial
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        public TestForm(Student student) 
        {
            InitializeComponent();
        }


        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
