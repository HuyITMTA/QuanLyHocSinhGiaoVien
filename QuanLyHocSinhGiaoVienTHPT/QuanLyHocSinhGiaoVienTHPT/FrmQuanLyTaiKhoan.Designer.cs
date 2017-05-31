namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmQuanLyTaiKhoan
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
            this.lblQLTaiKhoan = new System.Windows.Forms.Label();
            this.grbDSTK = new System.Windows.Forms.GroupBox();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.grbTTTK = new System.Windows.Forms.GroupBox();
            this.btbDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.grbTTTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLTaiKhoan
            // 
            this.lblQLTaiKhoan.AutoSize = true;
            this.lblQLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTaiKhoan.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblQLTaiKhoan.Location = new System.Drawing.Point(568, 26);
            this.lblQLTaiKhoan.Name = "lblQLTaiKhoan";
            this.lblQLTaiKhoan.Size = new System.Drawing.Size(288, 38);
            this.lblQLTaiKhoan.TabIndex = 0;
            this.lblQLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // grbDSTK
            // 
            this.grbDSTK.Controls.Add(this.dgvNguoiDung);
            this.grbDSTK.Location = new System.Drawing.Point(703, 114);
            this.grbDSTK.Name = "grbDSTK";
            this.grbDSTK.Size = new System.Drawing.Size(628, 458);
            this.grbDSTK.TabIndex = 1;
            this.grbDSTK.TabStop = false;
            this.grbDSTK.Text = "Danh sách tài khoản";
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.AllowUserToResizeColumns = false;
            this.dgvNguoiDung.AllowUserToResizeRows = false;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenNguoiDung,
            this.MatKhau,
            this.quyen});
            this.dgvNguoiDung.Location = new System.Drawing.Point(22, 22);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(581, 427);
            this.dgvNguoiDung.TabIndex = 0;
            this.dgvNguoiDung.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_RowEnter);
            this.dgvNguoiDung.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvNguoiDung_RowPrePaint);
            // 
            // grbTTTK
            // 
            this.grbTTTK.Controls.Add(this.btbDelete);
            this.grbTTTK.Controls.Add(this.btnEdit);
            this.grbTTTK.Controls.Add(this.btnAdd);
            this.grbTTTK.Controls.Add(this.cmbQuyen);
            this.grbTTTK.Controls.Add(this.txtPass);
            this.grbTTTK.Controls.Add(this.txtUser);
            this.grbTTTK.Controls.Add(this.lblQuyen);
            this.grbTTTK.Controls.Add(this.lblMatKhau);
            this.grbTTTK.Controls.Add(this.lblTenTaiKhoan);
            this.grbTTTK.Location = new System.Drawing.Point(25, 114);
            this.grbTTTK.Name = "grbTTTK";
            this.grbTTTK.Size = new System.Drawing.Size(563, 458);
            this.grbTTTK.TabIndex = 2;
            this.grbTTTK.TabStop = false;
            this.grbTTTK.Text = "Thông tin tài khoản";
            // 
            // btbDelete
            // 
            this.btbDelete.Location = new System.Drawing.Point(371, 295);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(75, 23);
            this.btbDelete.TabIndex = 9;
            this.btbDelete.Text = "Xóa";
            this.btbDelete.UseVisualStyleBackColor = true;
            this.btbDelete.Click += new System.EventHandler(this.btbDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(217, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cmbQuyen.Location = new System.Drawing.Point(186, 159);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(218, 24);
            this.cmbQuyen.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(186, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(218, 22);
            this.txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(186, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(218, 22);
            this.txtUser.TabIndex = 3;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(41, 162);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(50, 17);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Quyền";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(41, 106);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(29, 59);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(95, 17);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1024, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNguoiDung.DataPropertyName = "TenDangNhap";
            this.TenNguoiDung.HeaderText = "Tên Người Dùng";
            this.TenNguoiDung.Name = "TenNguoiDung";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // quyen
            // 
            this.quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quyen.DataPropertyName = "Quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.Name = "quyen";
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 575);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grbTTTK);
            this.Controls.Add(this.grbDSTK);
            this.Controls.Add(this.lblQLTaiKhoan);
            this.Name = "FrmQuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Load);
            this.grbDSTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.grbTTTK.ResumeLayout(false);
            this.grbTTTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLTaiKhoan;
        private System.Windows.Forms.GroupBox grbDSTK;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.GroupBox grbTTTK;
        private System.Windows.Forms.Button btbDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}