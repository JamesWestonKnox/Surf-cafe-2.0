using Surf_Cafe.Database;
using Surf_Cafe.Forms;

namespace Surf_Cafe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();
                var seed = new SeedData();
                seed.SeedUsers();
            }

            Application.Run(new AdminLogin());
        }
    }
}