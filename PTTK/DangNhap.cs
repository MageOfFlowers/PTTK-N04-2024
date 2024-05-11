using PTTK.BUS;
using PTTK.DAO;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhapbtn_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            TaiKhoan tmp = tk.DangNhap(TaiKhoanTB.Text, MatKhauTB.Text);
            if (tmp != null) {
                MessageBox.Show("Đăng nhập thành công");
                Program.taikhoan = tmp;
                string vaitro = Program.taikhoan.VaiTro;
                if (vaitro == "DN")
                {
                    MMDN m = new MMDN();
                    m.Show();
                }
                else if (vaitro == "UV")
                {
                    MMUV m = new MMUV();
                    m.Show();
                }
                else if (vaitro == "NV")
                {
                    MMNV m = new MMNV();
                    m.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
                
        }

        private void DangKybtn_Click(object sender, EventArgs e)
        {
            DangKyUngVien dangKy=new DangKyUngVien();
            dangKy.ShowDialog();
        }

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			MHDangKyThanhVien dangKy = new MHDangKyThanhVien();
			dangKy.ShowDialog();
		}
	}
}
