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
            //    if not -> Returnn error message.
            User user = Login("username0", "123", "Receptionist");
            Navigation nav = new Navigation();
            if (user.role == "Customer")
            {
                nav.DisplayCustomerView(user);
            }
            else if (user.role == "Receptionist")
            {
                nav.DisplayReceptionistView(user);
            }
            else if (user.role == "Technician")
            {
                nav.DisplayTechnicianView(user);

            }
            else if (user.role == "Manager")
            {
                nav.DisplayManagerView(user);
            }

            this.Hide();
        }
    }
}
