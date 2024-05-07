namespace PTTK
{
    partial class MHXacThucHoSoDaXuLy
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgayNopHoSo = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.BangCapDGV = new System.Windows.Forms.DataGridView();
            this.UngVienPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BangCapDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UngVienPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Ứng viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(215, 93);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(46, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbNgayNopHoSo
            // 
            this.lbNgayNopHoSo.AutoSize = true;
            this.lbNgayNopHoSo.Location = new System.Drawing.Point(526, 93);
            this.lbNgayNopHoSo.Name = "lbNgayNopHoSo";
            this.lbNgayNopHoSo.Size = new System.Drawing.Size(105, 16);
            this.lbNgayNopHoSo.TabIndex = 2;
            this.lbNgayNopHoSo.Text = "Ngày nộp Hồ sơ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(215, 173);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(215, 146);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(66, 16);
            this.lbSDT.TabIndex = 4;
            this.lbSDT.Text = "Điện thoại";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Location = new System.Drawing.Point(215, 118);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(64, 16);
            this.lbCCCD.TabIndex = 5;
            this.lbCCCD.Text = "Số CCCD";
            // 
            // BangCapDGV
            // 
            this.BangCapDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangCapDGV.Location = new System.Drawing.Point(65, 221);
            this.BangCapDGV.Name = "BangCapDGV";
            this.BangCapDGV.RowHeadersWidth = 51;
            this.BangCapDGV.RowTemplate.Height = 24;
            this.BangCapDGV.Size = new System.Drawing.Size(667, 173);
            this.BangCapDGV.TabIndex = 6;
            // 
            // UngVienPB
            // 
            this.UngVienPB.Location = new System.Drawing.Point(80, 71);
            this.UngVienPB.Name = "UngVienPB";
            this.UngVienPB.Size = new System.Drawing.Size(105, 118);
            this.UngVienPB.TabIndex = 7;
            this.UngVienPB.TabStop = false;
            // 
            // MHXacThucHoSoDaXuLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UngVienPB);
            this.Controls.Add(this.BangCapDGV);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbNgayNopHoSo);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label1);
            this.Name = "MHXacThucHoSoDaXuLy";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MHXacThucHoSoDaXuLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangCapDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UngVienPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgayNopHoSo;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.DataGridView BangCapDGV;
        private System.Windows.Forms.PictureBox UngVienPB;
    }
}