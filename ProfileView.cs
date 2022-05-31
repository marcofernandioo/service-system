namespace code
{
    public partial class ProfileView : Form
    {
        public static User _user;
        public ProfileView(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();
            // Have to improve on this part.
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