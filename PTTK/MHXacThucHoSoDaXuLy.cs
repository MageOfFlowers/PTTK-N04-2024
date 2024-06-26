﻿using PTTK.BUS;
using PTTK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class MHXacThucHoSoDaXuLy : Form
    {
        public MHXacThucHoSoDaXuLy(string MaHS, string CCCD, string NgayNop)
        {
            InitializeComponent();
            UngVien db = new UngVien();
            BangCap bc = new BangCap();
            UngVien uv = db.TimThongTinUngVien(CCCD);
            lbHoTen.Text = "Họ tên: " + uv.HoTen;
            lbCCCD.Text = "CCCD: " + uv.CCCD;
            lbDiaChi.Text = "Địa chỉ: " + uv.DiaChi;
            lbSDT.Text = "Điện thoại: " + uv.SDT;
            lbNgayNopHoSo.Text = "Ngày nộp: " + NgayNop;
            lbMaHS.Text = "Mã Hồ sơ: " + MaHS;
            MemoryStream ms = new MemoryStream(uv.Anh);
            UngVienPB.Image = Image.FromStream(ms);
            UngVienPB.SizeMode = PictureBoxSizeMode.StretchImage;
            BangCapDGV.DataSource = bc.TimBangCap(MaHS);
            BangCapDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void MHXacThucHoSoDaXuLy_Load(object sender, EventArgs e)
        {

        }
    }
}
