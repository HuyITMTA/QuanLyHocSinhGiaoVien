﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabControl tc = new TabControl();
            tc.Dock = DockStyle.Fill;
        }

        private void tabMenu_Selected(object sender, TabControlEventArgs e)
        {

            //Load form học sinh
            FrmHocSinh frmHS = new FrmHocSinh();
            frmHS.TopLevel = false;
            frmHS.Parent = tabHocSinh;
            frmHS.Show();
            frmHS.Dock = DockStyle.Fill;

        }

    }
}
