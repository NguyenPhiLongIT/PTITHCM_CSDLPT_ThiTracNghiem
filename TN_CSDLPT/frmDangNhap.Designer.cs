namespace TN_CSDLPT
{
    partial class frmDangNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.edtMatKhau = new System.Windows.Forms.TextBox();
            this.edtTenDangNhap = new System.Windows.Forms.TextBox();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbGiangVien = new System.Windows.Forms.RadioButton();
            this.rbSinhVien = new System.Windows.Forms.RadioButton();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(464, 343);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(71, 22);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(254, 343);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(91, 22);
            this.btnDangNhap.TabIndex = 26;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // edtMatKhau
            // 
            this.edtMatKhau.Location = new System.Drawing.Point(266, 297);
            this.edtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.edtMatKhau.Name = "edtMatKhau";
            this.edtMatKhau.Size = new System.Drawing.Size(279, 20);
            this.edtMatKhau.TabIndex = 25;
            // 
            // edtTenDangNhap
            // 
            this.edtTenDangNhap.Location = new System.Drawing.Point(266, 255);
            this.edtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.edtTenDangNhap.Name = "edtTenDangNhap";
            this.edtTenDangNhap.Size = new System.Drawing.Size(279, 20);
            this.edtTenDangNhap.TabIndex = 24;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(266, 208);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(279, 21);
            this.cmbCoSo.TabIndex = 23;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(288, 85);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(195, 30);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "THI TRẮC NGHIỆM";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(161, 297);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Mật Khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(161, 255);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Tên Đăng Nhập";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(161, 208);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Cơ Sở";
            // 
            // rbGiangVien
            // 
            this.rbGiangVien.AutoSize = true;
            this.rbGiangVien.Location = new System.Drawing.Point(15, 21);
            this.rbGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.rbGiangVien.Name = "rbGiangVien";
            this.rbGiangVien.Size = new System.Drawing.Size(77, 17);
            this.rbGiangVien.TabIndex = 15;
            this.rbGiangVien.Text = "Giảng Viên";
            this.rbGiangVien.UseVisualStyleBackColor = true;
            // 
            // rbSinhVien
            // 
            this.rbSinhVien.AutoSize = true;
            this.rbSinhVien.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbSinhVien.Checked = true;
            this.rbSinhVien.Location = new System.Drawing.Point(129, 21);
            this.rbSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.rbSinhVien.Name = "rbSinhVien";
            this.rbSinhVien.Size = new System.Drawing.Size(70, 17);
            this.rbSinhVien.TabIndex = 14;
            this.rbSinhVien.TabStop = true;
            this.rbSinhVien.Text = "Sinh Viên";
            this.rbSinhVien.UseVisualStyleBackColor = true;
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(572, 298);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(2);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(67, 17);
            this.cbHienMK.TabIndex = 29;
            this.cbHienMK.Text = "Hiện MK";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGiangVien);
            this.groupBox1.Controls.Add(this.rbSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(266, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 49);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỨC VỤ";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 436);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.edtMatKhau);
            this.Controls.Add(this.edtTenDangNhap);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox edtMatKhau;
        private System.Windows.Forms.TextBox edtTenDangNhap;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.RadioButton rbGiangVien;
        public System.Windows.Forms.RadioButton rbSinhVien;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}