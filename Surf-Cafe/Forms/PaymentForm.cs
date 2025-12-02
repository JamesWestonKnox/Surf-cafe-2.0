using Surf_Cafe.Models;

namespace Surf_Cafe.Forms
{
    public partial class PaymentForm : Form
    {
        private Order _order;
        public PaymentForm(Order order)
        {
            InitializeComponent();
            _order = order;
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

        }

        /// <summary>
        /// 
        /// Ensures tip text box allows only numbers
        ///
        /// ChatGpt Generated method
        /// Reference:
        /// Available at: https://chat.openai.com
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

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
