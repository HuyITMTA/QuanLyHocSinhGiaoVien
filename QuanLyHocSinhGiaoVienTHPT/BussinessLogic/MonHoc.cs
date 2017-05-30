using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogic
{
    public class MonHoc
    {
        Data da = new Data();

        public DataTable HienThiDSMH()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable SearchMonHoc(string Value)
        {
            string sql = "select * from MonHoc where TenMH like N'%" + Value + "%' or MaMH like N'%" + Value + "%' or BoMon like N'%" + Value + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
