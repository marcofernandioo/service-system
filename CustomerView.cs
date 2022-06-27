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
        List<Request> current = new List<Request> ();
        List<Request> history = new List<Request> ();
        public static CustomerView instance;
        public static User _user;
        public CustomerView(User user)
        {
            InitializeComponent();
            _user = user;
            DGVcurrent.AutoGenerateColumns = true;
            DGVhistory.AutoGenerateColumns = true;
            // MessageBox.Show(user.role, user.username);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();
            nav.DisplayProfileView(_user);
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation(_user);
            lc.Show();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            history = db.GetCustomerRequestHistory(_user.username);
            DGVhistory.DataSource = history;
            lblGreeting.Text = "Hello, " + _user.fullname;
        }
    }
}
