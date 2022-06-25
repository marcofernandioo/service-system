using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class ReceptionistView : Form
    {
        List<Request> requests = new List<Request>();
        List<User> users = new List<User>();

        public static User _user;
        public ReceptionistView(User user)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            _user = user;
        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            users = db.GetAllUsers();
            dataGridView1.DataSource = users;
            /*
            var bindingList = new BindingList<Request>(requests);
            BindingList<Request> view = new BindingList<Request>(requests);
            
            List<MyObject> objects = new List<MyObject>();
            objects.Add(new MyObject(1, "A"));
            objects.Add(new MyObject(2, "B"));
            dataGridView1.DataSource = objects;
            */
            
        }
        private void fieldUsername_TextChanged(object sender, EventArgs e)
        {
            fieldFullname.Text = fieldUsername.Text;
            DBAccess db = new DBAccess();
            users = db.GetCustomerWithName(fieldUsername.Text);
            ChangeBindingListTo(users);
            

        }
        private void ChangeBindingListTo(List<User> list)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            fieldUsername.DataSource = bindingSource.DataSource;
            fieldUsername.DisplayMember = "username";
            fieldUsername.ValueMember = "username";
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fieldServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contReceptionist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radUrgent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileView pv = new ProfileView(_user);
            pv.Show();
            this.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation(_user);
            lc.Show();
            this.Visible = false;
        }
    }
}
