using Surf_Cafe.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Models;

namespace Surf_Cafe.Forms
{
    public partial class OrdersUserControl : UserControl
    {
        public event Action<Order> OrderSelected;
        
        public OrdersUserControl()
        {
            InitializeComponent();
            flpOrders.Dock = DockStyle.Fill;
            flpOrders.AutoScroll = true;
            LoadOrders();
        }

        /// <summary>
        /// Loading all orders onto the user control as cards
        /// </summary>
        private void LoadOrders()
        {
            flpOrders.Controls.Clear();

            //Opening database connection
            using (var db = new DBContext())
            {
                //Retrieving all orders from the database with an open status
                var openOrders = db.Orders.Where(o => o.Status == OrderStatus.Opened).ToList();

                foreach (var order in openOrders)
                {
                   //Calling the method that creates a card for each order
                    AddOrderCard(order);
                }

            }
        }

        /// <summary>
        /// Creates a card for each order
        /// </summary>
        /// <param name="order"></param>
        public void AddOrderCard(Order order)
        {
            //Layout of order card
            var orderCard = new OrderCard(order)
            {
                Width = 250,
                Height = 160,
                Margin = new Padding(10)
            };

            //Calling the method linked to the event when the orderCard is clicked
            orderCard.OrderClicked += card_OrderCardClicked;

            //Adding the order controls to the flow layout panel
            flpOrders.Controls.Add(orderCard);

        }

        //Refreshes orders
        public void RefreshOrder()
        {
            LoadOrders();
        }
        
        //Method calles the OrderSelected Event
        private void card_OrderCardClicked(Order order)
        {
            OrderSelected?.Invoke(order);
        }
    }
}
