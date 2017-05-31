using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class Data
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP88-PC;Initial Catalog=QL_HSGV;Integrated Security=True");
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //conn.Close();
        }
    }
}

