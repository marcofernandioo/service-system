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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public LoginView()
        {
            InitializeComponent();
        }

        public User Login(string username, string password, string role)
        {
            // Fake Login function. Change later.
            User user = new User(username, password, role);
            return user;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            // DBAccess db = new DBAccess();
            // db.CreateDummyUser("", "", "", "", "", "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Get User input.
            // 2. Get User's Password from database.
            // 3. If success -> Return user data.
            //    if not -> Return error message.
            User user = Login("username0", "123", "Receptionist");
            Navigation nav = new Navigation();

            User obj1 = new User(tboxUsername.Text, tboxPassword.Text,"");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM user WHERE username ='" + obj1.username + "' AND password = '" + obj1.password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT role FROM user WHERE username ='" + obj1.username + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();
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
            }else
            {
                MessageBox.Show("Incorrect Username or Password!");
            con.Close();
            }



            this.Hide();
        }

        private void tboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
