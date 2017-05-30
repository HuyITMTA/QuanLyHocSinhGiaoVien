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
    public partial class FrmLop : Form
    {
        public FrmLop()
        {
            InitializeComponent();
        }
        Lop lop = new Lop();
        string Ma_Lop;

        private void FrmLop_Load(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            DataTable dt = new DataTable();
            dt = lop.HienThiDSLop();
            dgvLop.DataSource = dt;
        }

        private void dgvLop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            for (int i = 0; i < dgvLop.RowCount; i++)
                dgvLop.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ma_Lop = dgvLop.Rows[e.RowIndex].Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            dt = lop.HienThiDSHS(Ma_Lop);
            dgvDSHS.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lop.TimKiemLop(txtSearch.Text);
            dgvLop.DataSource = dt;
        }

        private void dgvDSHS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            for (int i = 0; i < dgvDSHS.RowCount; i++)
                dgvDSHS.Rows[i].Cells[0].Value = i + 1;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn sửa thông tin lớp?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (XN == DialogResult.OK)
            {
                    try
                    {
                        lop.EditLop(Ma_Lop, cmbGVCN.Text, txtPhongHoc.Text);
                        MessageBox.Show("Đã sửa lớp thành công!");
                        FrmLop_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
            else
            {
                FrmLop_Load(sender, e);
            }
         }
          

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaLop.Clear();
            this.txtTenLop.Clear();
            this.cmbGVCN.ResetText();
            this.txtPhongHoc.Clear();
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_Lop = dgvLop.Rows[dong].Cells[1].Value.ToString();
            this.txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            this.txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString();
            this.cmbGVCN.Text = dgvLop.Rows[dong].Cells[4].Value.ToString();
            this.txtPhongHoc.Text = dgvLop.Rows[dong].Cells[5].Value.ToString();
        }

        private void cmbGVCN_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lop.HienThiDSGiaoVien();
            cmbGVCN.DataSource = dt;
            cmbGVCN.DisplayMember = "MaGV";
            cmbGVCN.ValueMember = "MaGV";
        }
    }
}
