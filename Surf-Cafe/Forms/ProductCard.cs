using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surf_Cafe.Forms
{
    public partial class ProductCard : UserControl
    {
        public int ProductID { get; set; }

        public ProductCard()
        {
            InitializeComponent();
            this.Click += ProductCard_Click;
            lblProductName.Click += ProductCard_Click;
        }

        /// <summary>
        /// Setting the label of the card to the productname
        /// </summary>
        public string ProductName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }

        public decimal Price { get; set; }

        public event Action<int> ProductClicked;

        //Calling the productClicked event
        private void ProductCard_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(ProductID);
        }
    }
}
