namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLop = new System.Windows.Forms.Label();
            this.grbDSLop = new System.Windows.Forms.GroupBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbDSHS = new System.Windows.Forms.GroupBox();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.stths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.cmbGVCN = new System.Windows.Forms.ComboBox();
            this.grbDSLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.grbDSHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblLop.Location = new System.Drawing.Point(565, 9);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(236, 44);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Quản Lý Lớp";
            // 
            // grbDSLop
            // 
            this.grbDSLop.Controls.Add(this.dgvLop);
            this.grbDSLop.Location = new System.Drawing.Point(12, 249);
            this.grbDSLop.Name = "grbDSLop";
            this.grbDSLop.Size = new System.Drawing.Size(722, 334);
            this.grbDSLop.TabIndex = 2;
            this.grbDSLop.TabStop = false;
            this.grbDSLop.Text = "Danh Sách Lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaLop,
            this.TenLop,
            this.SiSo,
            this.GVCN,
            this.PhongHoc});
            this.dgvLop.Location = new System.Drawing.Point(6, 21);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(697, 668);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter);
            this.dgvLop.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLop_RowPostPaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 150;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 150;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ Số";
            this.SiSo.Name = "SiSo";
            // 
            // GVCN
            // 
            this.GVCN.DataPropertyName = "GVCN";
            this.GVCN.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.GVCN.Name = "GVCN";
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "Phòng Học";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(990, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(902, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(404, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grbDSHS
            // 
            this.grbDSHS.Controls.Add(this.dgvDSHS);
            this.grbDSHS.Location = new System.Drawing.Point(740, 249);
            this.grbDSHS.Name = "grbDSHS";
            this.grbDSHS.Size = new System.Drawing.Size(677, 323);
            this.grbDSHS.TabIndex = 6;
            this.grbDSHS.TabStop = false;
            this.grbDSHS.Text = "Danh Sách Học Sinh";
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stths,
            this.MaHS,
            this.TenHS,
            this.NgaySinh,
            this.HanhKiem,
            this.HocLuc});
            this.dgvDSHS.Location = new System.Drawing.Point(7, 22);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.RowTemplate.Height = 24;
            this.dgvDSHS.Size = new System.Drawing.Size(670, 401);
            this.dgvDSHS.TabIndex = 0;
            this.dgvDSHS.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDSHS_RowPostPaint);
            // 
            // stths
            // 
            this.stths.HeaderText = "STT";
            this.stths.Name = "stths";
            this.stths.Width = 50;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 70;
            // 
            // TenHS
            // 
            this.TenHS.DataPropertyName = "TenHS";
            this.TenHS.HeaderText = "Tên Học Sinh";
            this.TenHS.Name = "TenHS";
            this.TenHS.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // HanhKiem
            // 
            this.HanhKiem.DataPropertyName = "HanhKiem";
            this.HanhKiem.HeaderText = "Hạnh Kiểm";
            this.HanhKiem.Name = "HanhKiem";
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.HeaderText = "Học Lực";
            this.HocLuc.Name = "HocLuc";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(744, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(94, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Tìm Kiếm Lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(44, 101);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 17);
            this.lblMaLop.TabIndex = 11;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(44, 180);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(61, 17);
            this.lblTenLop.TabIndex = 12;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(340, 101);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(143, 17);
            this.lblGVCN.TabIndex = 13;
            this.lblGVCN.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // lblPhongHoc
            // 
            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Location = new System.Drawing.Point(340, 180);
            this.lblPhongHoc.Name = "lblPhongHoc";
            this.lblPhongHoc.Size = new System.Drawing.Size(78, 17);
            this.lblPhongHoc.TabIndex = 14;
            this.lblPhongHoc.Text = "Phòng Học";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(119, 101);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(195, 22);
            this.txtMaLop.TabIndex = 15;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(119, 177);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(195, 22);
            this.txtTenLop.TabIndex = 16;
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Location = new System.Drawing.Point(501, 180);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(195, 22);
            this.txtPhongHoc.TabIndex = 17;
            // 
            // cmbGVCN
            // 
            this.cmbGVCN.FormattingEnabled = true;
            this.cmbGVCN.Location = new System.Drawing.Point(501, 101);
            this.cmbGVCN.Name = "cmbGVCN";
            this.cmbGVCN.Size = new System.Drawing.Size(195, 24);
            this.cmbGVCN.TabIndex = 18;
            this.cmbGVCN.DropDown += new System.EventHandler(this.cmbGVCN_DropDown);
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 788);
            this.Controls.Add(this.cmbGVCN);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblPhongHoc);
            this.Controls.Add(this.lblGVCN);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grbDSHS);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grbDSLop);
            this.Controls.Add(this.lblLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLop";
            this.Text = "FrmLop";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            this.grbDSLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.grbDSHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.GroupBox grbDSLop;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbDSHS;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn stths;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.ComboBox cmbGVCN;
    }
}