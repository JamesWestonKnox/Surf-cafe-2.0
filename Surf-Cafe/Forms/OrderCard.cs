using Surf_Cafe.Models;
using System.Globalization;

namespace Surf_Cafe.Forms
{
    public partial class OrderCard : UserControl
    {
        public Order Order { get; set; }

        public event Action<Order> OrderClicked;
        
        //Creating the order card which displays the name, total, time creating
        public OrderCard(Order order)
        {
            InitializeComponent();
            Order = order;
            this.Click += OrderCard_Click;
            lblOrderName.Text = order.OrderName;
            lblDateCreated.Text = order.OrderDateTime.ToString("g");
            lblTotal.Text = $"Total: {order.OrderTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-ZA"))}";

            //Making the labels clickable as well
            lblOrderName.Click += OrderCard_Click;
            lblDateCreated.Click += OrderCard_Click;
            lblTotal.Click += OrderCard_Click;
        }

        //Calling the OrderClicked event when they click on the order or labels
        private void OrderCard_Click(object sender, EventArgs e)
        {
            OrderClicked?.Invoke(Order);
        }

        private void OrderCard_Load(object sender, EventArgs e)
        {

        }
    }
}
