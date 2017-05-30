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
    public class Lop:Data
    {
        Data da = new Data();
        //string ma_lop;

        public string MaLop { get; private set; }

        public DataTable HienThiDSLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable HienThiDSHS(string Ma_Lop)
        {
            string sql = "select MaHS, TenHS, NgaySinh, HanhKiem, HocLuc from HocSinh h, Lop l where h.Lop = l.MaLop and l.MaLop = '"+ Ma_Lop +"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void EditLop(string MaLop1, string GVCN, string PhongHoc)
        {

            string sql = "update Lop set GVCN = N'" + GVCN + "', PhongHoc = N'" + PhongHoc + "' where MaLop = '"+ MaLop1 +"'";
            da.ExcuteNonQuery(sql);
        }

        public DataTable TimKiemLop(string Ma_Lop)
        {
            string sql = "select * from Lop where MaLop like N'%"+ Ma_Lop +"%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable HienThiDSGiaoVien()
        {
            SqlConnection conn = GetConnection();
            string sql = "select MaGV from GiaoVien";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
    }
}
