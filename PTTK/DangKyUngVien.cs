using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class DangKyUngVien : Form
    {
        public DangKyUngVien()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            UngVien ungVien = new UngVien() { 
                CCCD=txtCCCD.Text,
                HoTen=txtHoTen.Text,
                DiaChi=txtDiaChi.Text,
                SDT=txtDiaChi.Text
            };
            if(ungVien.CCCD.Trim().Length==0|| ungVien.HoTen.Trim().Length == 0 || ungVien.DiaChi.Trim().Length == 0 || ungVien.SDT.Trim().Length == 0)
            {
                MessageBox.Show("Xin hãy điền đầy đủ thông tin","Cảnh báo");
            }
            else if (ungVien.KiemTraTonTai(ungVien.CCCD))
            {
                MessageBox.Show("Thông tin này đã tồn tại", "Cảnh báo");
            }
            else
            {
                ungVien.DangKyUngVien(ungVien);
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
