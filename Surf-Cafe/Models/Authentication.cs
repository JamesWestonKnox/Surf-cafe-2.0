using Microsoft.EntityFrameworkCore;
using Surf_Cafe.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------------------------------------- START OF FILE --------------------------------------------------------//

namespace Surf_Cafe.Models
{
    public class Authentication
    {

        //------------------------ Password Hashing -----------------------//

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        //------------------------ Password Verification -----------------------//

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        //------------------------ User Authentication -----------------------//

        public static User AuthenticationUser(string username, string password, UserRole expectedRole)
        {
            using (var context = new DBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Role == expectedRole);
                if (user != null && VerifyPassword(password, user.PasscodeHash))
                {
                    return user;
                }
                return null;
            }
        }

        //------------------------ User Creation -----------------------//

        public static bool CreateUser(string username, string password, UserRole role)
        {
            try
            {
                using (var context = new DBContext())
                {
                    if (context.Users.Any(u => u.Username == username))
                    {
                        return false;
                    }

                    var user = new User
                    {
                        Username = username,
                        PasscodeHash = HashPassword(password),
                        Role = role,
                        DateRegistered = DateTime.Now
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

//-------------------------------------------------------- End of File --------------------------------------------------------------//