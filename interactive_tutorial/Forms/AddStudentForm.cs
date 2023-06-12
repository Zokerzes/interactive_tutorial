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
using System.Xml.Serialization;

namespace interactive_tutorial.Forms
{
    public partial class AddStudentForm : Form
    {
        Student student;
        List<string> topics = new List<string>();
        public Student NewStudent
        {
            get { return student; }
        }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void addStudent_Button_Click(object sender, EventArgs e)
        {
            student = new Student(name_TextBox.Text, (double)time_NumericUpDown.Value, (double)questNumber_NumericUpDown.Value,
                (double)questTest_NumericUpDown.Value, topics);
            this.DialogResult = DialogResult.OK;

        }

        private void addAbswer_Button_Click(object sender, EventArgs e)
        {
            string text = topic_ComboBox.Text;

            if (topic_ComboBox.SelectedItem == null)
            {
                if (topic_ComboBox.Items.Contains(text)==false)
                {
                    topic_ComboBox.Items.Add(text);
                }
                topics.Add(text);
                selectedTopic_ListBox.Items.Add(text);
            }
            else
            {
                topics.Add(topic_ComboBox.SelectedItem.ToString());
                selectedTopic_ListBox.Items.Add(topic_ComboBox.SelectedItem.ToString());
            }
        }

        private void estimation_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void selectedTopic_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTopic_ListBox.Items.RemoveAt(selectedTopic_ListBox.SelectedIndex);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("topics.xml")==false) return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("topics.xml", FileMode.Open))
            {
                topics = (List<string>)serializer.Deserialize(fs);
            }

            foreach (string item in topics)
            {
                topic_ComboBox.Items.Add(item);
            }
        }

        private void AddStubentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("topics.xml", FileMode.Create))
            {
                serializer.Serialize(fs, topics);
            }
        }
    }
}
