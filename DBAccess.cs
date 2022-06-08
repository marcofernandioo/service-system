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
        string connectionString = "Data Source=ZEPHYRUSG14\\SQLEXPRESS;Initial Catalog=ServiceSystem;Integrated Security=True;";
        public List<Request> GetAllRequests()
        {
            using(IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Request").ToList();
            }
        }
        public List<Request> GetTechnicianFixingRequests(string username)//cant
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests where Username='{username}' AND Status='Fixing'").ToList();
            }
        }
        public List<Request> GetPendingRequests()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests where RequestID=(Select RequestID From Requests where Status='Pending') ").ToList();
            }
        }
        public List<Request> GetCustomerOngoingRequests(string username)//cant
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests WHERE Username='{username}' AND NOT Status='Unpaid' AND NOT Status='Done'").ToList();
            }
        }
        public List<Request> GetCustomerRequestHistory(string username)//cant
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>($"SELECT * FROM Requests where Username='{username}' AND RequestID=(Select RequestID From Requests where Status='Done')").ToList();
            }
        }
        public List<Request> GetAllOngoingRequests()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests WHERE NOT Status='Unpaid' AND NOT Status='Done'").ToList();
            }
        }
        public List<Request> GetAllDoneRequests()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Requests where RequestID=(Select RequestID From Requests where Status='Done')").ToList();
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
    }
}
