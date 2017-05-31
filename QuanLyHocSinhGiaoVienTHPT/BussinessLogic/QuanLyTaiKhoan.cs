using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using System.Data.SqlClient;

namespace BussinessLogic
{
    public class QuanLyTaiKhoan
    {
        Data da = new Data();

        public DataTable HienThiDSTaiKhoan()
        {
            string sql = "select * from NguoiDung";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertNguoiDung(string ID, string Pass, string quyen)
        {
            string sql = "insert into NguoiDung(TenDangNhap, MatKhau, Quyen) values (N'" + ID + "',N'" + Pass + "',N'" + quyen + "')";
            da.ExcuteNonQuery(sql);
        }

        public void DeleteNguoiDung(string ID)
        {
            string sql = "Delete NguoiDung where TenDangNhap = N'" + ID + "'";
            da.ExcuteNonQuery(sql);
        }

        public void EditNguoiDung(string ID1, string ID, string Pass, string quyen)
        {

            string sql = "update NguoiDung set TenDangNhap = N'" + ID + "', MatKhau = N'" + Pass + "', Quyen = N'" + quyen + "' where TenDangNhap = '" + ID1 + "'";
            da.ExcuteNonQuery(sql);
        }

        public DataTable SearchNguoiDung(string Value)
        {
            string sql = "select * from NguoiDung where TenDangNhap like N'%" + Value + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
