using System;

namespace interactive_tutorial.Entities

{
    public class Student : User
    {
        public Progress progress ;

        Student student()
        {
            Progress progress = new Progress();
            return this;
        }
        void getProgress()
        {
            progress.getProgrss();
        }
    }
}
    
