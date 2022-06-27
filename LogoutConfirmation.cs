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
    public partial class LogoutConfirmation : Form
    {
        public static User _user;
        public LogoutConfirmation(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void LogoutConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();

            if (_user.role == "Customer")
            {
                nav.DisplayCustomerView(_user);
            }
            else if (_user.role == "Receptionist")
            {
                nav.DisplayReceptionistView(_user);
            }
            else if (_user.role == "Technician")
            {
                nav.DisplayTechnicianView(_user);

            }
            else if (_user.role == "Manager")
            {
                nav.DisplayManagerView(_user);
            }
            this.Close();
        }
    }
}
