using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.BUS;
using PTTK.DAO;
using System.Windows.Forms;

namespace PTTK
{
    public partial class MHThanhToan : Form
    {
        ThanhToanController controller = new ThanhToanController();
        public MHThanhToan()
        {
            InitializeComponent();
            HienThi();
        }

        private void MHThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void HienThi()
        {
            DSHoaDon.DataSource = controller.LayDSHoaDon();

            DataGridViewButtonColumn thanhToan = new DataGridViewButtonColumn();
            thanhToan.Name = "ThanhToan";
            thanhToan.HeaderText = "";
            thanhToan.Text = "Thanh toán";
            thanhToan.UseColumnTextForButtonValue = true;

            DSHoaDon.Columns.Add(thanhToan);

            DSHoaDon.CellFormatting += DSHoaDon_CellFormatting;
            DSHoaDon.CellContentClick += DSHoaDon_CellContentClick;

            DSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void DSHoaDon_CellFormatting (object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DSHoaDon.Columns[e.ColumnIndex].Name == "ThanhToan" && e.RowIndex >= 0)
            {
                e.CellStyle.BackColor = Color.Lime;
            }
        }

        private void DSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DSHoaDon.Columns[e.ColumnIndex].Name == "ThanhToan" && e.RowIndex >= 0)
            {
                ThanhToan tt = new ThanhToan();
                DataGridViewRow row = DSHoaDon.Rows[e.RowIndex];

                HoaDonPanel.Visible = true;
                string maQC = row.Cells["MaQC"].Value.ToString();

                MaSoThue.Text = row.Cells["MaSoThue"].Value.ToString();
                TenDN.Text = row.Cells["TenCongTy"].Value.ToString();
                MaQC.Text = maQC;
                ChiPhi.Text = row.Cells["TongSoTien"].Value.ToString();

                LanTra.Text = controller.LayLanThanhToan(maQC).ToString();

                CoCheTT.Items.Add("Toàn bộ");
                CoCheTT.SelectedIndex = 0;

                DateTime ngayDT = Convert.ToDateTime(row.Cells["NgayDangTuyen"].Value);
                if (ngayDT.AddDays(30) <= DateTime.Today)
                {
                    CoCheTT.Items.Add("Theo đợt");
                    if (Convert.ToInt32(LanTra.Text) > 1)
                    {
                        CoCheTT.Items.Remove("Toàn bộ");
                        CoCheTT.SelectedIndex = 0;
                        SoTien.Text = tinhTien(Convert.ToInt64(ChiPhi.Text), Convert.ToInt32(LanTra.Text)).ToString();
                    }
                }
            }
        }

        private Int64 tinhTien(Int64 TongTien, int LanTra)
        {
            if (LanTra <= 3)
            {
                return TongTien * 30 / 100;
            }
            else
            {
                return TongTien - 3 * (TongTien * 30 / 100);
            }
        }

        private void KetThucThanhToan()
        {
            CoCheTT.Items.Clear();
            HoaDonPanel.Visible = false;
            DSHoaDon.DataSource = controller.LayDSHoaDon();

        }

        private void QuayLai_Click(object sender, EventArgs e)
        {
            KetThucThanhToan();
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (PhuongThucTT.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
                return;
            }
            ThanhToan tt = new ThanhToan();
            tt.MaQC = MaQC.Text;
            tt.LanTT = Convert.ToInt32(LanTra.Text);
            tt.PhuongThuc = PhuongThucTT.SelectedItem.ToString();
            tt.SoTien = Convert.ToInt64(SoTien.Text);
            tt.NgayTT = DateTime.Now;

            controller.ThanhToan(tt);
            KetThucThanhToan();
        }

        private void CoCheTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoCheTT.SelectedIndex == 0) 
            {
                SoTien.Text = ChiPhi.Text;
            }
            else
            {
                SoTien.Text = tinhTien(Convert.ToInt64(ChiPhi.Text), Convert.ToInt32(LanTra.Text)).ToString();
            }    
        }
    }
}
