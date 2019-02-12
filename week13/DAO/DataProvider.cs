using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class DataProvider
    {
        //Ket noi
        public static SqlConnection Conn()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=giaodien;Integrated Security=True");
            connection.Open();
            return connection;
        }

        public static void Closeconn(SqlConnection connection)
        { connection.Close(); }

        public static DataTable Getingdata(string query, SqlConnection connection)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, connection);
            adapt.Fill(tbl);
            return tbl;
        }

        public static bool ExcuteNQuery(string query, SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
