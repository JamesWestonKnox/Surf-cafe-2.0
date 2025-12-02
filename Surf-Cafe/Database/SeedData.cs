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

        public void SeedCategories()
        {
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();

                if (!db.Categories.Any())
                {
                    var Food = new Category
                    {
                        CategoryName = "Food"
                    };

                    var HotDrinks = new Category
                    {
                        CategoryName = "Hot Drinks"
                    };

                    db.Categories.Add(Food);
                    db.Categories.Add(HotDrinks);
                    db.SaveChanges();
                }
            }
        }

        public void SeedProducts()
        {
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();

                if (!db.MenuItems.Any())
                {
                    var Food = db.Categories.FirstOrDefault(c => c.CategoryName == "Food");
                    var HotDrinks = db.Categories.FirstOrDefault(c => c.CategoryName == "Hot Drinks");

                    if (Food != null)
                    {
                        var campfire = new MenuItem
                        {
                            Name = "Campfire Breakfast",
                            Price = 90.00m,
                            Description = "",
                            CategoryID = Food.CategoryID,
                        };

                        var avoToast = new MenuItem
                        {
                            Name = "Smashed Avo",
                            Price = 110.00m,
                            Description = "",
                            CategoryID = Food.CategoryID,
                        };

                        var chickenWrap = new MenuItem
                        {
                            Name = "Chicken Mayo Wrap",
                            Price = 80.00m,
                            Description = "",
                            CategoryID = Food.CategoryID,
                        };

                        var muffin = new MenuItem
                        {
                            Name = "Assorted Muffins",
                            Price = 20.00m,
                            Description = "",
                            CategoryID = Food.CategoryID,
                        };

                        db.MenuItems.Add(campfire);
                        db.MenuItems.Add(avoToast);
                        db.MenuItems.Add(chickenWrap);
                        db.MenuItems.Add(muffin);
                    }

                    if (HotDrinks != null)
                    {
                        var flatWhite = new MenuItem
                        {
                            Name = "Flat White",
                            Price = 30.00m,
                            Description = "",
                            CategoryID = HotDrinks.CategoryID,
                        };

                        var cappachino = new MenuItem
                        {
                            Name = "Cappachino",
                            Price = 40.00m,
                            Description = "",
                            CategoryID = HotDrinks.CategoryID,
                        };

                        var tea = new MenuItem
                        {
                            Name = "Tea Assorted",
                            Price = 25.00m,
                            Description = "",
                            CategoryID = HotDrinks.CategoryID,
                        };

                        db.MenuItems.Add(flatWhite);
                        db.MenuItems.Add(cappachino);
                        db.MenuItems.Add(tea);
                    }

                    db.SaveChanges();
                }
            }
        }

        public void SeedOrders()
        {
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();

                if (!db.Orders.Any())
                {
                    var Admin = db.Users.FirstOrDefault(u => u.Username == "Admin");
                    var Employee = db.Users.FirstOrDefault(u => u.Username == "Employee");

                    if (Admin != null && Employee != null)
                    {
                        var order1 = new Order
                        {
                            OrderName = "Window Table",
                            OrderDateTime = DateTime.Now,
                            OrderTotal = 0m,
                            VATAmount = 0m,
                            Status = OrderStatus.Opened,
                            UserID = Admin.UserID
                        };

                        var order2 = new Order
                        {
                            OrderName = "Outside Corner",
                            OrderDateTime = DateTime.Now,
                            OrderTotal = 0m,
                            VATAmount = 0m,
                            Status = OrderStatus.Opened,
                            UserID = Employee.UserID
                        };

                        db.Orders.Add(order1);
                        db.Orders.Add(order2);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
