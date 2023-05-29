using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.entities
{
    public abstract class User
    {
        public int Id { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }

        
    }
}
