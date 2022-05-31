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
        string connectionString = "Data Source=DESKTOP-LJOO6HO\\SQLEXPRESS;Initial Catalog=ServiceSystem;Integrated Security=True;";
        public List<Request> GetAllRequests()
        {
            using(IDbConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                return conn.Query<Request>("SELECT * FROM Request").ToList();
            }
        }
        public List<Request> GetTechnicianFixingRequests(string username)
        {
            throw new NotImplementedException();
        }
        public List<Request> GetPendingRequests()
        {
            throw new NotImplementedException();
        }
        public List<Request> GetCustomerOngoingRequests(string username)
        {
            throw new NotImplementedException();
        }
        public List<Request> GetCustomerRequestHistory(string username)
        {
            throw new NotImplementedException();
        }
        public List<Request> GetAllOngoingRequests()
        {
            throw new NotImplementedException();
        }
        public List<Request> GetAllDoneRequests()
        {
            throw new NotImplementedException();
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
