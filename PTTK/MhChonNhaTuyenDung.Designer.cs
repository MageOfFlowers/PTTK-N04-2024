namespace PTTK
{
    partial class MhChonNhaTuyenDung
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
            this.MaHSDGV = new System.Windows.Forms.DataGridView();
            this.lbTenTuyenDung = new System.Windows.Forms.Label();
            this.ChapNhanDGV = new System.Windows.Forms.DataGridView();
            this.TuChoiDGV = new System.Windows.Forms.DataGridView();
            this.lbChapNhan = new System.Windows.Forms.Label();
            this.lbTuChoi = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbSoLuongYC = new System.Windows.Forms.Label();
            this.lbSoLuongChapNhan = new System.Windows.Forms.Label();
            this.lbSoLuongTuChoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Ứng viên";
            // 
            // MaHSDGV
            // 
            this.MaHSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaHSDGV.Location = new System.Drawing.Point(51, 118);
            this.MaHSDGV.Name = "MaHSDGV";
            this.MaHSDGV.RowHeadersWidth = 51;
            this.MaHSDGV.RowTemplate.Height = 24;
            this.MaHSDGV.Size = new System.Drawing.Size(403, 338);
            this.MaHSDGV.TabIndex = 1;
            // 
            // lbTenTuyenDung
            // 
            this.lbTenTuyenDung.AutoSize = true;
            this.lbTenTuyenDung.Location = new System.Drawing.Point(51, 79);
            this.lbTenTuyenDung.Name = "lbTenTuyenDung";
            this.lbTenTuyenDung.Size = new System.Drawing.Size(157, 16);
            this.lbTenTuyenDung.TabIndex = 2;
            this.lbTenTuyenDung.Text = "Tên Yêu cầu Tuyển dụng";
            // 
            // ChapNhanDGV
            // 
            this.ChapNhanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChapNhanDGV.Location = new System.Drawing.Point(475, 143);
            this.ChapNhanDGV.Name = "ChapNhanDGV";
            this.ChapNhanDGV.RowHeadersWidth = 51;
            this.ChapNhanDGV.RowTemplate.Height = 24;
            this.ChapNhanDGV.Size = new System.Drawing.Size(298, 141);
            this.ChapNhanDGV.TabIndex = 3;
            this.ChapNhanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // TuChoiDGV
            // 
            this.TuChoiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuChoiDGV.Location = new System.Drawing.Point(475, 316);
            this.TuChoiDGV.Name = "TuChoiDGV";
            this.TuChoiDGV.RowHeadersWidth = 51;
            this.TuChoiDGV.RowTemplate.Height = 24;
            this.TuChoiDGV.Size = new System.Drawing.Size(298, 140);
            this.TuChoiDGV.TabIndex = 4;
            // 
            // lbChapNhan
            // 
            this.lbChapNhan.AutoSize = true;
            this.lbChapNhan.Location = new System.Drawing.Point(469, 118);
            this.lbChapNhan.Name = "lbChapNhan";
            this.lbChapNhan.Size = new System.Drawing.Size(158, 16);
            this.lbChapNhan.TabIndex = 5;
            this.lbChapNhan.Text = "Ứng viên được chấp nhận";
            // 
            // lbTuChoi
            // 
            this.lbTuChoi.AutoSize = true;
            this.lbTuChoi.Location = new System.Drawing.Point(472, 297);
            this.lbTuChoi.Name = "lbTuChoi";
            this.lbTuChoi.Size = new System.Drawing.Size(115, 16);
            this.lbTuChoi.TabIndex = 6;
            this.lbTuChoi.Text = "Ứng viên bị từ chối";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(630, 79);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(95, 16);
            this.lbSoLuong.TabIndex = 7;
            this.lbSoLuong.Text = "Số lượng tuyển";
            // 
            // lbSoLuongYC
            // 
            this.lbSoLuongYC.AutoSize = true;
            this.lbSoLuongYC.Location = new System.Drawing.Point(316, 440);
            this.lbSoLuongYC.Name = "lbSoLuongYC";
            this.lbSoLuongYC.Size = new System.Drawing.Size(110, 16);
            this.lbSoLuongYC.TabIndex = 8;
            this.lbSoLuongYC.Text = "Số lượng yêu cầu";
            // 
            // lbSoLuongChapNhan
            // 
            this.lbSoLuongChapNhan.AutoSize = true;
            this.lbSoLuongChapNhan.Location = new System.Drawing.Point(690, 268);
            this.lbSoLuongChapNhan.Name = "lbSoLuongChapNhan";
            this.lbSoLuongChapNhan.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuongChapNhan.TabIndex = 9;
            this.lbSoLuongChapNhan.Text = "Số lượng";
            // 
            // lbSoLuongTuChoi
            // 
            this.lbSoLuongTuChoi.AutoSize = true;
            this.lbSoLuongTuChoi.Location = new System.Drawing.Point(690, 440);
            this.lbSoLuongTuChoi.Name = "lbSoLuongTuChoi";
            this.lbSoLuongTuChoi.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuongTuChoi.TabIndex = 10;
            this.lbSoLuongTuChoi.Text = "Số lượng";
            // 
            // MhChonNhaTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 504);
            this.Controls.Add(this.lbSoLuongTuChoi);
            this.Controls.Add(this.lbSoLuongChapNhan);
            this.Controls.Add(this.lbSoLuongYC);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTuChoi);
            this.Controls.Add(this.lbChapNhan);
            this.Controls.Add(this.TuChoiDGV);
            this.Controls.Add(this.ChapNhanDGV);
            this.Controls.Add(this.lbTenTuyenDung);
            this.Controls.Add(this.MaHSDGV);
            this.Controls.Add(this.label1);
            this.Name = "MhChonNhaTuyenDung";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MaHSDGV;
        private System.Windows.Forms.Label lbTenTuyenDung;
        private System.Windows.Forms.DataGridView ChapNhanDGV;
        private System.Windows.Forms.DataGridView TuChoiDGV;
        private System.Windows.Forms.Label lbChapNhan;
        private System.Windows.Forms.Label lbTuChoi;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbSoLuongYC;
        private System.Windows.Forms.Label lbSoLuongChapNhan;
        private System.Windows.Forms.Label lbSoLuongTuChoi;
    }
}

