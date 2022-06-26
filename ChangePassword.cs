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
    public partial class ChangePassword : Form
    {
        public static User _user;

        public ChangePassword(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass1 = fieldPass1.Text;
            string pass2 = fieldPass2.Text;
            if (pass1 != pass2)
            {
                MessageBox.Show("Passwords must match!");
            }
            User tempUser = new User(_user.UserID, _user.fullname, _user.username, pass1, _user.birthdate, _user.email, _user.address, _user.role);
            DBAccess db = new DBAccess();
            db.UpdateUserData(tempUser);

            this.Close();
            MessageBox.Show("Password Updated");
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();
            nav.DisplayProfileView(_user);
        }
    }
}
