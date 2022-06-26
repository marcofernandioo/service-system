using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace code
{
    public partial class LoginView : Form
    {
        // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public LoginView()
        {
            InitializeComponent();
        }

        public User Login(string uname, string upass)
        {
            User tempUser = new User();
            // Fake Login function. Change later.
            DBAccess db = new DBAccess();
            tempUser = db.GetUserByUsername(uname).FirstOrDefault();
            if (tempUser == null)
            {
                MessageBox.Show("User not found.");
                return null;
            }
            if (tempUser.password != upass)
            {
                MessageBox.Show("Wrong Password");
                return null;
            }
            User user = new User(tempUser.username, tempUser.password, tempUser.role);
            return user;
            
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = Login(tboxUsername.Text, tboxPassword.Text);
            if (user == null) // Login Failed.
            {
                tboxPassword.Clear();
                return;
            }
            Navigation nav = new Navigation();
            string userRole = user.role;
            if (userRole == "Customer")
            {
                nav.DisplayCustomerView(user);
            }
            else if (userRole == "Receptionist")
            {
                nav.DisplayReceptionistView(user);
            }
            else if (userRole == "Technician")
            {
                nav.DisplayTechnicianView(user);

            }
            else if (userRole == "Manager")
            {
                nav.DisplayManagerView(user);
            }
            this.Hide();
        }

        private void tboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
