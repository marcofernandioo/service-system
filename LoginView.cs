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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            // DBAccess db = new DBAccess();
            // db.CreateDummyUser("", "", "", "", "", "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            ReceptionistView rv = new ReceptionistView();
            TechnicianView tv = new TechnicianView();
            ManagerView mv = new ManagerView();
            //cv.Show();
            //rv.Show();
            tv.Show();
            //mv.Show();
            this.Visible = false;
        }
    }
}
