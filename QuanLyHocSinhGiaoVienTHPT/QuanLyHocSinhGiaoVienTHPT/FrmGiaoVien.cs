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
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
        }
        GiaoVien GV = new GiaoVien();
        string Ma_GV;

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GV.HienThiDSGV();
            dgvGiaoVien.DataSource = dt;
        }

        private void dgvGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvGiaoVien.RowCount; i++)
                dgvGiaoVien.Rows[i].Cells[0].Value = i + 1;

        }

        private void dgvGiaoVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_GV = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
            this.txtMaGV.Text = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
            this.txtTenGV.Text = dgvGiaoVien.Rows[dong].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvGiaoVien.Rows[dong].Cells[3].Value.ToString();
            this.cmbGioiTinh.Text = dgvGiaoVien.Rows[dong].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvGiaoVien.Rows[dong].Cells[5].Value.ToString();
            this.cmbMaMH.Text = dgvGiaoVien.Rows[dong].Cells[6].Value.ToString();
            this.txtDienThoai.Text = dgvGiaoVien.Rows[dong].Cells[7].Value.ToString();
            this.cmbLoaiThiDua.Text = dgvGiaoVien.Rows[dong].Cells[8].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (this.txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giáo viên không được bỏ trống");
            else
                 if (this.txtMaGV.TextLength > 10)
                MessageBox.Show("Mã giáo viên không được quá 10 ký tự");
            else
                        if (this.txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giáo viên không được bỏ trống");
            else
            {
                try
                {
                    GV.InsertGiaoVien(txtMaGV.Text, txtTenGV.Text, cmbMaMH.Text, cmbGioiTinh.Text, txtDienThoai.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, cmbLoaiThiDua.Text);
                    MessageBox.Show("Đã thêm giáo viên " + txtTenGV.Text + " thành công!");
                    FrmGiaoVien_Load(sender, e);
                }


                catch
                {
                    MessageBox.Show("Thêm giáo viên không thành công!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaGV.Clear();
            this.txtTenGV.Clear();
            this.dtpNgaySinh.ResetText();
            this.cmbGioiTinh.ResetText();
            this.cmbMaMH.ResetText();
            this.txtDiaChi.Clear();
            this.txtDienThoai.Clear();
            this.cmbLoaiThiDua.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn xóa giáo viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (XN == DialogResult.OK)
            {
                if (this.txtMaGV.TextLength == 0)
                    MessageBox.Show("Vui lòng chọn giáo viên để xóa!");
                else
                {
                    GV.DeleteGiaoVien(Ma_GV);
                    MessageBox.Show("Đã xóa giáo viên " + Ma_GV + " thành công!");
                    FrmGiaoVien_Load(sender, e);
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn sửa thông tin giáo viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (XN == DialogResult.OK)
            {
                if (this.txtMaGV.TextLength == 0)
                    MessageBox.Show("Mã giáo viên không được bỏ trống");
                else
                if (this.txtMaGV.TextLength > 10)
                    MessageBox.Show("Mã giáo viên không được quá 10 ký tự");
                else
                        if (this.txtTenGV.TextLength == 0)
                    MessageBox.Show("Tên giáo viên không được bỏ trống");
                else
                {
                    try
                    {
                        GV.EditGiaoVien(Ma_GV, txtMaGV.Text, txtTenGV.Text, cmbMaMH.Text, cmbGioiTinh.Text, txtDienThoai.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtDiaChi.Text, cmbLoaiThiDua.Text);
                        MessageBox.Show("Đã sửa giáo viên thành công!");
                        FrmGiaoVien_Load(sender, e);
                    }


                    catch
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
            }
            else
            {
                FrmGiaoVien_Load(sender, e);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
            DataTable dt = new DataTable();
            dt = GV.SearchGiaoVien(this.txtSearch.Text);
            dgvGiaoVien.DataSource = dt;
        }
        private void cmbMaMH_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = GV.HienThiDSMonHoc();
            cmbMaMH.DataSource = dt;
            cmbMaMH.DisplayMember = "MaMH";
            cmbMaMH.ValueMember = "MaMH";
        }
    }
}



