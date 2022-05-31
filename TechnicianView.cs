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
        public TechnicianView()
        {
            InitializeComponent();
        }

        private void TechnicianView_Load(object sender, EventArgs e)
        {

        }

        private void contTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutConfirmation lc = new LogoutConfirmation();
            lc.Show();
            this.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileView pv = new ProfileView();
            pv.Show();
            this.Visible = false;
        }
    }
}
