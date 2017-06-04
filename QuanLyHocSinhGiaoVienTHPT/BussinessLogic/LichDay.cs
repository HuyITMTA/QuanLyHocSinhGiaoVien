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
    public class LichDay:Data
    {
        Data da = new Data();
        public DataTable HienThiDSGiaoVien()
        {
            SqlConnection conn = GetConnection();
            string sql = "select MaGV from GiaoVien";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
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
        

        public void InsertLichDay(string MaGV, string MaLop, string Thu, string Tiet)
        {
            string sql = "insert into LichDayHoc(MaGV, MaLop, Thu, Tiet) values ('" + MaGV + "',N'" + MaLop + "',N'" + Thu + "',N'" + Tiet + "')";
            da.ExcuteNonQuery(sql);
        }

        public void EditLichDay(string Ma_GV, string Ma_Lop, string MaGV, string MaLop, string Thu, string Tiet)
        {
            string sql = "update LichDayHoc set MaGV = N'" + MaGV + "', MaLop = N'" + MaLop + "', Thu = N'"+ Thu +"', Tiet = N'"+ Tiet +"' where (MaGV= '"+ Ma_GV +"' and MaLop = '"+ Ma_Lop +"')";
            da.ExcuteNonQuery(sql);
        }

        public void DeleteLichDay(string MaGV, string MaLop)
        {
            string sql = "Delete LichDayHoc where (MaGV = N'" + MaGV + "' and MaLop = '"+ MaLop +"')";
            da.ExcuteNonQuery(sql);
        }

        public DataTable HienThiDSLichDay()
        {
            string sql = "select * from LichDayHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable SearchLichDay(string Value)
        {
            string sql = "select * from LichDayHoc where MaGV like N'%" + Value + "%' or MaLop like N'%" + Value + "%' or Tiet like N'%" + Value + "%' or Thu like N'%" + Value + "%' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public int KiemTraTrungLap(string Ma_GV, string Ma_Lop)
        {
            SqlConnection conn = GetConnection();
            string sql = "select Count (*) from LichDayHoc where MaGV = '" + Ma_GV + "' and MaLop = '" + Ma_Lop + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            int x = (int)command.ExecuteScalar();
            return x;
        }

    }
}

