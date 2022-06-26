using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class User
    {
        public User(int UserID, string fullname, string username, string password, string birthdate, string email, string address, string role) 
        {
            this.UserID = UserID;
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.password = password;
            this.birthdate = birthdate;
            this.email = email;
            this.address = address;
            this.role = role;
        }

        public User ()
        {

        }
        public int UserID { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public string role { get; set; }

    }
}
