using Surf_Cafe.Models;

namespace Surf_Cafe.Database
{
    public class SeedData
    {
        public void SeedUsers()
        {
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
        }
    }
}
