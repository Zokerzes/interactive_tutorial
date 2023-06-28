using interactive_tutorial.Context;
using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;


namespace interactive_tutorial
{
    public partial class TestForm : Form
    {
        readonly InteractiveTutorialContext _context;
        // заглушка - надо брать из базы
        public List<string> questionsTexts= new List<string>(5) 
        {
            "вопрос_1", "вопрос_2", "вопрос_3", "вопрос_4", "вопрос_5" 
        };
        public List<string> answersTexts = new List<string>(15)
        {
            "ответ__1","ответ__2", "ответ__3",
            "ответ__4","ответ__5", "ответ__6", 
            "ответ__7","ответ__8", "ответ__9", 
            "ответ__10","ответ__11", "ответ__12", 
            "ответ__12","ответ__14", "ответ__15"
        };
        List<Label> questionslabels = new List<Label>();
        List<RadioButton> radioButtonsTexts = new List<RadioButton>();


        public List<int> trueAnswers = new List<int>() {1,4,8,9,13};

        public TestForm()
        {
            InitializeComponent();
            // нужен сервис как класс
            _context = new InteractiveTutorialContext();
            


            questionslabels = new List<Label>() { q1,q2,q3,q4,q5 };
            radioButtonsTexts = new List<RadioButton>() 
            {
                radioButton1_1, radioButton1_2, radioButton1_3,
                radioButton2_1, radioButton2_2, radioButton2_3,
                radioButton3_1, radioButton3_2, radioButton3_3,
                radioButton4_1, radioButton4_2, radioButton4_3,
                radioButton5_1, radioButton5_2, radioButton5_3
            };
        }
        public int Result()
        {
            int allScore = 0;
            foreach (var taNumber in trueAnswers)  //список кнопок
            {
                if (radioButtonsTexts.ToArray()[taNumber].Checked) allScore++;
            }
            
            return allScore;
        }

        public  string conAsync()
        {
            return   _context.questionsTexts.Select(x=>x.Questions).FirstOrDefault();
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_context.questionsTexts.FirstOrDefault().ToString());
            

            //for (int i = 1; i < 6; i++)
            //{
            //    //questionslabels.ToArray()[i].Text = questionsTexts.ToArray()[i];
            //    questionslabels.ToArray()[i].Text = _context.questionsTexts.ToArray()[i].ToString();
            //}
            //radioButtonsTexts.ToArray()[0].Text = answersTexts.ToArray()[0];
            for (int i = 0; i < 15; i++)
            {
                radioButtonsTexts.ToArray()[i].Text = answersTexts.ToArray()[i];
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы ответили верно на  {Result()} вопросов ");
        }

       
    }
}
