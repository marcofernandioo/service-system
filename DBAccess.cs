using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace code
{
    public class DBAccess
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\_University\\IOOP\\_Assignment\\code\\Database1.mdf;Integrated Security=True";
        public List<Request> GetAllRequests()
        {
            using(IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests").ToList();
            }
        }
        public List<User> GetAllUsers()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<User>("SELECT * FROM Users").ToList();
            }
        }

        public List<User> GetCustomerWithName (string name)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                if (name == "")
                {
                    return new List<User>();
                }
                else
                {
                    return conn.Query<User>($"SELECT * FROM Users WHERE username LIKE '{name}%';").ToList();
                }
            }
        }

        public List<User> GetUserByUsername(string uname)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<User>($"SELECT * FROM Users WHERE username = '{uname}';").ToList();
            }
        }

        public List<Request> GetTechnicianFixingRequests(string username)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests WHERE Status = 'Fixing' AND TechnicianID = (SELECT UserID FROM Users WHERE Users.Username = '{username}');").ToList();
            }
        }
        public List<Request> GetPendingRequests()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests WHERE Status = 'Pending';").ToList();
            }
        }
        public List<Request> GetCustomerOngoingRequests(string username)//cant
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests WHERE Username='{username}' AND NOT Status='Unpaid' AND NOT Status='Done'").ToList();
            }
        }
        public List<Request> GetCustomerRequestHistory(string username)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests where Status = 'Done' AND CustomerID = (SELECT UserID FROM Users WHERE Username = '{username}'); ").ToList();
            }
        }
        public List<Request> GetAllOngoingRequests()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests WHERE NOT Status='Unpaid' AND NOT Status='Done'").ToList();
            }
        }
        public List<Request> GetAllDoneRequestsFromRange(string start, string end)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests where DatePaid > '{start}' AND DatePaid < '{end}';").ToList();
            }
        }
        public string GetLastPKfromRequestsTable()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                // Getting the last PK of 
                // return conn.Execute("SELECT TOP 1 * FROM Table ORDER BY ID DESC"); 
                return "";
            }
        }
        public void CreateDummyUser(string fullname, string username, string password, string dob, string email, string addr, string role)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string _id = GetLastPKfromRequestsTable();
                conn.Execute($"INSERT INTO Users VALUES ('{_id}', '{fullname}', '{username}', '{password}', '{dob}', '{email}', '{addr}', '{role}')");
            }
        }
        public void UpdateUserData(User user)
        {
            int uid = user.UserID;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Execute($"UPDATE Users SET fullname = '{user.fullname}', username = '{user.username}', password = '{user.password}', email = '{user.email}', address = '{user.address}' WHERE UserID = {uid};");
            }
        }

        public void CreateUser(User user)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Execute($"INSERT INTO Users VALUES ('{user.fullname}', '{user.username}', '{user.password}', '01/01/2000', '{user.email}', '{user.address}', '{user.role}');");
            }
        }

    }
}
