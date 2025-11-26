using Surf_Cafe.Database;

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
            }
            Application.Run(new Forms.AdminDashboardForm());
            Application.Run(new Login());

        }
    }
}