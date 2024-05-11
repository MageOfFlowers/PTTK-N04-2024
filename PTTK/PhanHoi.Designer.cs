namespace PTTK
{
    partial class PhanHoi
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
            this.PhanHoiRTB = new System.Windows.Forms.RichTextBox();
            this.lbPhanHoi = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhanHoiRTB
            // 
            this.PhanHoiRTB.Location = new System.Drawing.Point(41, 52);
            this.PhanHoiRTB.Margin = new System.Windows.Forms.Padding(4);
            this.PhanHoiRTB.Name = "PhanHoiRTB";
            this.PhanHoiRTB.Size = new System.Drawing.Size(519, 128);
            this.PhanHoiRTB.TabIndex = 0;
            this.PhanHoiRTB.Text = "";
            // 
            // lbPhanHoi
            // 
            this.lbPhanHoi.AutoSize = true;
            this.lbPhanHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPhanHoi.Location = new System.Drawing.Point(37, 28);
            this.lbPhanHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhanHoi.Name = "lbPhanHoi";
            this.lbPhanHoi.Size = new System.Drawing.Size(108, 20);
            this.lbPhanHoi.TabIndex = 1;
            this.lbPhanHoi.Text = "lbThongBao";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(457, 188);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Xong";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 231);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbPhanHoi);
            this.Controls.Add(this.PhanHoiRTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhanHoi";
            this.Text = "Phản hồi";
            this.Load += new System.EventHandler(this.PhanHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PhanHoiRTB;
        private System.Windows.Forms.Label lbPhanHoi;
        private System.Windows.Forms.Button btnLuu;
    }
}