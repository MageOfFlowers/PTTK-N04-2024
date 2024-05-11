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
	public partial class MHDangKyThanhVien : Form
	{
		public MHDangKyThanhVien()
		{
			InitializeComponent();
			HienThi();
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			DoanhNghiep doanhNghiep = new DoanhNghiep()
			{
				MaSoThue = txtMaSoThue.Text,
				TenCongTy = txtTenCongTy.Text,
				DiaChi = txtDiaChi.Text,
				Email = txtEmail.Text,
				NguoiDaiDien = txtNguoiDaiDien.Text
				};
				if (doanhNghiep.MaSoThue.Trim().Length == 0 || doanhNghiep.TenCongTy.Trim().Length == 0 || doanhNghiep.DiaChi.Trim().Length == 0 || doanhNghiep.Email.Trim().Length == 0 || doanhNghiep.NguoiDaiDien.Trim().Length == 0)
				{
					MessageBox.Show("Xin hãy điền đầy đủ thông tin", "Cảnh báo");
				}
				else if (doanhNghiep.KiemTraTonTai(doanhNghiep.MaSoThue))
				{
					MessageBox.Show("Thông tin này đã tồn tại", "Cảnh báo");
				}
				else
				{
					doanhNghiep.DangKyThanhVien(doanhNghiep);
					Close();
				}
		}

		private void HienThi()
		{
			txtMaSoThue.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhập mã số thuế";
			};
			txtTenCongTy.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhập tên Công Ty";
			};
			txtDiaChi.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhập địa chỉ";
			};
			txtEmail.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhập email";
			};
			txtNguoiDaiDien.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhập người đại diện";
			};

			txtMaSoThue.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};
			txtTenCongTy.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};
			txtDiaChi.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};
			txtEmail.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};
			txtNguoiDaiDien.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};

			btnQuayLai.MouseHover += (sender, e) =>
			{
				statusDangKy.Text = "Nhấn để quay lại";
			};
			btnQuayLai.MouseLeave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};

			btnDangKy.MouseHover += (sender, e) =>
			{
				statusDangKy.Text = "Nhấn để đăng ký";
			};
			btnDangKy.MouseLeave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};

			btnQuayLai.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhấn để quay lại";
			};
			btnQuayLai.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};

			btnDangKy.Enter += (sender, e) =>
			{
				statusDangKy.Text = "Nhấn để đăng ký";
			};
			btnDangKy.Leave += (sender, e) =>
			{
				statusDangKy.Text = "";
			};
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Quay lại màn hình chính?", "Nhắn nhở", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Close();
			}
		}
	}
}
