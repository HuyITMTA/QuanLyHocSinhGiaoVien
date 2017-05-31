using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhGiaoVienTHPT
{
    public partial class Form1 : Form
    {
        public static string quyen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabControl tc = new TabControl();
            tc.Dock = DockStyle.Fill;
            if(quyen == "user")
            {
                thoátToolStripMenuItem.Enabled = false;
            }
        }

        private void tabMenu_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(XN == DialogResult.Yes)
            {
                Dispose();
                FrmDangNhap dangnhap = new FrmDangNhap();
                dangnhap.Show();
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(XN == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan frmql = new FrmQuanLyTaiKhoan();
            frmql.Show();
        }

        private void tabLop_Click(object sender, EventArgs e)
        {
            
        }
    }
}
