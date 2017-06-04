namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabLichDay = new System.Windows.Forms.TabPage();
            this.tabMonHoc = new System.Windows.Forms.TabPage();
            this.tabLop = new System.Windows.Forms.TabPage();
            this.tabGiaoVien = new System.Windows.Forms.TabPage();
            this.tabHocSinh = new System.Windows.Forms.TabPage();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHome.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blue-home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Calendar-icon.png");
            this.imageList1.Images.SetKeyName(2, "Categories-applications-education-school-icon.png");
            this.imageList1.Images.SetKeyName(3, "Occupations-Technical-Support-Representative-Female-Light-icon.png");
            this.imageList1.Images.SetKeyName(4, "Science-Classroom-icon.png");
            this.imageList1.Images.SetKeyName(5, "Student-3-icon.png");
            this.imageList1.Images.SetKeyName(6, "Teacher-female-icon.png");
            // 
            // tabLichDay
            // 
            this.tabLichDay.ImageIndex = 1;
            this.tabLichDay.Location = new System.Drawing.Point(4, 54);
            this.tabLichDay.Name = "tabLichDay";
            this.tabLichDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichDay.Size = new System.Drawing.Size(1450, 769);
            this.tabLichDay.TabIndex = 5;
            this.tabLichDay.Text = "Lịch Dạy";
            this.tabLichDay.UseVisualStyleBackColor = true;
            // 
            // tabMonHoc
            // 
            this.tabMonHoc.ImageIndex = 2;
            this.tabMonHoc.Location = new System.Drawing.Point(4, 54);
            this.tabMonHoc.Name = "tabMonHoc";
            this.tabMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonHoc.Size = new System.Drawing.Size(1450, 769);
            this.tabMonHoc.TabIndex = 4;
            this.tabMonHoc.Text = "Môn Học";
            this.tabMonHoc.UseVisualStyleBackColor = true;
            // 
            // tabLop
            // 
            this.tabLop.ImageIndex = 4;
            this.tabLop.Location = new System.Drawing.Point(4, 54);
            this.tabLop.Name = "tabLop";
            this.tabLop.Padding = new System.Windows.Forms.Padding(3);
            this.tabLop.Size = new System.Drawing.Size(1450, 769);
            this.tabLop.TabIndex = 3;
            this.tabLop.Text = "Lớp        ";
            this.tabLop.UseVisualStyleBackColor = true;
            // 
            // tabGiaoVien
            // 
            this.tabGiaoVien.ImageIndex = 6;
            this.tabGiaoVien.Location = new System.Drawing.Point(4, 54);
            this.tabGiaoVien.Name = "tabGiaoVien";
            this.tabGiaoVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiaoVien.Size = new System.Drawing.Size(1450, 769);
            this.tabGiaoVien.TabIndex = 2;
            this.tabGiaoVien.Text = "Giáo Viên";
            this.tabGiaoVien.UseVisualStyleBackColor = true;
            // 
            // tabHocSinh
            // 
            this.tabHocSinh.ImageIndex = 5;
            this.tabHocSinh.Location = new System.Drawing.Point(4, 54);
            this.tabHocSinh.Name = "tabHocSinh";
            this.tabHocSinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabHocSinh.Size = new System.Drawing.Size(1450, 769);
            this.tabHocSinh.TabIndex = 1;
            this.tabHocSinh.Text = "Học Sinh";
            this.tabHocSinh.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHome.BackgroundImage")));
            this.tabHome.Controls.Add(this.lblTieuDe);
            this.tabHome.ImageIndex = 0;
            this.tabHome.Location = new System.Drawing.Point(4, 54);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1450, 769);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Trang Chủ";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTieuDe.Location = new System.Drawing.Point(217, 45);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1009, 44);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản lý học sinh giáo viên trường Trung học Phổ Thông";
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabHome);
            this.tabMenu.Controls.Add(this.tabHocSinh);
            this.tabMenu.Controls.Add(this.tabGiaoVien);
            this.tabMenu.Controls.Add(this.tabLop);
            this.tabMenu.Controls.Add(this.tabMonHoc);
            this.tabMenu.Controls.Add(this.tabLichDay);
            this.tabMenu.ImageList = this.imageList1;
            this.tabMenu.ItemSize = new System.Drawing.Size(96, 50);
            this.tabMenu.Location = new System.Drawing.Point(13, 31);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1458, 827);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMenu_Selected);
            this.tabMenu.TabIndexChanged += new System.EventHandler(this.tabMenu_TabIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.liênHệChúngTôiToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem1.Text = "Hướng dẫn sử dụng";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // liênHệChúngTôiToolStripMenuItem
            // 
            this.liênHệChúngTôiToolStripMenuItem.Name = "liênHệChúngTôiToolStripMenuItem";
            this.liênHệChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.liênHệChúngTôiToolStripMenuItem.Text = "Liên hệ chúng tôi";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.thoátToolStripMenuItem.Text = "Phân quyền";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 859);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabLichDay;
        private System.Windows.Forms.TabPage tabMonHoc;
        private System.Windows.Forms.TabPage tabLop;
        private System.Windows.Forms.TabPage tabGiaoVien;
        private System.Windows.Forms.TabPage tabHocSinh;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem liênHệChúngTôiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.Label lblTieuDe;
    }
}

