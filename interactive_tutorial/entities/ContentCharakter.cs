namespace interactive_tutorial.Entities
{
    public class ContentCharakter
    {
        public int Id { get; set; }

        public required string Text { get; set; }

        public required string Video { get; set; }

        public required string Picture { get; set; }

        public required Progress Progress { get; set; }
    }
}
