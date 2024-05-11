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
            if (avatarImg.FileName == ""||!avatarImg.CheckFileExists||!avatarImg.CheckPathExists)
            {
                MessageBox.Show("Xin hãy chọn ảnh đại diện", "Cảnh báo");
            }
            else
            {
                byte[] img_arr1 = File.ReadAllBytes(avatarImg.FileName);
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
            txtCCCD.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhập căn cước công dân";
            };
            txtDiaChi.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhập địa chỉ";
            };
            txtHoTen.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhập họ tên";
            };
            txtSDT.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhập số điện thoại 10-11 số";
            };

            txtCCCD.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };
            txtDiaChi.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };
            txtHoTen.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };
            txtSDT.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnQuayLai.MouseHover += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để quay lại";
            };
            BtnQuayLai.MouseLeave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnPickAvt.MouseHover += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để chọn ảnh đại diện";
            };
            BtnPickAvt.MouseLeave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnDangKy.MouseHover += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để đăng ký";
            };
            BtnDangKy.MouseLeave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnQuayLai.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để quay lại";
            };
            BtnQuayLai.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnPickAvt.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để chọn ảnh đại diện";
            };
            BtnPickAvt.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };

            BtnDangKy.Enter += (sender, e) =>
            {
                statusDangKy.Text = "Nhấn để đăng ký";
            };
            BtnDangKy.Leave += (sender, e) =>
            {
                statusDangKy.Text = "";
            };
        }

        private void DangKyUngVien_Load(object sender, EventArgs e)
        {

        }
    }
}
