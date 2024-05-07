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
            this.TuChoiDGV = new System.Windows.Forms.DataGridView();
            this.lbChapNhan = new System.Windows.Forms.Label();
            this.lbTuChoi = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbSoLuongYC = new System.Windows.Forms.Label();
            this.lbSoLuongChapNhan = new System.Windows.Forms.Label();
            this.lbSoLuongTuChoi = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.ViTriCB = new System.Windows.Forms.ComboBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbViTri = new System.Windows.Forms.Label();
            this.lbSLYC = new System.Windows.Forms.Label();
            this.lbSLCN = new System.Windows.Forms.Label();
            this.lbSLTC = new System.Windows.Forms.Label();
            this.ChapNhanDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).BeginInit();
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
            this.MaHSDGV.Location = new System.Drawing.Point(51, 143);
            this.MaHSDGV.Name = "MaHSDGV";
            this.MaHSDGV.RowHeadersWidth = 51;
            this.MaHSDGV.RowTemplate.Height = 24;
            this.MaHSDGV.Size = new System.Drawing.Size(403, 313);
            this.MaHSDGV.TabIndex = 1;
            this.MaHSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaHSDGV_CellContentClick);
            // 
            // lbTenTuyenDung
            // 
            this.lbTenTuyenDung.AutoSize = true;
            this.lbTenTuyenDung.Location = new System.Drawing.Point(51, 79);
            this.lbTenTuyenDung.Name = "lbTenTuyenDung";
            this.lbTenTuyenDung.Size = new System.Drawing.Size(130, 16);
            this.lbTenTuyenDung.TabIndex = 2;
            this.lbTenTuyenDung.Text = "Yêu cầu Tuyển dụng";
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
            this.TuChoiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuChoiDGV_CellContentClick);
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
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(693, 487);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(597, 487);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 12;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // ViTriCB
            // 
            this.ViTriCB.FormattingEnabled = true;
            this.ViTriCB.Location = new System.Drawing.Point(201, 76);
            this.ViTriCB.Name = "ViTriCB";
            this.ViTriCB.Size = new System.Drawing.Size(334, 24);
            this.ViTriCB.TabIndex = 13;
            this.ViTriCB.SelectedIndexChanged += new System.EventHandler(this.ViTriCB_SelectedIndexChanged);
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(759, 79);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(14, 16);
            this.lbSL.TabIndex = 14;
            this.lbSL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vị trí";
            // 
            // lbViTri
            // 
            this.lbViTri.AutoSize = true;
            this.lbViTri.Location = new System.Drawing.Point(100, 109);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(14, 16);
            this.lbViTri.TabIndex = 16;
            this.lbViTri.Text = "0";
            // 
            // lbSLYC
            // 
            this.lbSLYC.AutoSize = true;
            this.lbSLYC.Location = new System.Drawing.Point(440, 440);
            this.lbSLYC.Name = "lbSLYC";
            this.lbSLYC.Size = new System.Drawing.Size(14, 16);
            this.lbSLYC.TabIndex = 17;
            this.lbSLYC.Text = "0";
            // 
            // lbSLCN
            // 
            this.lbSLCN.AutoSize = true;
            this.lbSLCN.Location = new System.Drawing.Point(759, 268);
            this.lbSLCN.Name = "lbSLCN";
            this.lbSLCN.Size = new System.Drawing.Size(14, 16);
            this.lbSLCN.TabIndex = 18;
            this.lbSLCN.Text = "0";
            this.lbSLCN.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSLTC
            // 
            this.lbSLTC.AutoSize = true;
            this.lbSLTC.Location = new System.Drawing.Point(759, 440);
            this.lbSLTC.Name = "lbSLTC";
            this.lbSLTC.Size = new System.Drawing.Size(14, 16);
            this.lbSLTC.TabIndex = 19;
            this.lbSLTC.Text = "0";
            // 
            // ChapNhanDGV
            // 
            this.ChapNhanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChapNhanDGV.Location = new System.Drawing.Point(475, 143);
            this.ChapNhanDGV.Name = "ChapNhanDGV";
            this.ChapNhanDGV.RowHeadersWidth = 51;
            this.ChapNhanDGV.RowTemplate.Height = 24;
            this.ChapNhanDGV.Size = new System.Drawing.Size(298, 140);
            this.ChapNhanDGV.TabIndex = 20;
            this.ChapNhanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChapNhanDGV_CellContentClick);
            // 
            // MhChonNhaTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 522);
            this.Controls.Add(this.lbSLTC);
            this.Controls.Add(this.lbSLCN);
            this.Controls.Add(this.lbSLYC);
            this.Controls.Add(this.lbViTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.ViTriCB);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbSoLuongTuChoi);
            this.Controls.Add(this.lbSoLuongChapNhan);
            this.Controls.Add(this.lbSoLuongYC);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTuChoi);
            this.Controls.Add(this.lbChapNhan);
            this.Controls.Add(this.TuChoiDGV);
            this.Controls.Add(this.lbTenTuyenDung);
            this.Controls.Add(this.MaHSDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChapNhanDGV);
            this.Name = "MhChonNhaTuyenDung";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MhChonNhaTuyenDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MaHSDGV;
        private System.Windows.Forms.Label lbTenTuyenDung;
        private System.Windows.Forms.DataGridView TuChoiDGV;
        private System.Windows.Forms.Label lbChapNhan;
        private System.Windows.Forms.Label lbTuChoi;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbSoLuongYC;
        private System.Windows.Forms.Label lbSoLuongChapNhan;
        private System.Windows.Forms.Label lbSoLuongTuChoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ComboBox ViTriCB;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbViTri;
        private System.Windows.Forms.Label lbSLYC;
        private System.Windows.Forms.Label lbSLCN;
        private System.Windows.Forms.Label lbSLTC;
        private System.Windows.Forms.DataGridView ChapNhanDGV;
    }
}

