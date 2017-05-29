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

namespace QuanLyHocSinhGiaoVienTHPT
{
    public partial class FrmHocSinh : Form
    {
        public FrmHocSinh()
        {
            InitializeComponent();
        }

        HocSinh HS = new HocSinh();
        string Ma_HS;
        private void FrmHocSinh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HS.HienThiDSHS();
            dgvHocSinh.DataSource = dt;
        }

        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvHocSinh.RowCount; i++)
                dgvHocSinh.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvHocSinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_HS = dgvHocSinh.Rows[dong].Cells[1].Value.ToString();
            this.txtMaHS.Text = dgvHocSinh.Rows[dong].Cells[1].Value.ToString();
            this.txtTenHS.Text = dgvHocSinh.Rows[dong].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvHocSinh.Rows[dong].Cells[3].Value.ToString();
            this.cmbGioiTinh.Text = dgvHocSinh.Rows[dong].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvHocSinh.Rows[dong].Cells[5].Value.ToString();
            this.cmbLop.Text = dgvHocSinh.Rows[dong].Cells[6].Value.ToString();
            this.cmbHanhKiem.Text = dgvHocSinh.Rows[dong].Cells[7].Value.ToString();
            this.cmbHocLuc.Text = dgvHocSinh.Rows[dong].Cells[8].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaHS.Clear();
            this.txtTenHS.Clear();
            this.dtpNgaySinh.ResetText();
            this.cmbGioiTinh.ResetText();
            this.cmbHanhKiem.ResetText();
            this.txtDiaChi.Clear();
            this.cmbLop.ResetText();
            this.cmbHocLuc.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn xóa học sinh?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (XN == DialogResult.OK)
            {
                if (this.txtMaHS.TextLength == 0)
                    MessageBox.Show("Vui lòng chọn học sinh để xóa!");
                else
                {
                    HS.DeleteHocSinh(Ma_HS);
                    MessageBox.Show("Đã xóa học sinh " + Ma_HS + " thành công!");
                    FrmHocSinh_Load(sender, e);
                }
            }
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtMaHS.TextLength == 0)
                MessageBox.Show("Mã học sinh không được bỏ trống");
            else
                 if (this.txtMaHS.TextLength > 10)
                MessageBox.Show("Mã giáo viên không được quá 10 ký tự");
            else
                        if (this.txtTenHS.TextLength == 0)
                MessageBox.Show("Tên học sinh không được bỏ trống");
            else
            {
                try
                {
                    HS.InsertHocSinh(txtMaHS.Text, txtTenHS.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), cmbGioiTinh.Text, txtDiaChi.Text, cmbLop.Text, cmbHanhKiem.Text, cmbHocLuc.Text);
                    MessageBox.Show("Đã thêm học sinh " + txtTenHS.Text + " thành công!");
                    FrmHocSinh_Load(sender, e);
                }


                catch
                {
                    MessageBox.Show("Thêm học sinh không thành công!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn sửa thông tin học sinh?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (XN == DialogResult.OK)
            {
                if (this.txtMaHS.TextLength == 0)
                    MessageBox.Show("Mã học sinh không được bỏ trống");
                else
                if (this.txtMaHS.TextLength > 10)
                    MessageBox.Show("Mã học sinh không được quá 10 ký tự");
                else
                        if (this.txtTenHS.TextLength == 0)
                    MessageBox.Show("Tên học sinh không được bỏ trống");
                else
                {
                    try
                    {
                        HS.EditHocSinh(Ma_HS, txtMaHS.Text, txtTenHS.Text, dtpNgaySinh.Value.ToString("yyyy/MM/dd"), cmbGioiTinh.Text, txtDiaChi.Text, cmbLop.Text, cmbHanhKiem.Text, cmbHocLuc.Text);
                        MessageBox.Show("Đã sửa học sinh thành công!");
                        FrmHocSinh_Load(sender, e);
                    }


                    catch
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
            }
            else
            {
                FrmHocSinh_Load(sender, e);
            }

        }

        private void cmbLop_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HS.HienThiDSLop();
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "MaLop";
            cmbLop.ValueMember = "MaLop";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HS.SearchHocSinh(this.txtSearch.Text);
            dgvHocSinh.DataSource = dt;
        }
    }
}

