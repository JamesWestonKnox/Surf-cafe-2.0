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
        private FlowLayoutPanel flowLayoutOrders;
        public OrdersUserControl()
        {
            InitializeComponent();

            flowLayoutOrders = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            this.Controls.Add(flowLayoutOrders);
            LoadOrders();
        }

        private void LoadOrders()
        {
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
                Height = 120,
                Margin = new Padding(10)
            };

            flowLayoutOrders.Controls.Add(orderCard);

        }

        public void RefreshOrder()
        {
            flowLayoutOrders.Controls.Clear();

            using (var db = new DBContext())
            {
                var openOrders = db.Orders.Where(o => o.Status == OrderStatus.Opened).ToList();

                foreach (var order in openOrders)
                {
                    AddOrderCard(order);
                }
            }
        }
        private void OrdersUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
