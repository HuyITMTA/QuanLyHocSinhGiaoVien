using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;
using System.Data.SqlClient;

namespace QuanLyHocSinhGiaoVienTHPT
{
    public partial class FrmLichDay : Form
    {
        public FrmLichDay()
        {
            InitializeComponent();
        }

        LichDay LD = new LichDay();
        string Ma_GV;
        string Ma_Lop;
        
        private void cmbGiaoVien_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LD.HienThiDSGiaoVien();
            cmbGiaoVien.DataSource = dt;
            cmbGiaoVien.DisplayMember = "MaGV";
            cmbGiaoVien.ValueMember = "MaGV";
        }

        private void cmbLop_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LD.HienThiDSLop();
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "MaLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void cmbTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmLichDay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LD.HienThiDSLichDay();
            dgvLichDay.DataSource = dt;
        }

        private void dgvLichDay_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvLichDay.RowCount; i++)
                dgvLichDay.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvLichDay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_GV = dgvLichDay.Rows[dong].Cells[1].Value.ToString();
            Ma_Lop = dgvLichDay.Rows[dong].Cells[2].Value.ToString();
            this.cmbGiaoVien.Text = dgvLichDay.Rows[dong].Cells[1].Value.ToString();
            this.cmbLop.Text = dgvLichDay.Rows[dong].Cells[2].Value.ToString();
            this.cmbThu.Text = dgvLichDay.Rows[dong].Cells[3].Value.ToString();
            this.cmbTiet.Text = dgvLichDay.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LD.InsertLichDay(cmbGiaoVien.Text, cmbLop.Text, cmbThu.Text, cmbTiet.Text);
                MessageBox.Show("Đã thêm lịch dạy thành công!");
                FrmLichDay_Load(sender, e);
            }


            catch
            {
                MessageBox.Show("Thêm lịch dạy không thành công! Vui lòng kiểm tra lại", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn sửa thông tin lịch dạy?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (XN == DialogResult.OK)
            {
                try
                {
                    LD.EditLichDay(Ma_GV, Ma_Lop, cmbGiaoVien.Text, cmbLop.Text, cmbThu.Text, cmbTiet.Text);
                    MessageBox.Show("Đã sửa lịch dạy thành công!");
                    FrmLichDay_Load(sender, e);
                }


                catch
                {
                    MessageBox.Show("Sửa lịch dạy không thành công! Vui lòng kiểm tra lại", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn xóa lịch dạy?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (XN == DialogResult.OK)
            {
                    LD.DeleteLichDay(Ma_GV, Ma_Lop);
                    MessageBox.Show("Đã xóa lịch dạy thành công!");
                    FrmLichDay_Load(sender, e);                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LD.SearchLichDay(this.txtSearch.Text);
            dgvLichDay.DataSource = dt;
        }
    }
}
