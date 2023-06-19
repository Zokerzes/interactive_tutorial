namespace interactive_tutorial.Entities
{
    public enum UserRole
    {
        Admin,
        Manager,
        Student
    }
    public class User
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private UserRole selectedIndex;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Salt { get; set; }
        public UserRole Role { get; set; }

        public int Rate { get; set; }

        public User() { }

        public User(string firstname, string lastname, string email, string phoneNumber, string login, string password, string salt, UserRole role)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Salt= salt;
            Role = role;
        }

        public User(string text1, string text2, string text3, string text4, string text5, string text6, UserRole selectedIndex)
        {
            this.text1=text1;
            this.text2=text2;
            this.text3=text3;
            this.text4=text4;
            this.text5=text5;
            this.text6=text6;
            this.selectedIndex=selectedIndex;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Role} Рейнинг: {Rate}";
        }

    }
}
