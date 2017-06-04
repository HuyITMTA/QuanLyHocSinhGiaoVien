namespace QuanLyHocSinhGiaoVienTHPT
{
    partial class FrmHDSD
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
            this.rbQLHS = new System.Windows.Forms.RadioButton();
            this.rbQLGV = new System.Windows.Forms.RadioButton();
            this.rbQLLop = new System.Windows.Forms.RadioButton();
            this.rbQLMH = new System.Windows.Forms.RadioButton();
            this.rbQLLD = new System.Windows.Forms.RadioButton();
            this.rbPhanQuyen = new System.Windows.Forms.RadioButton();
            this.grbChoose = new System.Windows.Forms.GroupBox();
            this.grbGuide = new System.Windows.Forms.GroupBox();
            this.line16 = new System.Windows.Forms.Label();
            this.line15 = new System.Windows.Forms.Label();
            this.line14 = new System.Windows.Forms.Label();
            this.line13 = new System.Windows.Forms.Label();
            this.line12 = new System.Windows.Forms.Label();
            this.line11 = new System.Windows.Forms.Label();
            this.line10 = new System.Windows.Forms.Label();
            this.line9 = new System.Windows.Forms.Label();
            this.line8 = new System.Windows.Forms.Label();
            this.line7 = new System.Windows.Forms.Label();
            this.line6 = new System.Windows.Forms.Label();
            this.line5 = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChoose.SuspendLayout();
            this.grbGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbQLHS
            // 
            this.rbQLHS.AutoSize = true;
            this.rbQLHS.Location = new System.Drawing.Point(6, 69);
            this.rbQLHS.Name = "rbQLHS";
            this.rbQLHS.Size = new System.Drawing.Size(135, 21);
            this.rbQLHS.TabIndex = 0;
            this.rbQLHS.TabStop = true;
            this.rbQLHS.Text = "Quản lý học sinh";
            this.rbQLHS.UseVisualStyleBackColor = true;
            this.rbQLHS.Click += new System.EventHandler(this.rbQLHS_Click);
            // 
            // rbQLGV
            // 
            this.rbQLGV.AutoSize = true;
            this.rbQLGV.Location = new System.Drawing.Point(6, 124);
            this.rbQLGV.Name = "rbQLGV";
            this.rbQLGV.Size = new System.Drawing.Size(139, 21);
            this.rbQLGV.TabIndex = 1;
            this.rbQLGV.TabStop = true;
            this.rbQLGV.Text = "Quản lý giáo viên";
            this.rbQLGV.UseVisualStyleBackColor = true;
            this.rbQLGV.Click += new System.EventHandler(this.rbQLGV_Click);
            // 
            // rbQLLop
            // 
            this.rbQLLop.AutoSize = true;
            this.rbQLLop.Location = new System.Drawing.Point(6, 183);
            this.rbQLLop.Name = "rbQLLop";
            this.rbQLLop.Size = new System.Drawing.Size(101, 21);
            this.rbQLLop.TabIndex = 2;
            this.rbQLLop.TabStop = true;
            this.rbQLLop.Text = "Quản lý lớp";
            this.rbQLLop.UseVisualStyleBackColor = true;
            this.rbQLLop.Click += new System.EventHandler(this.rbQLLop_Click);
            // 
            // rbQLMH
            // 
            this.rbQLMH.AutoSize = true;
            this.rbQLMH.Location = new System.Drawing.Point(6, 237);
            this.rbQLMH.Name = "rbQLMH";
            this.rbQLMH.Size = new System.Drawing.Size(136, 21);
            this.rbQLMH.TabIndex = 3;
            this.rbQLMH.TabStop = true;
            this.rbQLMH.Text = "Quản lý môn học";
            this.rbQLMH.UseVisualStyleBackColor = true;
            this.rbQLMH.Click += new System.EventHandler(this.rbQLMH_Click);
            // 
            // rbQLLD
            // 
            this.rbQLLD.AutoSize = true;
            this.rbQLLD.Location = new System.Drawing.Point(6, 297);
            this.rbQLLD.Name = "rbQLLD";
            this.rbQLLD.Size = new System.Drawing.Size(130, 21);
            this.rbQLLD.TabIndex = 4;
            this.rbQLLD.TabStop = true;
            this.rbQLLD.Text = "Quản lý lịch dạy";
            this.rbQLLD.UseVisualStyleBackColor = true;
            this.rbQLLD.Click += new System.EventHandler(this.rbQLLD_Click);
            // 
            // rbPhanQuyen
            // 
            this.rbPhanQuyen.AutoSize = true;
            this.rbPhanQuyen.Location = new System.Drawing.Point(6, 359);
            this.rbPhanQuyen.Name = "rbPhanQuyen";
            this.rbPhanQuyen.Size = new System.Drawing.Size(190, 21);
            this.rbPhanQuyen.TabIndex = 5;
            this.rbPhanQuyen.TabStop = true;
            this.rbPhanQuyen.Text = "Tài khoản và phân quyền";
            this.rbPhanQuyen.UseVisualStyleBackColor = true;
            // 
            // grbChoose
            // 
            this.grbChoose.Controls.Add(this.rbQLLop);
            this.grbChoose.Controls.Add(this.rbPhanQuyen);
            this.grbChoose.Controls.Add(this.rbQLHS);
            this.grbChoose.Controls.Add(this.rbQLLD);
            this.grbChoose.Controls.Add(this.rbQLGV);
            this.grbChoose.Controls.Add(this.rbQLMH);
            this.grbChoose.Location = new System.Drawing.Point(27, 73);
            this.grbChoose.Name = "grbChoose";
            this.grbChoose.Size = new System.Drawing.Size(209, 474);
            this.grbChoose.TabIndex = 6;
            this.grbChoose.TabStop = false;
            this.grbChoose.Text = "Lựa chọn";
            // 
            // grbGuide
            // 
            this.grbGuide.Controls.Add(this.line16);
            this.grbGuide.Controls.Add(this.line15);
            this.grbGuide.Controls.Add(this.line14);
            this.grbGuide.Controls.Add(this.line13);
            this.grbGuide.Controls.Add(this.line12);
            this.grbGuide.Controls.Add(this.line11);
            this.grbGuide.Controls.Add(this.line10);
            this.grbGuide.Controls.Add(this.line9);
            this.grbGuide.Controls.Add(this.line8);
            this.grbGuide.Controls.Add(this.line7);
            this.grbGuide.Controls.Add(this.line6);
            this.grbGuide.Controls.Add(this.line5);
            this.grbGuide.Controls.Add(this.line4);
            this.grbGuide.Controls.Add(this.line3);
            this.grbGuide.Controls.Add(this.line2);
            this.grbGuide.Controls.Add(this.line1);
            this.grbGuide.Location = new System.Drawing.Point(284, 73);
            this.grbGuide.Name = "grbGuide";
            this.grbGuide.Size = new System.Drawing.Size(1013, 474);
            this.grbGuide.TabIndex = 7;
            this.grbGuide.TabStop = false;
            this.grbGuide.Text = "Hướng dẫn";
            // 
            // line16
            // 
            this.line16.AutoSize = true;
            this.line16.Location = new System.Drawing.Point(30, 433);
            this.line16.Name = "line16";
            this.line16.Size = new System.Drawing.Size(54, 17);
            this.line16.TabIndex = 15;
            this.line16.Text = "label17";
            // 
            // line15
            // 
            this.line15.AutoSize = true;
            this.line15.Location = new System.Drawing.Point(30, 407);
            this.line15.Name = "line15";
            this.line15.Size = new System.Drawing.Size(54, 17);
            this.line15.TabIndex = 14;
            this.line15.Text = "label16";
            // 
            // line14
            // 
            this.line14.AutoSize = true;
            this.line14.Location = new System.Drawing.Point(30, 381);
            this.line14.Name = "line14";
            this.line14.Size = new System.Drawing.Size(54, 17);
            this.line14.TabIndex = 13;
            this.line14.Text = "label15";
            // 
            // line13
            // 
            this.line13.AutoSize = true;
            this.line13.Location = new System.Drawing.Point(30, 355);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(54, 17);
            this.line13.TabIndex = 12;
            this.line13.Text = "label14";
            // 
            // line12
            // 
            this.line12.AutoSize = true;
            this.line12.Location = new System.Drawing.Point(30, 325);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(54, 17);
            this.line12.TabIndex = 11;
            this.line12.Text = "label13";
            // 
            // line11
            // 
            this.line11.AutoSize = true;
            this.line11.Location = new System.Drawing.Point(30, 297);
            this.line11.Name = "line11";
            this.line11.Size = new System.Drawing.Size(54, 17);
            this.line11.TabIndex = 10;
            this.line11.Text = "label12";
            // 
            // line10
            // 
            this.line10.AutoSize = true;
            this.line10.Location = new System.Drawing.Point(30, 271);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(54, 17);
            this.line10.TabIndex = 9;
            this.line10.Text = "label11";
            // 
            // line9
            // 
            this.line9.AutoSize = true;
            this.line9.Location = new System.Drawing.Point(30, 241);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(54, 17);
            this.line9.TabIndex = 8;
            this.line9.Text = "label10";
            // 
            // line8
            // 
            this.line8.AutoSize = true;
            this.line8.Location = new System.Drawing.Point(30, 214);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(46, 17);
            this.line8.TabIndex = 7;
            this.line8.Text = "label9";
            // 
            // line7
            // 
            this.line7.AutoSize = true;
            this.line7.Location = new System.Drawing.Point(30, 185);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(46, 17);
            this.line7.TabIndex = 6;
            this.line7.Text = "label8";
            // 
            // line6
            // 
            this.line6.AutoSize = true;
            this.line6.Location = new System.Drawing.Point(30, 156);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(46, 17);
            this.line6.TabIndex = 5;
            this.line6.Text = "label7";
            // 
            // line5
            // 
            this.line5.AutoSize = true;
            this.line5.Location = new System.Drawing.Point(30, 128);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(46, 17);
            this.line5.TabIndex = 4;
            this.line5.Text = "label6";
            // 
            // line4
            // 
            this.line4.AutoSize = true;
            this.line4.Location = new System.Drawing.Point(30, 102);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(46, 17);
            this.line4.TabIndex = 3;
            this.line4.Text = "label5";
            // 
            // line3
            // 
            this.line3.AutoSize = true;
            this.line3.Location = new System.Drawing.Point(30, 73);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(46, 17);
            this.line3.TabIndex = 2;
            this.line3.Text = "label4";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(30, 45);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(46, 17);
            this.line2.TabIndex = 1;
            this.line2.Text = "label3";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(30, 18);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(46, 17);
            this.line1.TabIndex = 0;
            this.line1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hướng dẫn sử dụng phần mềm";
            // 
            // FrmHDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbGuide);
            this.Controls.Add(this.grbChoose);
            this.Name = "FrmHDSD";
            this.Text = "HDSD";
            this.grbChoose.ResumeLayout(false);
            this.grbChoose.PerformLayout();
            this.grbGuide.ResumeLayout(false);
            this.grbGuide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbQLHS;
        private System.Windows.Forms.RadioButton rbQLGV;
        private System.Windows.Forms.RadioButton rbQLLop;
        private System.Windows.Forms.RadioButton rbQLMH;
        private System.Windows.Forms.RadioButton rbQLLD;
        private System.Windows.Forms.RadioButton rbPhanQuyen;
        private System.Windows.Forms.GroupBox grbChoose;
        private System.Windows.Forms.GroupBox grbGuide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line11;
        private System.Windows.Forms.Label line10;
        private System.Windows.Forms.Label line9;
        private System.Windows.Forms.Label line8;
        private System.Windows.Forms.Label line7;
        private System.Windows.Forms.Label line6;
        private System.Windows.Forms.Label line5;
        private System.Windows.Forms.Label line4;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line16;
        private System.Windows.Forms.Label line15;
        private System.Windows.Forms.Label line14;
        private System.Windows.Forms.Label line13;
        private System.Windows.Forms.Label line12;
    }
}