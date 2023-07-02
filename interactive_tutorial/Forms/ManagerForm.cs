using interactive_tutorial.Context;
using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using interactive_tutorial.Service;

namespace interactive_tutorial
{
    public partial class ManagerForm : Form
    {
        readonly InteractiveTutorialContext _context;
        public List<string> TextAd;
        
        public ManagerForm()
        {
            InitializeComponent();
            _context = new InteractiveTutorialContext();
            TextAd= new List<string>();
            for (int i = 0; i < _context.Contents.Count(); i++)
            {
                TextAd.Add(_context.Contents.ToArray()[i].Text);
            }
        }

        private void employeeRate_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            int tex = Convert.ToInt32(TextElement_NumericUpDown.Value.ToString());
            if (tex >= 0 && tex < TextAd.Count)
            {
                textBox1.Text = TextAd.ToArray()[tex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.ShowDialog();
        }
    }
}
