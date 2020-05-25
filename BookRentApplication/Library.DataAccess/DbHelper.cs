using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    class DbHelper
    {
        public string CommandText { get; set; }
        public Dictionary<string, object> Parameters { get; set; }

        SqlConnection conn;
        SqlCommand cmd;

        public DbHelper()
        {
            conn = new SqlConnection(Properties.Settings.Default.LibDB);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            Parameters = new Dictionary<string, object>();
        }

        internal int ExecuteQuery()
        {
            cmd.CommandText = this.CommandText;
            cmd.Parameters.Clear();
            foreach (KeyValuePair<string, object> item in this.Parameters)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        internal SqlDataReader GetEntity()
        {
            cmd.CommandText = this.CommandText;
            cmd.Parameters.Clear();
            foreach (KeyValuePair<string, object> item in this.Parameters)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
