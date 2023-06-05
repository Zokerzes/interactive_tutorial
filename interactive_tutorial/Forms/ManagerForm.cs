using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using interactive_tutorial.Service;
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
    public partial class ManagerForm : Form
    {
        UserData userData = new UserData();
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            userData=(UserData)SerializeService.ObjDeserialize(userData.GetType(), userData, new XmlSerialize());

            foreach (User item in userData.AllUsers)
            {
                if (item.Role==UserRole.Manager)
                {
                    topiclistBox.Items.Add(item);
                }
            }
        }
         private void changeRate_Button2_Click(object sender, EventArgs e)
         {
            if (topiclistBox.SelectedIndex==-1) return;
            User user = (User)topiclistBox.SelectedItem;
            
        
         }
        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}
