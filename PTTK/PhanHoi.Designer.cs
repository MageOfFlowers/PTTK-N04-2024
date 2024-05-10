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
            this.PhanHoiRTB.Location = new System.Drawing.Point(31, 42);
            this.PhanHoiRTB.Name = "PhanHoiRTB";
            this.PhanHoiRTB.Size = new System.Drawing.Size(390, 105);
            this.PhanHoiRTB.TabIndex = 0;
            this.PhanHoiRTB.Text = "";
            // 
            // lbPhanHoi
            // 
            this.lbPhanHoi.AutoSize = true;
            this.lbPhanHoi.Location = new System.Drawing.Point(28, 26);
            this.lbPhanHoi.Name = "lbPhanHoi";
            this.lbPhanHoi.Size = new System.Drawing.Size(65, 13);
            this.lbPhanHoi.TabIndex = 1;
            this.lbPhanHoi.Text = "lbThongBao";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(343, 153);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Xong";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 188);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbPhanHoi);
            this.Controls.Add(this.PhanHoiRTB);
            this.Name = "PhanHoi";
            this.Text = "Form1";
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