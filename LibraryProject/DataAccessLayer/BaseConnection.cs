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
        private static SqlCommand GetSqlCommand(string query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionBase.ConnectionString);
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
                return sqlCommand.ExecuteNonQuery() > 0;
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
                return sqlCommand.ExecuteScalar();
            }
            catch
            {
                return new object();
            }
        }

    }
}
