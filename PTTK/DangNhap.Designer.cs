﻿namespace PTTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.TaiKhoanTB = new System.Windows.Forms.TextBox();
            this.MatKhauTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DangNhapbtn = new System.Windows.Forms.Button();
            this.DangKybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PTTK N04";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaiKhoanTB
            // 
            this.TaiKhoanTB.Location = new System.Drawing.Point(73, 151);
            this.TaiKhoanTB.Name = "TaiKhoanTB";
            this.TaiKhoanTB.Size = new System.Drawing.Size(224, 22);
            this.TaiKhoanTB.TabIndex = 1;
            // 
            // MatKhauTB
            // 
            this.MatKhauTB.Location = new System.Drawing.Point(73, 214);
            this.MatKhauTB.Name = "MatKhauTB";
            this.MatKhauTB.Size = new System.Drawing.Size(224, 22);
            this.MatKhauTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mât khẩu";
            // 
            // DangNhapbtn
            // 
            this.DangNhapbtn.Location = new System.Drawing.Point(195, 289);
            this.DangNhapbtn.Name = "DangNhapbtn";
            this.DangNhapbtn.Size = new System.Drawing.Size(102, 31);
            this.DangNhapbtn.TabIndex = 5;
            this.DangNhapbtn.Text = "Đăng nhập";
            this.DangNhapbtn.UseVisualStyleBackColor = true;
            this.DangNhapbtn.Click += new System.EventHandler(this.DangNhapbtn_Click);
            // 
            // DangKybtn
            // 
            this.DangKybtn.Location = new System.Drawing.Point(73, 289);
            this.DangKybtn.Name = "DangKybtn";
            this.DangKybtn.Size = new System.Drawing.Size(102, 31);
            this.DangKybtn.TabIndex = 6;
            this.DangKybtn.Text = "Đăng kí";
            this.DangKybtn.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 383);
            this.Controls.Add(this.DangKybtn);
            this.Controls.Add(this.DangNhapbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatKhauTB);
            this.Controls.Add(this.TaiKhoanTB);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DangNhap_Load);
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
    }
}