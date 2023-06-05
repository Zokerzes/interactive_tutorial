using interactive_tutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.entities
{
    public class UserData : ISerialize
    {
        public List<User> AllUsers { get; set; } = new List<User>();
        public string FileName { get; set; }=nameof(UserData);
        
        public void AddNewUser(User user)
        {
            AllUsers.Add(user);
        }
        public User CheckUser(string login,  string password)
        {
            foreach (User user in AllUsers)
            {
                if (user.Login==login&& user.Password==password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
