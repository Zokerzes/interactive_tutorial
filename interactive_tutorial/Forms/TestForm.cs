﻿using interactive_tutorial.Context;
using RadioButton = System.Windows.Forms.RadioButton;


namespace interactive_tutorial
{
    public partial class TestForm : Form
    {
        readonly InteractiveTutorialContext _context;

        readonly List<Label> questionslabels;
        readonly List<RadioButton> radioButtonsTexts;

        public TestForm()
        {
            InitializeComponent();

            _context = new InteractiveTutorialContext();

            questionslabels = new List<Label>() { q1, q2, q3, q4, q5 };

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
            foreach (var number in _context.TrueAnswers)
            {
                if (radioButtonsTexts.ToArray()[number.Number - 1].Checked) allScore++;
            }

            return allScore;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _context.QuestionTexts.Count(); i++)
            {
                questionslabels[i].Text = _context.QuestionTexts.ToArray()[i].Question;
            }

            for (int i = 0; i < _context.AnswerTexts.Count(); i++)
            {
                radioButtonsTexts[i].Text = _context.AnswerTexts.ToArray()[i].Answer;
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы ответили верно на  {Result()} вопросов ");
        }
    }
}
