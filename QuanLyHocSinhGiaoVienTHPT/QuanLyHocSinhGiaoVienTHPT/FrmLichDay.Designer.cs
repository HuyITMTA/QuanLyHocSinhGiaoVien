namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmLichDay
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
            this.lblLichDay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.grbLichDay = new System.Windows.Forms.GroupBox();
            this.dgvLichDay = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbThu = new System.Windows.Forms.ComboBox();
            this.cmbTiet = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbLichDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLichDay
            // 
            this.lblLichDay.AutoSize = true;
            this.lblLichDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichDay.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLichDay.Location = new System.Drawing.Point(533, 31);
            this.lblLichDay.Name = "lblLichDay";
            this.lblLichDay.Size = new System.Drawing.Size(256, 44);
            this.lblLichDay.TabIndex = 0;
            this.lblLichDay.Text = "Lịch Dạy Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo Viên";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(76, 181);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(32, 17);
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Lớp";
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(181, 120);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(121, 24);
            this.cmbGiaoVien.TabIndex = 5;
            this.cmbGiaoVien.DropDown += new System.EventHandler(this.cmbGiaoVien_DropDown);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(181, 178);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 24);
            this.cmbLop.TabIndex = 6;
            this.cmbLop.DropDown += new System.EventHandler(this.cmbLop_DropDown);
            // 
            // grbLichDay
            // 
            this.grbLichDay.Controls.Add(this.dgvLichDay);
            this.grbLichDay.Location = new System.Drawing.Point(628, 120);
            this.grbLichDay.Name = "grbLichDay";
            this.grbLichDay.Size = new System.Drawing.Size(735, 541);
            this.grbLichDay.TabIndex = 64;
            this.grbLichDay.TabStop = false;
            this.grbLichDay.Text = "Lịch dạy";
            // 
            // dgvLichDay
            // 
            this.dgvLichDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaGV,
            this.MaLop,
            this.Thu,
            this.Tiet});
            this.dgvLichDay.Location = new System.Drawing.Point(6, 21);
            this.dgvLichDay.Name = "dgvLichDay";
            this.dgvLichDay.RowTemplate.Height = 24;
            this.dgvLichDay.Size = new System.Drawing.Size(723, 399);
            this.dgvLichDay.TabIndex = 0;
            this.dgvLichDay.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichDay_RowEnter);
            this.dgvLichDay.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLichDay_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 70;
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // Thu
            // 
            this.Thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            // 
            // Tiet
            // 
            this.Tiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tiet.DataPropertyName = "Tiet";
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            // 
            // cmbThu
            // 
            this.cmbThu.FormattingEnabled = true;
            this.cmbThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.cmbThu.Location = new System.Drawing.Point(451, 120);
            this.cmbThu.Name = "cmbThu";
            this.cmbThu.Size = new System.Drawing.Size(121, 24);
            this.cmbThu.TabIndex = 65;
            // 
            // cmbTiet
            // 
            this.cmbTiet.FormattingEnabled = true;
            this.cmbTiet.Items.AddRange(new object[] {
            "Tiết 1",
            "Tiết 2",
            "Tiết 3",
            "Tiết 4",
            "Tiết 5"});
            this.cmbTiet.Location = new System.Drawing.Point(451, 191);
            this.cmbTiet.Name = "cmbTiet";
            this.cmbTiet.Size = new System.Drawing.Size(121, 24);
            this.cmbTiet.TabIndex = 66;
            this.cmbTiet.SelectedIndexChanged += new System.EventHandler(this.cmbTiet_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(239, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(427, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1050, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 22);
            this.txtSearch.TabIndex = 70;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 673);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTiet);
            this.Controls.Add(this.cmbThu);
            this.Controls.Add(this.grbLichDay);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbGiaoVien);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLichDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLichDay";
            this.Text = "FrmLichDay";
            this.Load += new System.EventHandler(this.FrmLichDay_Load);
            this.grbLichDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.GroupBox grbLichDay;
        private System.Windows.Forms.DataGridView dgvLichDay;
        private System.Windows.Forms.ComboBox cmbThu;
        private System.Windows.Forms.ComboBox cmbTiet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
    }
}