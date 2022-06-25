using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class CustomerView : Form
    {
        public static CustomerView instance;
        public static User _user;
        public CustomerView(User user)
        {
            InitializeComponent();
            _user = user;
            MessageBox.Show(user.role, user.username);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();
            nav.DisplayProfileView(_user);
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation(_user);
            lc.Show();
            this.Visible = false;
        }
    }
}
