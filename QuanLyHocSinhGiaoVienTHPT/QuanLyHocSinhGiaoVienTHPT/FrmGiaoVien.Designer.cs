namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmGiaoVien
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
            this.gbDSGiaoVien = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.lblGiaoVien = new System.Windows.Forms.Label();
            this.gbTTGiaoVien = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbLoaiThiDua = new System.Windows.Forms.ComboBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblLoaiThiDua = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThiDua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDSGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.gbTTGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDSGiaoVien
            // 
            this.gbDSGiaoVien.Controls.Add(this.dgvGiaoVien);
            this.gbDSGiaoVien.Location = new System.Drawing.Point(10, 277);
            this.gbDSGiaoVien.Name = "gbDSGiaoVien";
            this.gbDSGiaoVien.Size = new System.Drawing.Size(1391, 323);
            this.gbDSGiaoVien.TabIndex = 0;
            this.gbDSGiaoVien.TabStop = false;
            this.gbDSGiaoVien.Text = "Danh Sách Giáo Viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaGV,
            this.TenGV,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.MaMH,
            this.DienThoai,
            this.LoaiThiDua});
            this.dgvGiaoVien.Location = new System.Drawing.Point(7, 21);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1384, 475);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_RowEnter);
            this.dgvGiaoVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvGiaoVien_RowPrePaint);
            // 
            // lblGiaoVien
            // 
            this.lblGiaoVien.AutoSize = true;
            this.lblGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaoVien.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGiaoVien.Location = new System.Drawing.Point(541, 9);
            this.lblGiaoVien.Name = "lblGiaoVien";
            this.lblGiaoVien.Size = new System.Drawing.Size(340, 44);
            this.lblGiaoVien.TabIndex = 1;
            this.lblGiaoVien.Text = "Quản Lý Giáo Viên";
            // 
            // gbTTGiaoVien
            // 
            this.gbTTGiaoVien.Controls.Add(this.dtpNgaySinh);
            this.gbTTGiaoVien.Controls.Add(this.btnAdd);
            this.gbTTGiaoVien.Controls.Add(this.btnDelete);
            this.gbTTGiaoVien.Controls.Add(this.btnEdit);
            this.gbTTGiaoVien.Controls.Add(this.btnReset);
            this.gbTTGiaoVien.Controls.Add(this.txtSearch);
            this.gbTTGiaoVien.Controls.Add(this.cmbLoaiThiDua);
            this.gbTTGiaoVien.Controls.Add(this.cmbMaMH);
            this.gbTTGiaoVien.Controls.Add(this.cmbGioiTinh);
            this.gbTTGiaoVien.Controls.Add(this.txtDienThoai);
            this.gbTTGiaoVien.Controls.Add(this.txtDiaChi);
            this.gbTTGiaoVien.Controls.Add(this.txtTenGV);
            this.gbTTGiaoVien.Controls.Add(this.txtMaGV);
            this.gbTTGiaoVien.Controls.Add(this.lblLoaiThiDua);
            this.gbTTGiaoVien.Controls.Add(this.lblDienThoai);
            this.gbTTGiaoVien.Controls.Add(this.lblMaMH);
            this.gbTTGiaoVien.Controls.Add(this.lblDiaChi);
            this.gbTTGiaoVien.Controls.Add(this.lblGioiTinh);
            this.gbTTGiaoVien.Controls.Add(this.lblNgaySinh);
            this.gbTTGiaoVien.Controls.Add(this.lblTenGV);
            this.gbTTGiaoVien.Controls.Add(this.lblMaGV);
            this.gbTTGiaoVien.Location = new System.Drawing.Point(13, 67);
            this.gbTTGiaoVien.Name = "gbTTGiaoVien";
            this.gbTTGiaoVien.Size = new System.Drawing.Size(1388, 189);
            this.gbTTGiaoVien.TabIndex = 2;
            this.gbTTGiaoVien.TabStop = false;
            this.gbTTGiaoVien.Text = "Thông Tin Giáo Viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(176, 101);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(234, 22);
            this.dtpNgaySinh.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(981, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(981, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1162, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1162, 138);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(960, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 22);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbLoaiThiDua
            // 
            this.cmbLoaiThiDua.FormattingEnabled = true;
            this.cmbLoaiThiDua.Items.AddRange(new object[] {
            "Hoàn thành tốt nhiệm vụ",
            "Hoàn thành nhiệm vụ",
            "Chưa hoàn thành nhiệm vụ"});
            this.cmbLoaiThiDua.Location = new System.Drawing.Point(568, 142);
            this.cmbLoaiThiDua.Name = "cmbLoaiThiDua";
            this.cmbLoaiThiDua.Size = new System.Drawing.Size(225, 24);
            this.cmbLoaiThiDua.TabIndex = 14;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(568, 66);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(225, 24);
            this.cmbMaMH.TabIndex = 13;
            this.cmbMaMH.DropDown += new System.EventHandler(this.cmbMaMH_DropDown);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(176, 138);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(234, 24);
            this.cmbGioiTinh.TabIndex = 12;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(568, 104);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(225, 22);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(568, 33);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(176, 69);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(234, 22);
            this.txtTenGV.TabIndex = 9;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(176, 33);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(234, 22);
            this.txtMaGV.TabIndex = 8;
            // 
            // lblLoaiThiDua
            // 
            this.lblLoaiThiDua.AutoSize = true;
            this.lblLoaiThiDua.Location = new System.Drawing.Point(444, 145);
            this.lblLoaiThiDua.Name = "lblLoaiThiDua";
            this.lblLoaiThiDua.Size = new System.Drawing.Size(118, 17);
            this.lblLoaiThiDua.TabIndex = 7;
            this.lblLoaiThiDua.Text = "Xếp Loại Thi Đua";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(444, 107);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(77, 17);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(444, 69);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(87, 17);
            this.lblMaMH.TabIndex = 5;
            this.lblMaMH.Text = "Mã Môn Học";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(444, 33);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(48, 145);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 17);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(48, 107);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 17);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(48, 69);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(99, 17);
            this.lblTenGV.TabIndex = 1;
            this.lblTenGV.Text = "Tên Giáo Viên";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(48, 33);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(93, 17);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã Giáo Viên";
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 70;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 160;
            // 
            // LoaiThiDua
            // 
            this.LoaiThiDua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiThiDua.DataPropertyName = "LoaiThiDua";
            this.LoaiThiDua.HeaderText = "Xếp Loại Thi Đua";
            this.LoaiThiDua.Name = "LoaiThiDua";
            // 
            // FrmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 842);
            this.Controls.Add(this.gbTTGiaoVien);
            this.Controls.Add(this.lblGiaoVien);
            this.Controls.Add(this.gbDSGiaoVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiaoVien";
            this.Text = "FrmGiaoVien";
            this.Load += new System.EventHandler(this.FrmGiaoVien_Load);
            this.gbDSGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.gbTTGiaoVien.ResumeLayout(false);
            this.gbTTGiaoVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSGiaoVien;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Label lblGiaoVien;
        private System.Windows.Forms.GroupBox gbTTGiaoVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbLoaiThiDua;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblLoaiThiDua;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThiDua;
    }
}