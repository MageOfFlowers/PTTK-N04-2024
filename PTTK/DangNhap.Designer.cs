namespace PTTK
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.TaiKhoanTB = new System.Windows.Forms.TextBox();
            this.MatKhauTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DangNhapbtn = new System.Windows.Forms.Button();
            this.DangKybtn = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(209, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PTTK N04";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaiKhoanTB
            // 
            this.TaiKhoanTB.Location = new System.Drawing.Point(164, 141);
            this.TaiKhoanTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaiKhoanTB.Name = "TaiKhoanTB";
            this.TaiKhoanTB.Size = new System.Drawing.Size(224, 22);
            this.TaiKhoanTB.TabIndex = 1;
            // 
            // MatKhauTB
            // 
            this.MatKhauTB.Location = new System.Drawing.Point(165, 206);
            this.MatKhauTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatKhauTB.Name = "MatKhauTB";
            this.MatKhauTB.PasswordChar = '*';
            this.MatKhauTB.Size = new System.Drawing.Size(224, 22);
            this.MatKhauTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mât khẩu";
            // 
            // DangNhapbtn
            // 
            this.DangNhapbtn.BackColor = System.Drawing.Color.Navy;
            this.DangNhapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DangNhapbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DangNhapbtn.Location = new System.Drawing.Point(164, 254);
            this.DangNhapbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DangNhapbtn.Name = "DangNhapbtn";
            this.DangNhapbtn.Size = new System.Drawing.Size(221, 31);
            this.DangNhapbtn.TabIndex = 5;
            this.DangNhapbtn.Text = "Đăng nhập";
            this.DangNhapbtn.UseVisualStyleBackColor = false;
            this.DangNhapbtn.Click += new System.EventHandler(this.DangNhapbtn_Click);
            // 
            // DangKybtn
            // 
            this.DangKybtn.BackColor = System.Drawing.Color.Navy;
            this.DangKybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DangKybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DangKybtn.Location = new System.Drawing.Point(163, 360);
            this.DangKybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DangKybtn.Name = "DangKybtn";
            this.DangKybtn.Size = new System.Drawing.Size(224, 31);
            this.DangKybtn.TabIndex = 6;
            this.DangKybtn.Text = "Đăng kí ứng viên";
            this.DangKybtn.UseVisualStyleBackColor = false;
            this.DangKybtn.Click += new System.EventHandler(this.DangKybtn_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Navy;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangKy.Location = new System.Drawing.Point(163, 308);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(224, 31);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký doanh nghiệp";
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 413);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(232, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đăng nhập";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 433);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.DangKybtn);
            this.Controls.Add(this.DangNhapbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatKhauTB);
            this.Controls.Add(this.TaiKhoanTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaiKhoanTB;
        private System.Windows.Forms.TextBox MatKhauTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DangNhapbtn;
        private System.Windows.Forms.Button DangKybtn;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}