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

        public string price;
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
            lblGreeting.Text = "Hello, " + _user.fullname;
        }
        private void fieldUsername_TextChanged(object sender, EventArgs e)
        {
            fieldFullname.Text = fieldUsername.Text;
            DBAccess db = new DBAccess();
            users = db.GetCustomerWithName(fieldUsername.Text);
            //ChangeBindingListTo(users);
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

        private void CalculateFee()
        {
            int price;
            int type = fieldServiceType.SelectedIndex;
            if (radNormal.Checked)
            {
                if (type == 0)
                {
                    price = 50;
                }
                else if (type == 1)
                {
                    price = 60;
                }
                else if (type == 2)
                {
                    price = 380;
                }
                else if (type == 3)
                {
                    price = 160;
                }
                else if (type == 4)
                {
                    price = 180;
                }
                else if (type == 5)
                {
                    price = 100;
                }
                else if (type == 6)
                {
                    price = 80;
                }
                else if (type == 7)
                {
                    price = 70;
                }
                else
                {
                    price = 0;
                }
            }
            else if (radUrgent.Checked)
            {
                if (type == 0)
                {
                    price = 80;
                }
                else if (type == 1)
                {
                    price = 90;
                }
                else if (type == 2)
                {
                    price = 430;
                }
                else if (type == 3)
                {
                    price = 200;
                }
                else if (type == 4)
                {
                    price = 210;
                }
                else if (type == 5)
                {
                    price = 150;
                }
                else if (type == 6)
                {
                    price = 130;
                }
                else if (type == 7)
                {
                    price = 100;
                }
                else
                {
                    price = 0;
                }
            }
            else
            {
                price = 0;
            }
            fieldFee.Text = $"RM. {price}";
            /*
            int price;
            string urgency;
           int type = fieldServiceType.SelectedIndex;
           if (radNormal.Checked)
            {
                if (type == 0)
                {
                    price = 50;
                }
                if (type == 1)
                {
                    price = 60;
                }
            }
            else if (radUrgent.Checked)
            {
                if (type == 0)
                {
                    price = 80;
                }
                if (type == 1)
                {
                    price = 90;
                }
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fieldServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }

        private void contReceptionist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radUrgent_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }
        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFee();
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

        
    }
}
