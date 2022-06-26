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
    public partial class TechnicianView : Form
    {
        List<Request> requestPool = new List<Request>();
        List<Request> myWorks = new List<Request>();
        public static User _user;

        public TechnicianView(User user)
        {
            InitializeComponent();
            _user = user;
            DGVrequestPool.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;
        }

        private void TechnicianView_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();

            requestPool = db.GetPendingRequests();
            DGVrequestPool.DataSource = requestPool;

            myWorks = db.GetTechnicianFixingRequests(_user.username);
            dataGridView2.DataSource = myWorks;
        }

        private void contTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation(_user);
            lc.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileView pv = new ProfileView(_user);
            pv.Show();
            this.Close();
        }
    }
}
