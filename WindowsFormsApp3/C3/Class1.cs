using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace C3
{
    public class Class1
    {
         public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings["Dinu Alexandru14"].ConnectionString;
                
                OracleConnectionStringBuilder sb = new OracleConnectionStringBuilder(connStr);

                return sb.ToString();
            }
        }

        public static OracleConnection GetOracleConnection()
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static int ConnectionTimeout { get; set; }

        public static string ApplicationName
        {
            get;
            set;
        }
    }
}
