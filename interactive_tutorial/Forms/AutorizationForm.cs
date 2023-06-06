using interactive_tutorial.Entities;

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

        public AutorizationForm()
        {
        }

        private void EntranceButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
