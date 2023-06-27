

using interactive_tutorial.Entities;

namespace interactive_tutorial
{
    public class Student : User
    {
        public virtual Progress Progress { get; set; } = null;
    }
}


