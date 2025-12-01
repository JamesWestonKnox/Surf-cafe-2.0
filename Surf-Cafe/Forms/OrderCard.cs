using Surf_Cafe.Models;
using System.Globalization;

namespace Surf_Cafe.Forms
{
    public partial class OrderCard : UserControl
    {
        public Order Order { get; set; }

        public event Action<Order> OrderClicked;
        public OrderCard(Order order)
        {
            InitializeComponent();
            Order = order;
            this.Click += OrderCard_Click;
            lblOrderName.Text = order.OrderName;
            lblDateCreated.Text = order.OrderDateTime.ToString("g");
            lblTotal.Text = $"Total: {order.OrderTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-ZA"))}";
            lblOrderName.Click += OrderCard_Click;
            lblDateCreated.Click += OrderCard_Click;
            lblTotal.Click += OrderCard_Click;
        }

        private void OrderCard_Click(object sender, EventArgs e)
        {
            OrderClicked?.Invoke(Order);
        }

        private void OrderCard_Load(object sender, EventArgs e)
        {

        }
    }
}
