using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;

namespace QuanLyHocSinhGiaoVienTHPT
{
    public partial class FrmDangNhap : Form
    {
        Form1 frm1 = new Form1();
        DangNhap DN = new DangNhap();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP88-PC;Initial Catalog=QL_HSGV;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from NguoiDung  where TenDangNhap = '" + txtUser.Text + "' and  MatKhau ='" + txtPass.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                DataTable dts = new DataTable();
                dts = DN.LayQuyen(this.txtUser.Text, this.txtPass.Text);
                Form1.quyen = dts.Rows[0][0].ToString().Trim();
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập ");
            }
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn có chắc muốn thoát?","Chú ý", MessageBoxButtons.YesNo,MessageBoxIcon.Warning );
            if (thongbao == DialogResult.Yes)
                Application.Exit();

        }

        private void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
