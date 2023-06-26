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
        public virtual ICollection<questionsTexts> QuestionsTexts { get; set; } = new List<questionsTexts>();
        public virtual ICollection<answersTexts> Answers { get;set; } = new List<answersTexts>();
        public virtual ICollection<TrueAnswers> TrueAnswers { get; set; } = new List<TrueAnswers>();


    }
}
