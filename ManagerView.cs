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
    public partial class ManagerView : Form
    {
        List<Request> requestRange = new List<Request>();
        public static User _user;
        public ManagerView(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileView pv = new ProfileView(_user);
            pv.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation(_user);
            lc.Show();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {

            lblGreeting.Text = "Hello, " + _user.fullname;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            requestRange = db.GetAllDoneRequestsFromRange(fieldStartDate.Text, fieldEndDate.Text);
            dbReport.DataSource = requestRange;
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            string fullname = fieldFullname.Text;
            string username = fieldUsername.Text;
            string address = fieldAddress.Text;
            string email = fieldEmail.Text;
            string password = "admin";
            string role = fieldRole.SelectedItem.ToString();


            if (fullname == "" || username == "" || address == "" || email == "" )
            {
                MessageBox.Show("Incomplete data. Enter again.");
                return;
            }

            User newUser = new User(1, fullname, username, password, "01/01/2000", email, address, role);
            DBAccess db = new DBAccess();
            db.CreateUser(newUser);
            MessageBox.Show($"User created with username '{username}', and password admin.'");
        }
    }
}
