# Surf Cafe Point-Of-Sale System 

A Point of sale system built for the surf cafe in blouberg strand for our final year project for the module XBCAD. the POS system features
a seperate admin and employee dashboard with ordering capabilities, inventroy management, stock reports, menu items, auto calaculations, and the capability to add new users and give them login
details based on their role at the cafe. 

# Admin Dashboard
Menu: Add, Edit, and orgranise your menu with custom pricing and catergories

Employee Management: Create new employee accounts and managae login details for new staff

Order Processing: The ability to create and track orders to help the flow and speed of operations within the cafe

Inventory Control: The ability to monitor stock levels and add thresholds to get notified when they are running low 

Reports: The ability to generate a detailed report om stock to gain further insight into the day to day business

note: The admin has full access to the entirity of the Point of sales system and its functions

# Employee Dashboard
Oder Processing - The Exact same capabilities as the admin dashboard and when an order is created it is synced to both pages so that both Employees and an Admin is capable of viewing it 

Menu: The Exact same capabilities as before in the AdminDashboard and it is also linked so that when a menu item is added it is added on both ends and capable of editing from both ends. 

# How to run the project

You will need access to .NET Framework, preferable 8.0 

- SQLite Database
- Windows Forms app

  # Installation of the app

  Step 1: Clone the Surf-cafe 2.0 Github Repositroy or Download and extract all from the ZIP file
  Step 2: Open the Solution in Visual Studio
  Step 3: Restore NuGet packages in the Tools tab at the top, then press Manage NuGet packages and Download the neccessarry package for the project
  Step 4: Run Database migration ( dotnet ef database update ) in the Terminal which can found if you click on view at the top and then select terminal
  Step 5: Sync the project and run the application by clicking the green play button

  #IMPORTANT
 # Default Login for Admin and Employee

  Employee Login - Username = Employee , and password = emp25!

  Admin Login - Username = Admin, and Password = admin25!

  
















  
