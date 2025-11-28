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
using System.Globalization;

namespace Surf_Cafe.Forms
{
    public partial class OrderCard : UserControl
    {
        public Order Order {  get; set; }
        public OrderCard(Order order)
        {
            InitializeComponent();
            Order = order;

            lblOrderName.Text = order.OrderName;
            lblDateCreated.Text = order.OrderDateTime.ToString("g");
            lblTotal.Text = $"Total: {order.OrderTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-ZA"))}";
        }

        private void OrderCard_Load(object sender, EventArgs e)
        {

        }
    }
}
