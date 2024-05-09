using PTTK.BUS;
using PTTK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTTK
{
    public partial class DangKyUngVien : Form
    {
        public DangKyUngVien()
        {
            InitializeComponent();
            HienThi();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            byte[] img_arr1=null;
            if (avatarImg.FileName == ""||!avatarImg.CheckFileExists||!avatarImg.CheckPathExists)
            {
                MessageBox.Show("Xin hãy chọn ảnh đại diện", "Cảnh báo");
            }
            else
            {
                img_arr1 = File.ReadAllBytes(avatarImg.FileName);
                UngVien ungVien = new UngVien()
                {
                    Anh = img_arr1,
                    CCCD = txtCCCD.Text,
                    HoTen = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtDiaChi.Text
                };
                if (ungVien.CCCD.Trim().Length == 0 || ungVien.HoTen.Trim().Length == 0 || ungVien.DiaChi.Trim().Length == 0 || ungVien.SDT.Trim().Length == 0)
                {
                    MessageBox.Show("Xin hãy điền đầy đủ thông tin", "Cảnh báo");
                }
                else if (ungVien.KiemTraTonTai(ungVien.CCCD))
                {
                    MessageBox.Show("Thông tin này đã tồn tại", "Cảnh báo");
                }
                else if(!Regex.Match(ungVien.SDT.Trim(), @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$").Success)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh báo");
                }
                else
                {
                    ungVien.DangKyUngVien(ungVien);
                    Close();
                }
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quay lại màn hình chính?", "Nhắn nhở", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnPickAvt_Click(object sender, EventArgs e)
        {
            if (avatarImg.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = new Bitmap(avatarImg.FileName);
                pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void HienThi()
        {
            avatarImg = new OpenFileDialog
            {
                Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                Multiselect = false,
                Title = "Chọn ảnh đại diện",
                CheckPathExists = true,
                CheckFileExists = true,
            };
        }
    }
}
