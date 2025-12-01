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
    public partial class OrderDetailsUserControl : UserControl
    {

        public OrderDetailsUserControl(Order order)
        {
            InitializeComponent();
        }
    }
}
