using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.entities
{
    public class Test
    {
        public int Id { get; set; }
        public virtual questionsTexts QuestionsTexts { get; set; }
        public virtual answersTexts Answers { get;set; }
        public virtual TrueAnswers TrueAnswers { get; set; }


    }
}
