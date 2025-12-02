using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Database;
using Surf_Cafe.Models;
namespace Surf_Cafe.Forms
{
    public partial class NewOrderForm : Form
    {
        private int _userId;

        private DBContext db = new DBContext();
        public NewOrderForm(int userID)
        {
            InitializeComponent();
            _userId = userID;
        }

        public Order newOrder { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves a new order to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            //Retrieving the order name from the input
            string orderName = txtOrderName.Text.Trim();

            //Validation ensuring required field isnt left out
            if (string.IsNullOrWhiteSpace(orderName))
            {
                MessageBox.Show("Please enter a valid order name");
                return;
            }

            //Creating a new order with the orderName... The other attributes are added afterwards
            var order = new Order
            {
                OrderName = orderName,
                OrderDateTime = DateTime.Now,
                OrderTotal = 0,
                VATAmount = 0,
                Status = OrderStatus.Opened,
                UserID = _userId
            };

            //Adding the order and saving the database
            db.Orders.Add(order);
            db.SaveChanges();

            newOrder = order;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}

   
