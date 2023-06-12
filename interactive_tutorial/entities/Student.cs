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
            
        public Progress Progress { get; set; }

        public string Name { get; set; }

        public DateTime Time { get; set; }

        public double Answer { get; set; }

        public double Estimation { get; set; }

        public List<string> Mathematik {  get; set; } = new List<string>();

        public Student() { }

        public Student(string name, DateTime time, double answer, double estimation, List<string> mathematik)
        {
            Name = name;
            Time = time;
            Answer = answer;
            Estimation = estimation;
            Mathematik = mathematik;
        }

        public override string ToString()
        {
            return $"{Name} Ответ:{Answer} Время: {Time}";

        }
    }
}
    
