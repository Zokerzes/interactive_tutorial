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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserRole Role { get; set; }

        public int Rate { get; set; }

        public User() { }

        public User(string firstname, string lastname, string email, string phoneNumber, string login, string password, UserRole role)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Role} Рейнинг: {Rate}";
        }

    }
}
