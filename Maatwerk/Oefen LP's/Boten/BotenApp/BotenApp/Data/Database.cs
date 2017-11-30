using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BotenApp.Data
{
    public class Database
    {
        private static readonly string connectionString = "Server=mssql.fhict.local;Database=dbi345158; User Id=dbi345158; Password=Heartless143!;";
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
