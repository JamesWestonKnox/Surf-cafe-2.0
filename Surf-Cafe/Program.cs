using Surf_Cafe.Database;
using Surf_Cafe.Forms;
using Surf_Cafe.Models;

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
                if (!db.Users.Any())
                {
                    var admin = new User
                    {
                        Username = "Admin",
                        PasscodeHash = Authentication.HashPassword("admin25!"),
                        Role = UserRole.Admin,
                        DateRegistered = DateTime.Now
                    };

                    var emp = new User
                    {
                        Username = "Employee",
                        PasscodeHash = Authentication.HashPassword("emp25!"),
                        Role = UserRole.Staff,
                        DateRegistered = DateTime.Now
                    };

                    db.Users.Add(admin);
                    db.Users.Add(emp);
                    db.SaveChanges();
                }
            }

            Application.Run(new AdminLogin());



        }
    }
}