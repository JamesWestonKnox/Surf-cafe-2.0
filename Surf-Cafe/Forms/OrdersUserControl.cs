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
        public OrdersUserControl()
        {
            InitializeComponent();
            flpOrders.Dock = DockStyle.Fill;
            flpOrders.AutoScroll = true;
            LoadOrders();
        }

        private void LoadOrders()
        {
            flpOrders.Controls.Clear();

            using (var db = new DBContext())
            {
                var openOrders = db.Orders.Where(o => o.Status == OrderStatus.Opened).ToList();

                foreach (var order in openOrders)
                {
                    AddOrderCard(order);
                }

            }
        }

        public void AddOrderCard(Order order)
        {
            var orderCard = new OrderCard(order)
            {
                Width = 250,
                Height = 160,
                Margin = new Padding(10)
            };

            flpOrders.Controls.Add(orderCard);

        }

        public void RefreshOrder()
        {
            LoadOrders();
        }
        
    }
}
