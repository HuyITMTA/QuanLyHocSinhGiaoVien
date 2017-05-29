namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmHocSinh
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
            this.grbTTHocSinh = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmbHocLuc = new System.Windows.Forms.ComboBox();
            this.cmbHanhKiem = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblHocLuc = new System.Windows.Forms.Label();
            this.lblHanhKiem = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.grbDSHocSinh = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQLHS = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbTTHocSinh.SuspendLayout();
            this.grbDSHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTHocSinh
            // 
            this.grbTTHocSinh.Controls.Add(this.txtSearch);
            this.grbTTHocSinh.Controls.Add(this.btnReset);
            this.grbTTHocSinh.Controls.Add(this.btnDelete);
            this.grbTTHocSinh.Controls.Add(this.btnEdit);
            this.grbTTHocSinh.Controls.Add(this.btnAdd);
            this.grbTTHocSinh.Controls.Add(this.lblSearch);
            this.grbTTHocSinh.Controls.Add(this.dtpNgaySinh);
            this.grbTTHocSinh.Controls.Add(this.cmbHocLuc);
            this.grbTTHocSinh.Controls.Add(this.cmbHanhKiem);
            this.grbTTHocSinh.Controls.Add(this.cmbLop);
            this.grbTTHocSinh.Controls.Add(this.cmbGioiTinh);
            this.grbTTHocSinh.Controls.Add(this.txtDiaChi);
            this.grbTTHocSinh.Controls.Add(this.txtTenHS);
            this.grbTTHocSinh.Controls.Add(this.txtMaHS);
            this.grbTTHocSinh.Controls.Add(this.lblHocLuc);
            this.grbTTHocSinh.Controls.Add(this.lblHanhKiem);
            this.grbTTHocSinh.Controls.Add(this.lblLop);
            this.grbTTHocSinh.Controls.Add(this.lblDiaChi);
            this.grbTTHocSinh.Controls.Add(this.lblGioiTinh);
            this.grbTTHocSinh.Controls.Add(this.lblNgaySinh);
            this.grbTTHocSinh.Controls.Add(this.lblTenHS);
            this.grbTTHocSinh.Controls.Add(this.lblMaHS);
            this.grbTTHocSinh.Location = new System.Drawing.Point(12, 79);
            this.grbTTHocSinh.Name = "grbTTHocSinh";
            this.grbTTHocSinh.Size = new System.Drawing.Size(1406, 188);
            this.grbTTHocSinh.TabIndex = 0;
            this.grbTTHocSinh.TabStop = false;
            this.grbTTHocSinh.Text = "Thông tin học sinh";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1185, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(942, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1185, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(942, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(913, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 17);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Tìm Kiếm";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(166, 105);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(229, 22);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // cmbHocLuc
            // 
            this.cmbHocLuc.FormattingEnabled = true;
            this.cmbHocLuc.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu",
            "Kém"});
            this.cmbHocLuc.Location = new System.Drawing.Point(538, 146);
            this.cmbHocLuc.Name = "cmbHocLuc";
            this.cmbHocLuc.Size = new System.Drawing.Size(229, 24);
            this.cmbHocLuc.TabIndex = 14;
            // 
            // cmbHanhKiem
            // 
            this.cmbHanhKiem.FormattingEnabled = true;
            this.cmbHanhKiem.Items.AddRange(new object[] {
            "Yếu",
            "Trung bình",
            "Khá",
            "Tốt"});
            this.cmbHanhKiem.Location = new System.Drawing.Point(538, 102);
            this.cmbHanhKiem.Name = "cmbHanhKiem";
            this.cmbHanhKiem.Size = new System.Drawing.Size(229, 24);
            this.cmbHanhKiem.TabIndex = 13;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(538, 66);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(229, 24);
            this.cmbLop.TabIndex = 12;
            this.cmbLop.DropDown += new System.EventHandler(this.cmbLop_DropDown);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(166, 146);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(229, 24);
            this.cmbGioiTinh.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(538, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(166, 69);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(229, 22);
            this.txtTenHS.TabIndex = 9;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(166, 31);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(229, 22);
            this.txtMaHS.TabIndex = 8;
            // 
            // lblHocLuc
            // 
            this.lblHocLuc.AutoSize = true;
            this.lblHocLuc.Location = new System.Drawing.Point(434, 146);
            this.lblHocLuc.Name = "lblHocLuc";
            this.lblHocLuc.Size = new System.Drawing.Size(60, 17);
            this.lblHocLuc.TabIndex = 7;
            this.lblHocLuc.Text = "Học Lực";
            // 
            // lblHanhKiem
            // 
            this.lblHanhKiem.AutoSize = true;
            this.lblHanhKiem.Location = new System.Drawing.Point(434, 105);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Size = new System.Drawing.Size(77, 17);
            this.lblHanhKiem.TabIndex = 6;
            this.lblHanhKiem.Text = "Hạnh Kiểm";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(434, 69);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(32, 17);
            this.lblLop.TabIndex = 5;
            this.lblLop.Text = "Lớp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(434, 31);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(68, 146);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 17);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(68, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 17);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Location = new System.Drawing.Point(68, 69);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(94, 17);
            this.lblTenHS.TabIndex = 1;
            this.lblTenHS.Text = "Tên Học Sinh";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(68, 31);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(88, 17);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã Học Sinh";
            // 
            // grbDSHocSinh
            // 
            this.grbDSHocSinh.Controls.Add(this.dgvHocSinh);
            this.grbDSHocSinh.Location = new System.Drawing.Point(12, 290);
            this.grbDSHocSinh.Name = "grbDSHocSinh";
            this.grbDSHocSinh.Size = new System.Drawing.Size(1406, 505);
            this.grbDSHocSinh.TabIndex = 1;
            this.grbDSHocSinh.TabStop = false;
            this.grbDSHocSinh.Text = "Danh Sách Học Sinh";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AllowUserToDeleteRows = false;
            this.dgvHocSinh.AllowUserToResizeColumns = false;
            this.dgvHocSinh.AllowUserToResizeRows = false;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaHS,
            this.TenHS,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.Lop,
            this.HanhKiem,
            this.HocLuc});
            this.dgvHocSinh.Location = new System.Drawing.Point(19, 21);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.Size = new System.Drawing.Size(1368, 458);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_RowEnter);
            this.dgvHocSinh.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvHocSinh_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 70;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.Name = "MaHS";
            // 
            // TenHS
            // 
            this.TenHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHS.DataPropertyName = "TenHS";
            this.TenHS.HeaderText = "Tên Học Sinh";
            this.TenHS.Name = "TenHS";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // HanhKiem
            // 
            this.HanhKiem.DataPropertyName = "HanhKiem";
            this.HanhKiem.HeaderText = "Hạnh Kiểm";
            this.HanhKiem.Name = "HanhKiem";
            this.HanhKiem.Width = 150;
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.HeaderText = "Học Lực";
            this.HocLuc.Name = "HocLuc";
            this.HocLuc.Width = 150;
            // 
            // lblQLHS
            // 
            this.lblQLHS.AutoSize = true;
            this.lblQLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLHS.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQLHS.Location = new System.Drawing.Point(542, 22);
            this.lblQLHS.Name = "lblQLHS";
            this.lblQLHS.Size = new System.Drawing.Size(326, 44);
            this.lblQLHS.TabIndex = 2;
            this.lblQLHS.Text = "Quản Lý Học Sinh";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1023, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 22);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 809);
            this.Controls.Add(this.lblQLHS);
            this.Controls.Add(this.grbDSHocSinh);
            this.Controls.Add(this.grbTTHocSinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHocSinh";
            this.Text = "FrmHocSinh";
            this.Load += new System.EventHandler(this.FrmHocSinh_Load);
            this.grbTTHocSinh.ResumeLayout(false);
            this.grbTTHocSinh.PerformLayout();
            this.grbDSHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTHocSinh;
        private System.Windows.Forms.GroupBox grbDSHocSinh;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label lblQLHS;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbHocLuc;
        private System.Windows.Forms.ComboBox cmbHanhKiem;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblHocLuc;
        private System.Windows.Forms.Label lblHanhKiem;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.TextBox txtSearch;
    }
}