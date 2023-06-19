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
        Student student;
        Progress progress = new Progress();
        public TestForm()
        {
            InitializeComponent();
            student = new Student();
        }
        public TestForm(Student student)
        {
            InitializeComponent();
        }


        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            // student.progress.getProgrss()
        }
    }
}
