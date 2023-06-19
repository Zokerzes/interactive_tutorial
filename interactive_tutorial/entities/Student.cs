using interactive_tutorial.Authorization;

namespace interactive_tutorial.Entities
{
    public class Student : User
    {
        private Encrypt encrypt;

        public Progress Progress { get; set; }
        public string Name { get; set; }

        public double Time { get; set; }

        public double Answer { get; set; }

        public double Estimation { get; set; }

        public List<string> Mathematik {  get; set; } = new List<string>();

        public Student(string text, double value, double value1) { }
        public Student(string name, double time, double answer, double estimation, List<string> mathematik)
        {
            Name = name;
            Time = time;
            Answer = answer;
            Estimation = estimation;
            Mathematik = mathematik;
        }

        public Student(Encrypt encrypt)
        {
            this.encrypt=encrypt;
        }

        public override string ToString()
        {
            return $"{Name} Ответ:{Answer} Время: {Time}";
        }

        internal Task CreateUser()
        {
            throw new NotImplementedException();
        }
    }
}
