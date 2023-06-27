using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(): base("DefaultConnection") 
        {

        }
        public DbSet<Admin> Admins { get; set; }
        
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
       
    }
}
