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



    }
}
