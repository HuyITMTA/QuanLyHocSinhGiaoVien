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
            //Load form Lịch dạy
            FrmLichDay frmlichday = new FrmLichDay();
            frmlichday.TopLevel = false;
            frmlichday.Parent = tabLichDay;
            frmlichday.Show();
            frmlichday.Dock = DockStyle.Fill;
        }


        private void tabMenu_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHDSD frmhdsd = new FrmHDSD();
            //frmmonhoc.TopLevel = false;
            //frmhdsd.Parent = fr;
            frmhdsd.Show();
            //frmhdsd.Dock = DockStyle.Fill;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult XN = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(XN == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
