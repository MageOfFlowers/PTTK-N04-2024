namespace PTTK
{
    partial class DangKyUngVien
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avatarImg = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.BtnPickAvt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ssDangKy = new System.Windows.Forms.StatusStrip();
            this.statusDangKy = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.ssDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(204, 413);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(157, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(204, 360);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(157, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(204, 303);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(157, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(204, 250);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(157, 20);
            this.txtCCCD.TabIndex = 2;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnQuayLai.Location = new System.Drawing.Point(105, 469);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.BtnQuayLai.TabIndex = 6;
            this.BtnQuayLai.Text = "Quay lại";
            this.BtnQuayLai.UseVisualStyleBackColor = true;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.Location = new System.Drawing.Point(256, 469);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(75, 23);
            this.BtnDangKy.TabIndex = 7;
            this.BtnDangKy.Text = "Đăng ký";
            this.BtnDangKy.UseVisualStyleBackColor = true;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng ký ứng viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ảnh đại diện";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Location = new System.Drawing.Point(234, 102);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(97, 118);
            this.pbAvatar.TabIndex = 23;
            this.pbAvatar.TabStop = false;
            // 
            // BtnPickAvt
            // 
            this.BtnPickAvt.Location = new System.Drawing.Point(370, 147);
            this.BtnPickAvt.Name = "BtnPickAvt";
            this.BtnPickAvt.Size = new System.Drawing.Size(75, 23);
            this.BtnPickAvt.TabIndex = 1;
            this.BtnPickAvt.Text = "Chọn ảnh";
            this.BtnPickAvt.UseVisualStyleBackColor = true;
            this.BtnPickAvt.Click += new System.EventHandler(this.BtnPickAvt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(105, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Xin hãy điền đầy đủ thông tin để đăng ký";
            // 
            // ssDangKy
            // 
            this.ssDangKy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDangKy});
            this.ssDangKy.Location = new System.Drawing.Point(0, 516);
            this.ssDangKy.Name = "ssDangKy";
            this.ssDangKy.Size = new System.Drawing.Size(478, 22);
            this.ssDangKy.TabIndex = 26;
            this.ssDangKy.Text = "statusStrip1";
            // 
            // statusDangKy
            // 
            this.statusDangKy.Name = "statusDangKy";
            this.statusDangKy.Size = new System.Drawing.Size(0, 17);
            // 
            // DangKyUngVien
            // 
            this.AcceptButton = this.BtnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnQuayLai;
            this.ClientSize = new System.Drawing.Size(478, 538);
            this.Controls.Add(this.ssDangKy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnPickAvt);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.BtnQuayLai);
            this.Controls.Add(this.BtnDangKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKyUngVien";
            this.Text = "Đăng ký ứng viên";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ssDangKy.ResumeLayout(false);
            this.ssDangKy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button BtnQuayLai;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog avatarImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button BtnPickAvt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip ssDangKy;
        private System.Windows.Forms.ToolStripStatusLabel statusDangKy;
    }
}