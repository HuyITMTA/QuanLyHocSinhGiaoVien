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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        QuanLyTaiKhoan QL = new QuanLyTaiKhoan();
        string id;

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QL.HienThiDSTaiKhoan();
            dgvNguoiDung.DataSource = dt;
        }

        private void dgvNguoiDung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvNguoiDung.RowCount; i++)
                dgvNguoiDung.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvNguoiDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            id = dgvNguoiDung.Rows[dong].Cells[1].Value.ToString();
            this.txtUser.Text = dgvNguoiDung.Rows[dong].Cells[1].Value.ToString();
            this.txtPass.Text = dgvNguoiDung.Rows[dong].Cells[2].Value.ToString();
            this.cmbQuyen.Text = dgvNguoiDung.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtUser.TextLength == 0)
                MessageBox.Show("Tên tài khoản không được bỏ trống");
            else
                 if (this.txtUser.TextLength > 30)
                MessageBox.Show("Mã giáo viên không được quá 30 ký tự");
            else
                        if (this.txtPass.TextLength == 0)
                MessageBox.Show("Mật khẩu không được bỏ trống");
            else
            {
                try
                {
                    QL.InsertNguoiDung(txtUser.Text, txtPass.Text, cmbQuyen.Text);
                    MessageBox.Show("Đã thêm tài khoản thành công!");
                    FrmQuanLyTaiKhoan_Load(sender, e);
                }


                catch
                {
                    MessageBox.Show("Thêm tài khoản không thành công!");
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QL.SearchNguoiDung(this.txtSearch.Text);
            dgvNguoiDung.DataSource = dt;
        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn xóa người dùng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (XN == DialogResult.OK)
            {
                QL.DeleteNguoiDung(id);
                MessageBox.Show("Đã xóa người dùng thành công!");
                FrmQuanLyTaiKhoan_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn sửa thông tin người dùng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (XN == DialogResult.OK)
            {
                if (this.txtUser.TextLength == 0)
                    MessageBox.Show("tên người dùng không được bỏ trống");
                else
                if (this.txtUser.TextLength > 30)
                    MessageBox.Show("Tên người dùng không được quá 30 ký tự");
                else
                        if (this.txtPass.TextLength == 0)
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                else
                {
                    try
                    {
                        QL.EditNguoiDung(id, txtUser.Text, txtPass.Text, cmbQuyen.Text);
                        MessageBox.Show("Đã sửa người dùng thành công!");
                        FrmQuanLyTaiKhoan_Load(sender, e);
                    }


                    catch
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
            }
            else
            {
                FrmQuanLyTaiKhoan_Load(sender, e);
            }
        }
    }
}
