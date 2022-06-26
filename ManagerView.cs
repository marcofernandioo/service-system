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
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            requestRange = db.GetAllDoneRequestsFromRange(fieldStartDate.Text, fieldEndDate.Text);
            dbReport.DataSource = requestRange;
        }
    }
}
