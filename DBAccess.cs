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
    }
}
