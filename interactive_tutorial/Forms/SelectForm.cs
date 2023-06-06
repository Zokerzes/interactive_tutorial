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

namespace interactive_tutorial.Forms
{
    public partial class SelectForm : Form
    {
        User user;
        Form form;
        public SelectForm(User user)
        {
            InitializeComponent();
        }

        private void manager_Button_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            this.Visible = false;
            if (managerForm.ShowDialog()==DialogResult.OK)
            {
                
            }
            this.Visible=true;
        }

        private void Autorization_Button_Click(object sender, EventArgs e)
        {
            AutorizationForm autorizationForm = new AutorizationForm();
            this.Visible = false;
            if(autorizationForm.ShowDialog()==DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void Test_Button_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            this.Visible = false;
            if (testForm.ShowDialog()==DialogResult.OK)
            {
                
            }
            this.Visible = true;
        }
    }
}
