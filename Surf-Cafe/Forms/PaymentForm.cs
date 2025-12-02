using Surf_Cafe.Database;
using Surf_Cafe.Models;

namespace Surf_Cafe.Forms
{
    public partial class PaymentForm : Form
    {
        private Order _order;
        private DBContext db = new DBContext();
        public event Action PaymentCompleted;

        private Dictionary<string, decimal> _discountPercentages = new Dictionary<string, decimal>
        {
            { "10%", 0.10m },
            { "15%", 0.15m },
            { "20%", 0.20m },
            { "50%", 0.50m },
            { "None", 0m }
        };
        public PaymentForm(Order order)
        {
            InitializeComponent();
            _order = order;
            UpdatePaymentFormTotal();
        }

        private void UpdatePaymentFormTotal()
        {
            decimal tip = 0;
            decimal discountPercentage = 0;

            if (!string.IsNullOrWhiteSpace(txtTip.Text))
            {
                tip = decimal.Parse(txtTip.Text);
            }

            if (cmbDiscount.SelectedItem != null)
            {
                discountPercentage = _discountPercentages[cmbDiscount.SelectedItem.ToString()];
            }

            decimal discount = _order.OrderTotal * discountPercentage;
            decimal paymentTotal = _order.OrderTotal - discount + tip;

            txtPaymentAmount.Text = $"R {paymentTotal:0.00}";
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderName_Click(object sender, EventArgs e)
        {

        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            UpdatePaymentFormTotal();
        }

        /// <summary>
        /// 
        /// Ensures tip text box allows only numbers
        ///
        /// ChatGpt Generated method
        /// 
        /// Reference:
        /// ChatGPT
        /// OpenAI, 2025. ChatGPT[Computer program]. Version GPT-5 mini.
        /// Available at: https://chat.openai.com
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedItem == null)
            {
                MessageBox.Show("Select a payment type.");
                return;
            }

            string totalText = txtPaymentAmount.Text.Replace("R", "").Trim();
            decimal totalDecimal = decimal.Parse(totalText);
            PaymentType paymentType = (PaymentType)Enum.Parse(typeof(PaymentType), cmbPaymentType.SelectedItem.ToString());

            var payment = new Payment
            {
                Type = paymentType,
                PaymentAmount = totalDecimal,
                PaymentDateTime = DateTime.Now,
                OrderID = _order.OrderID
            };

            var orderToUpdate = db.Orders.First(o => o.OrderID == _order.OrderID);
            orderToUpdate.Status = OrderStatus.Closed;
            db.Payments.Add(payment);
            db.SaveChanges();

            PaymentCompleted?.Invoke();
            this.Close();
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePaymentFormTotal();
        }
    }
}
