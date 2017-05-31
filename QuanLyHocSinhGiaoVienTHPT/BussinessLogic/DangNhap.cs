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
    public class DangNhap
    {
        Data da = new Data();

        public DataTable HienThiDSTaiKhoan()
        {
            string sql = "select * from NguoiDung";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable LayQuyen(string user, string pass)
        {
            string sql = "select Quyen from NguoiDung where TenDangNhap = '"+ user +"' and MatKhau = '"+ pass +"' ";
            DataTable dts = new DataTable();
            dts = da.GetTable(sql);
            return dts;
        }
    }
}
