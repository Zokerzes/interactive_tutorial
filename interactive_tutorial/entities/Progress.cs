namespace interactive_tutorial.Entities

{
    public class Progress
    {
        public int Id { get; set; } = 0;

        public int Topic { get; set; } = 0;

        public int Chapter { get; set; } = 0;

        public Dictionary<int, int> TestScore { get; set; } 
        // словарь для сохранения номера теста и колличества очков

        public Progress()
        {
            TestScore = new Dictionary<int, int>()
            {
                { 0, 0 },
            };
        }

        public Progress(int id, int topic, int chapter, Dictionary<int, int> testScore)
        {
            Id = id;
            Topic = topic;
            Chapter = chapter;
            TestScore = testScore;
        }
        public Progress(Dictionary<int, int> testScore)
        {
            TestScore = testScore;
        }

        public void getProgrss()
        {
            MessageBox.Show($"общее колличество очков{TestScore.Values}", "Score");
        }
    }
    

}
