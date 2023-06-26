using interactive_tutorial.entities;
using interactive_tutorial.Entities;
using interactive_tutorial.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace interactive_tutorial.Context
{
    public partial class InteractiveTutorialContext : DbContext
    {
        public InteractiveTutorialContext()
        {

        }

        public InteractiveTutorialContext(DbContextOptions<InteractiveTutorialContext> options) : base(options) { }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Progress> Progresses { get; set; }

        public virtual DbSet<Content> Contents { get; set;}

        public virtual DbSet<Test> Tests { get; set; }

        public virtual DbSet<answersTexts> answersTexts { get; set; }

        public virtual DbSet<questionsTexts> questionsTexts { get; set; }
        public virtual DbSet<TrueAnswers> TrueAnswers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString)
                    .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProgressEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContentEntityMap).Assembly);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(questionsTextsEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(answersTextsEntityMap).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrueAnswersEntityMap).Assembly);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
