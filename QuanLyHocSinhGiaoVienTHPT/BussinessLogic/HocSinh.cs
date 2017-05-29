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
    public class HocSinh:Data
    {
        Data da = new Data();

        public string MaHS { get; private set; }

        public DataTable HienThiDSHS()
        {
            string sql = "select * from HocSinh";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertHocSinh(string MaHS, string TenHS, string NgaySinh, string GioiTinh, string DiaChi, string Lop, string HanhKiem, string HocLuc)
        {
            string sql = "insert into HocSinh(MaHS, TenHS, NgaySinh, GioiTinh, DiaChi, Lop, HanhKiem, HocLuc) values ('" + MaHS + "',N'" + TenHS + "','" + NgaySinh + "',N'" + GioiTinh + "',N'" + DiaChi + "','" + Lop + "',N'" + HanhKiem + "',N'" + HocLuc + "')";
            da.ExcuteNonQuery(sql);
        }

        public void DeleteHocSinh(string MaHS)
        {
            string sql = "Delete HocSinh where MaHS = N'" + MaHS + "'";
            da.ExcuteNonQuery(sql);
        }

        public void EditHocSinh(string MaHS1, string MaHS, string TenHS, string NgaySinh, string GioiTinh, string DiaChi, string Lop,  string HanhKiem , string HocLuc)
        {

            string sql = "update HocSinh set MaHS = N'" + MaHS + "', TenHS = N'" + TenHS + "', NgaySinh = '" + NgaySinh + "', GioiTinh = N'" + GioiTinh + "', DiaChi = N'" + DiaChi + "', Lop = '" + Lop + "', HanhKiem = N'" + HanhKiem + "', HocLuc = N'"+ HocLuc +"' where MaHS = '" + MaHS1 + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchHocSinh(string Value)
        {
            string sql = "select * from HocSinh where TenHS like N'%" + Value + "%' or MaHS like N'%" + Value + "%'  or NgaySinh like N'%" + Value + "%' or GioiTinh like N'%" + Value + "%' or DiaChi like N'%" + Value + "%' or Lop like N'%" + Value + "%' or HanhKiem like N'%" + Value + "%' or HocLuc like N'%" + Value + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable HienThiDSLop()
        {
            SqlConnection conn = GetConnection();
            string sql = "select MaLop from Lop";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
    }
        
}

