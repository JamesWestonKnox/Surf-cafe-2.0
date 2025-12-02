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
            
            //Making the card and labels clickable
            this.Click += CardClicked;
            lblUser.Click += CardClicked;
            lblRole.Click += CardClicked;
        }

        //Setting the labels to the username and role
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

        //Calling the event to open the card
        private void CardClicked(object sender, EventArgs e)
        {
            UserClicked?.Invoke(UserID);
        }
    }
}
