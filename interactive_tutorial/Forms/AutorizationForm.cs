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
    public partial class AutorizationForm : Form
    {
        private User newUser;
        public User NewUser
        {
            get
            {
                return NewUser;
            }
        }
        public AutorizationForm(User user)
        {
            InitializeComponent();
            userRole_ComboBox.SelectedIndex = 0;
        }
        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            newUser = new User(FirstName_TextBox.Text, LastName_TextBox.Text, Email_TextBox.Text,
                PhoneNumber_TextBox.Text, login_TextBox.Text, password_TextBox.Text, (UserRole)userRole_ComboBox.SelectedIndex);
            this.DialogResult = DialogResult.OK;
        }

        private void EntranceButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


    }
}
