namespace interactive_tutorial.Entities
{
    public abstract class User
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
