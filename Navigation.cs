using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class Navigation
    {
        public void DisplayCustomerView(User user) //Displaying CustomerView from LoginView
        {
            CustomerView view = new CustomerView(user);
            view.Show();
        }
        
        public void DisplayReceptionistView(User user)
        {
            ReceptionistView view = new ReceptionistView(user);
            view.Show();
        }
        public void DisplayTechnicianView(User user)
        {
            TechnicianView view = new TechnicianView(user);
            view.Show();
        }
        public void DisplayManagerView(User user)
        {
            ManagerView view = new ManagerView(user);
            view.Show();
        }
        public void DisplayProfileView(User user)
        {
            ProfileView view = new ProfileView(user);
            view.Show();
        }
    }
}
