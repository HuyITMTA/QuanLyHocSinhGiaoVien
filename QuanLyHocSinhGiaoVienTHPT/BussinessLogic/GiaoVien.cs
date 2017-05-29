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
    public class GiaoVien:Data
    {
        Data da = new Data();

        public string MaGV { get; private set; }

        public DataTable HienThiDSGV()
        {
            string sql = "select * from GiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertGiaoVien(string MaGV, string TenGV, string MaMH, string GioiTinh, string DT, string NgaySinh, string DiaChi, string LoaiThiDua)
        {
            string sql = "insert into GiaoVien(MaGV, TenGV, MaMH, GioiTinh, DienThoai, NgaySinh, DiaChi, LoaiThiDua) values ('" + MaGV + "',N'" + TenGV + "','" + MaMH + "',N'" + GioiTinh + "','" + DT + "','" + NgaySinh + "',N'"+ DiaChi + "',N'" + LoaiThiDua + "')";
            da.ExcuteNonQuery(sql);
        }

        public void DeleteGiaoVien(string MaGV)
        {
            string sql = "Delete GiaoVien where MaGV = N'" + MaGV + "'";
            da.ExcuteNonQuery(sql);
        }

        public void EditGiaoVien(string MaGV1, string MaGV, string TenGV, string MaMH, string GioiTinh, string DT, string NgaySinh, string DiaChi, string LoaiThiDua)
        {
            
            string sql = "update GiaoVien set MaGV = N'"+MaGV+"', TenGV = N'"+TenGV+"', GioiTinh = N'"+GioiTinh+"', DienThoai = '"+ DT +"', DiaChi = N'"+DiaChi+"', MaMH = '"+MaMH+"', NgaySinh = '"+ NgaySinh +"', LoaiThiDua = N'"+LoaiThiDua+"' where MaGV = '"+MaGV1+"'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchGiaoVien(string Value)
        {
            string sql = "select * from GiaoVien where TenGV like N'%"+Value+"%' or MaGV like N'%"+Value+ "%' or NgaySinh like N'%" + Value + "%' or GioiTinh like N'%" + Value + "%' or DiaChi like N'%" + Value + "%' or MaMH like N'%" + Value + "%' or DienThoai like N'%" + Value + "%' or LoaiThiDua like N'%" + Value + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable HienThiDSMonHoc()
        {
            SqlConnection conn = GetConnection();
            string sql = "select MaMH from MonHoc";
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
    }
}