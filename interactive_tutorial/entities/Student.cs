namespace interactive_tutorial.Entities
{
    public class Student : User
    {
        public virtual Progress Progress { get; set; } = null!;
    }
}
