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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(552, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Ứng viên";
            // 
            // MaHSDGV
            // 
            this.MaHSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaHSDGV.Location = new System.Drawing.Point(40, 170);
            this.MaHSDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaHSDGV.Name = "MaHSDGV";
            this.MaHSDGV.RowHeadersWidth = 51;
            this.MaHSDGV.RowTemplate.Height = 24;
            this.MaHSDGV.Size = new System.Drawing.Size(663, 486);
            this.MaHSDGV.TabIndex = 1;
            this.MaHSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaHSDGV_CellContentClick);
            // 
            // lbTenTuyenDung
            // 
            this.lbTenTuyenDung.AutoSize = true;
            this.lbTenTuyenDung.BackColor = System.Drawing.Color.Cyan;
            this.lbTenTuyenDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTenTuyenDung.Location = new System.Drawing.Point(40, 106);
            this.lbTenTuyenDung.Name = "lbTenTuyenDung";
            this.lbTenTuyenDung.Size = new System.Drawing.Size(148, 16);
            this.lbTenTuyenDung.TabIndex = 2;
            this.lbTenTuyenDung.Text = "Yêu cầu Tuyển dụng";
            // 
            // TuChoiDGV
            // 
            this.TuChoiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuChoiDGV.Location = new System.Drawing.Point(725, 443);
            this.TuChoiDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuChoiDGV.Name = "TuChoiDGV";
            this.TuChoiDGV.RowHeadersWidth = 51;
            this.TuChoiDGV.RowTemplate.Height = 24;
            this.TuChoiDGV.Size = new System.Drawing.Size(571, 213);
            this.TuChoiDGV.TabIndex = 4;
            this.TuChoiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuChoiDGV_CellContentClick);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSoLuong.Location = new System.Drawing.Point(1137, 30);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(109, 16);
            this.lbSoLuong.TabIndex = 7;
            this.lbSoLuong.Text = "Số lượng tuyển";
            // 
            // lbSoLuongYC
            // 
            this.lbSoLuongYC.AutoSize = true;
            this.lbSoLuongYC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSoLuongYC.Location = new System.Drawing.Point(614, 630);
            this.lbSoLuongYC.Name = "lbSoLuongYC";
            this.lbSoLuongYC.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuongYC.TabIndex = 8;
            this.lbSoLuongYC.Text = "Số lượng";
            // 
            // lbSoLuongChapNhan
            // 
            this.lbSoLuongChapNhan.AutoSize = true;
            this.lbSoLuongChapNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSoLuongChapNhan.Location = new System.Drawing.Point(1209, 386);
            this.lbSoLuongChapNhan.Name = "lbSoLuongChapNhan";
            this.lbSoLuongChapNhan.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuongChapNhan.TabIndex = 9;
            this.lbSoLuongChapNhan.Text = "Số lượng";
            // 
            // lbSoLuongTuChoi
            // 
            this.lbSoLuongTuChoi.AutoSize = true;
            this.lbSoLuongTuChoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSoLuongTuChoi.Location = new System.Drawing.Point(1209, 631);
            this.lbSoLuongTuChoi.Name = "lbSoLuongTuChoi";
            this.lbSoLuongTuChoi.Size = new System.Drawing.Size(60, 16);
            this.lbSoLuongTuChoi.TabIndex = 10;
            this.lbSoLuongTuChoi.Text = "Số lượng";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(1151, 698);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 56);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Navy;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuayLai.Location = new System.Drawing.Point(975, 698);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 56);
            this.btnQuayLai.TabIndex = 12;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ViTriCB
            // 
            this.ViTriCB.FormattingEnabled = true;
            this.ViTriCB.Location = new System.Drawing.Point(196, 20);
            this.ViTriCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViTriCB.Name = "ViTriCB";
            this.ViTriCB.Size = new System.Drawing.Size(335, 24);
            this.ViTriCB.TabIndex = 13;
            this.ViTriCB.SelectedIndexChanged += new System.EventHandler(this.ViTriCB_SelectedIndexChanged);
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSL.Location = new System.Drawing.Point(1267, 30);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(14, 16);
            this.lbSL.TabIndex = 14;
            this.lbSL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(603, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vị trí";
            // 
            // lbViTri
            // 
            this.lbViTri.AutoSize = true;
            this.lbViTri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbViTri.Location = new System.Drawing.Point(662, 107);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(14, 16);
            this.lbViTri.TabIndex = 16;
            this.lbViTri.Text = "0";
            // 
            // lbSLYC
            // 
            this.lbSLYC.AutoSize = true;
            this.lbSLYC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSLYC.Location = new System.Drawing.Point(684, 630);
            this.lbSLYC.Name = "lbSLYC";
            this.lbSLYC.Size = new System.Drawing.Size(14, 16);
            this.lbSLYC.TabIndex = 17;
            this.lbSLYC.Text = "0";
            // 
            // lbSLCN
            // 
            this.lbSLCN.AutoSize = true;
            this.lbSLCN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSLCN.Location = new System.Drawing.Point(1278, 386);
            this.lbSLCN.Name = "lbSLCN";
            this.lbSLCN.Size = new System.Drawing.Size(14, 16);
            this.lbSLCN.TabIndex = 18;
            this.lbSLCN.Text = "0";
            this.lbSLCN.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSLTC
            // 
            this.lbSLTC.AutoSize = true;
            this.lbSLTC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSLTC.Location = new System.Drawing.Point(1278, 631);
            this.lbSLTC.Name = "lbSLTC";
            this.lbSLTC.Size = new System.Drawing.Size(14, 16);
            this.lbSLTC.TabIndex = 19;
            this.lbSLTC.Text = "0";
            // 
            // ChapNhanDGV
            // 
            this.ChapNhanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChapNhanDGV.Location = new System.Drawing.Point(725, 170);
            this.ChapNhanDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChapNhanDGV.Name = "ChapNhanDGV";
            this.ChapNhanDGV.RowHeadersWidth = 51;
            this.ChapNhanDGV.RowTemplate.Height = 24;
            this.ChapNhanDGV.Size = new System.Drawing.Size(571, 245);
            this.ChapNhanDGV.TabIndex = 20;
            this.ChapNhanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChapNhanDGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh sách ứng viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ViTriCB);
            this.panel1.Controls.Add(this.lbSL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Location = new System.Drawing.Point(11, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 597);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(710, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ứng viên được chấp nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(710, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ứng viên bị từ chối";
            // 
            // MhChonNhaTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1348, 765);
            this.Controls.Add(this.lbSoLuongChapNhan);
            this.Controls.Add(this.lbSLTC);
            this.Controls.Add(this.lbSLCN);
            this.Controls.Add(this.lbSLYC);
            this.Controls.Add(this.lbViTri);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbSoLuongTuChoi);
            this.Controls.Add(this.lbSoLuongYC);
            this.Controls.Add(this.TuChoiDGV);
            this.Controls.Add(this.lbTenTuyenDung);
            this.Controls.Add(this.MaHSDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChapNhanDGV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MhChonNhaTuyenDung";
            this.Text = "Chọn nhà tuyển dụng";
            this.Load += new System.EventHandler(this.MhChonNhaTuyenDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaHSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuChoiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChapNhanDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MaHSDGV;
        private System.Windows.Forms.Label lbTenTuyenDung;
        private System.Windows.Forms.DataGridView TuChoiDGV;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

