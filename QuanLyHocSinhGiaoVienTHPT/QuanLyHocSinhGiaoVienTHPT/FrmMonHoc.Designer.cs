namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmMonHoc
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
            this.lblQuanLyMonHoc = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblBoMon = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.cmbBoMon = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbTTMonHoc = new System.Windows.Forms.GroupBox();
            this.grbDSMonHoc = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTTMonHoc.SuspendLayout();
            this.grbDSMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyMonHoc
            // 
            this.lblQuanLyMonHoc.AutoSize = true;
            this.lblQuanLyMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyMonHoc.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQuanLyMonHoc.Location = new System.Drawing.Point(537, 38);
            this.lblQuanLyMonHoc.Name = "lblQuanLyMonHoc";
            this.lblQuanLyMonHoc.Size = new System.Drawing.Size(339, 44);
            this.lblQuanLyMonHoc.TabIndex = 0;
            this.lblQuanLyMonHoc.Text = "Quản Lý Môn Học";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(37, 158);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(87, 17);
            this.lblMaMH.TabIndex = 1;
            this.lblMaMH.Text = "Mã Môn Học";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(37, 231);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(93, 17);
            this.lblTenMH.TabIndex = 2;
            this.lblTenMH.Text = "Tên Môn Học";
            // 
            // lblBoMon
            // 
            this.lblBoMon.AutoSize = true;
            this.lblBoMon.Location = new System.Drawing.Point(50, 297);
            this.lblBoMon.Name = "lblBoMon";
            this.lblBoMon.Size = new System.Drawing.Size(56, 17);
            this.lblBoMon.TabIndex = 3;
            this.lblBoMon.Text = "Bộ Môn";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(201, 158);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(247, 22);
            this.txtMaMH.TabIndex = 4;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(201, 231);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(247, 22);
            this.txtTenMH.TabIndex = 5;
            // 
            // cmbBoMon
            // 
            this.cmbBoMon.FormattingEnabled = true;
            this.cmbBoMon.Items.AddRange(new object[] {
            "Tự Nhiên",
            "Xã Hội"});
            this.cmbBoMon.Location = new System.Drawing.Point(201, 297);
            this.cmbBoMon.Name = "cmbBoMon";
            this.cmbBoMon.Size = new System.Drawing.Size(247, 24);
            this.cmbBoMon.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(178, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grbTTMonHoc
            // 
            this.grbTTMonHoc.Controls.Add(this.txtSearch);
            this.grbTTMonHoc.Controls.Add(this.txtMaMH);
            this.grbTTMonHoc.Controls.Add(this.lblBoMon);
            this.grbTTMonHoc.Controls.Add(this.lblMaMH);
            this.grbTTMonHoc.Controls.Add(this.lblTenMH);
            this.grbTTMonHoc.Controls.Add(this.txtTenMH);
            this.grbTTMonHoc.Controls.Add(this.cmbBoMon);
            this.grbTTMonHoc.Location = new System.Drawing.Point(12, 85);
            this.grbTTMonHoc.Name = "grbTTMonHoc";
            this.grbTTMonHoc.Size = new System.Drawing.Size(629, 731);
            this.grbTTMonHoc.TabIndex = 12;
            this.grbTTMonHoc.TabStop = false;
            this.grbTTMonHoc.Text = "Thông tin môn học";
            // 
            // grbDSMonHoc
            // 
            this.grbDSMonHoc.Controls.Add(this.dgvMonHoc);
            this.grbDSMonHoc.Location = new System.Drawing.Point(679, 85);
            this.grbDSMonHoc.Name = "grbDSMonHoc";
            this.grbDSMonHoc.Size = new System.Drawing.Size(653, 731);
            this.grbDSMonHoc.TabIndex = 13;
            this.grbDSMonHoc.TabStop = false;
            this.grbDSMonHoc.Text = "Danh Sách Môn Học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AllowUserToResizeColumns = false;
            this.dgvMonHoc.AllowUserToResizeRows = false;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaMH,
            this.TenMH,
            this.BoMon});
            this.dgvMonHoc.Location = new System.Drawing.Point(18, 35);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(629, 690);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_RowEnter);
            this.dgvMonHoc.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvMonHoc_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 70;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            // 
            // BoMon
            // 
            this.BoMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BoMon.DataPropertyName = "BoMon";
            this.BoMon.HeaderText = "Bộ Môn";
            this.BoMon.Name = "BoMon";
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 828);
            this.Controls.Add(this.grbDSMonHoc);
            this.Controls.Add(this.grbTTMonHoc);
            this.Controls.Add(this.lblQuanLyMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonHoc";
            this.Text = "FrmMonHoc";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            this.grbTTMonHoc.ResumeLayout(false);
            this.grbTTMonHoc.PerformLayout();
            this.grbDSMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyMonHoc;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblBoMon;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.ComboBox cmbBoMon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbTTMonHoc;
        private System.Windows.Forms.GroupBox grbDSMonHoc;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoMon;
    }
}