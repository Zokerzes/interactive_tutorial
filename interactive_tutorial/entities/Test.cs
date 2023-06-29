namespace interactive_tutorial.entities
{
    public class Test
    {
        public int Id { get; set; }

        public virtual QuestionText QuestionText { get; set; } = null!;

        public virtual AnswerText Answer { get; set; } = null!;

        public virtual TrueAnswer TrueAnswer { get; set; } = null!;
    }
}
