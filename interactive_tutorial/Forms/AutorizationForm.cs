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
using static System.Windows.Forms.DataFormats;

namespace interactive_tutorial
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        #region test{
        //для тестирования
        private void EntranceButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            TestForm testForm = new TestForm(student);
            testForm.ShowDialog();
           
        }
        #endregion 

        private void AutorizationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
