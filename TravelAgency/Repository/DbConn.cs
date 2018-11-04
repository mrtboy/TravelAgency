using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TravelAgency.Repository
{
    public sealed class DbConn
    {
        private static DbConn _instance;
        private static object _lockThis = new object();

        private DbConn() { }

        public static DbConn createConnection()
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new DbConn();
            }
            return _instance;
        }

        public bool createQuery(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public DataSet ExecuteQuery(string query)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(ds);

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
