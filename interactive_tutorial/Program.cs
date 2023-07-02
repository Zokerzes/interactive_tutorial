using interactive_tutorial.Context;
using interactive_tutorial.Forms;
using Microsoft.EntityFrameworkCore;

namespace interactive_tutorial

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new InteractiveTutorialContext();
            context.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new ManagerForm());
           // Application.Run(new MainForm());
        }
    }
}