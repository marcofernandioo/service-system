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
        public ReceptionistView()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void ReceptionistView_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            requests = db.GetAllRequests();
            dataGridView1.DataSource = requests;
            //var bindingList = new BindingList<Request>(requests);
            //BindingList<Request> view = new BindingList<Request>(requests);
            /*
            dataGridView1.AutoGenerateColumns = true;
            List<MyObject> objects = new List<MyObject>();
            objects.Add(new MyObject(1, "A"));
            objects.Add(new MyObject(2, "B"));
            dataGridView1.DataSource = objects;
            */
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
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
    }
}
