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

        private void ProfileView_Load(object sender, EventArgs e)
        {
            fieldUsername.Text = _user.username;
            fieldFullname.Text = _user.fullname;
            fieldAddress.Text = _user.address;
            fieldEmail.Text = _user.email;
            lblProfileRole.Text = _user.role;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Navigation nav = new Navigation();
            nav.DisplayChangePassword(_user);
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            User tempUser = new User(_user.UserID, fieldFullname.Text, fieldUsername.Text, _user.password, _user.birthdate, fieldEmail.Text, fieldAddress.Text,  _user.role);
            DBAccess db = new DBAccess();
            db.UpdateUserData(tempUser); // Update the data to the DB.
            Navigation nav = new Navigation();
            this.Close();
            nav.DisplayReceptionistView(tempUser);
            MessageBox.Show("Successfully Updated Your Data.");
        }
    }
}