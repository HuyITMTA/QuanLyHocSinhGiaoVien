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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        MonHoc MH = new MonHoc();
        string Ma_MH;

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MH.HienThiDSMH();
            dgvMonHoc.DataSource = dt;
        }

        private void dgvMonHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvMonHoc.RowCount; i++)
                dgvMonHoc.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvMonHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_MH = dgvMonHoc.Rows[dong].Cells[1].Value.ToString();
            this.txtMaMH.Text = dgvMonHoc.Rows[dong].Cells[1].Value.ToString();
            this.txtTenMH.Text = dgvMonHoc.Rows[dong].Cells[2].Value.ToString();
            this.cmbBoMon.Text = dgvMonHoc.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaMH.Clear();
            this.txtTenMH.Clear();
            this.cmbBoMon.ResetText();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MH.SearchMonHoc(this.txtSearch.Text);
            dgvMonHoc.DataSource = dt;
        }
    }
}
