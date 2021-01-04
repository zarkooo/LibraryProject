using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Constant;

namespace DataAccessLayer
{
   public  class BaseConnection
    {
        private static SqlConnection sqlConnection = null;
        public static SqlCommand GetSqlCommand(string query)
        {
            try
            {
                sqlConnection = new SqlConnection(ConnectionBase.ConnectionString);
                sqlConnection.Open();
                return new SqlCommand(query, sqlConnection);
            }
            catch
            {
                return new SqlCommand();
            }
        }
        public static bool ExecuteNonQuerySqlCommand(string query)
        {
            try
            {
                SqlCommand sqlCommand = GetSqlCommand(query);
                int res = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return res > 0;
            }
            catch
            {
                return false;
            }
        }
        public static object ExecuteScalarSqlCommand(string query)
        {
            try
            {
                SqlCommand sqlCommand = GetSqlCommand(query);
                object o= sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return o;
            }
            catch
            {
                return new object();
            }
        }

    }
}
