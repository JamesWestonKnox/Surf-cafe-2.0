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
    public partial class UserCard : UserControl
    {
        public int UserID { get; set; }
        public UserCard()
        {
            InitializeComponent();
            this.Click += CardClicked;
            lblUser.Click += CardClicked;
            lblRole.Click += CardClicked;
        }

        public string Username
        {
            get => lblUser.Text;
            set => lblUser.Text = value;
        }

        public string Role 
        {
            get => lblRole.Text;
            set => lblRole.Text = value;
        }

        public event Action<int> UserClicked;

        private void CardClicked(object sender, EventArgs e)
        {
            UserClicked?.Invoke(UserID);
        }
    }
}
