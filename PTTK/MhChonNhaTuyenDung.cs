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
    public partial class MhChonNhaTuyenDung : Form
    {
        static IList<TTDangTuyen> DsTTDangTuyen = new List<TTDangTuyen>();
        TTDangTuyen TTDangTuyen = new TTDangTuyen();
        DangKyUngTuyen DangKyUngTuyen = new DangKyUngTuyen();
        string mMaSoThue;
        DataTable ChoGui = new DataTable();
        DataTable ChapNhan = new DataTable();
        DataTable TuChoi = new DataTable();

        public MhChonNhaTuyenDung(string MaSoThue)
        {
            InitializeComponent();
            mMaSoThue = MaSoThue;
            DsTTDangTuyen=TTDangTuyen.TimTTDangTuyen(MaSoThue);
            for (int intCount = 0; intCount < DsTTDangTuyen.Count; intCount++)
            {
                var val = DsTTDangTuyen[intCount];
                ViTriCB.Items.Add(val);
                ViTriCB.DisplayMember = "MaTT";
            }
            DataGridViewButtonColumn ChapNhanCol = new DataGridViewButtonColumn();
            ChapNhanCol.Name = "ChapNhanCol";
            ChapNhanCol.HeaderText = "Chấp nhận";
            ChapNhanCol.Text = "Chấp nhận";
            ChapNhanCol.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TuChoiCol = new DataGridViewButtonColumn();
            TuChoiCol.Name = "TuChoiCol";
            TuChoiCol.HeaderText = "Từ Chối";
            TuChoiCol.Text = "Từ chối";
            TuChoiCol.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TroVeCol1 = new DataGridViewButtonColumn();
            TroVeCol1.Name = "TroVeCol1";
            TroVeCol1.HeaderText = "Xóa";
            TroVeCol1.Text = "Xóa";
            TroVeCol1.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TroVeCol2 = new DataGridViewButtonColumn();
            TroVeCol2.Name = "TroVeCol2";
            TroVeCol2.HeaderText = "Xóa";
            TroVeCol2.Text = "Xóa";
            TroVeCol2.UseColumnTextForButtonValue = true;

            MaHSDGV.Columns.Add(ChapNhanCol);
            MaHSDGV.CellClick += MaHSDGV_ChapNhan_CellClick;

            MaHSDGV.Columns.Add(TuChoiCol);
            MaHSDGV.CellClick += MaHSDGV_TuChoi_CellClick;

            ChapNhanDGV.Columns.Add(TroVeCol1);
            ChapNhanDGV.CellClick += ChapNhanDGV_TroVe1_CellClick;

            TuChoiDGV.Columns.Add(TroVeCol2);
            TuChoiDGV.CellClick += TuChoiDGV_TroVe2_CellClick;

        }

        private void MhChonNhaTuyenDung_Load(object sender, EventArgs e)
        {

        }

        private void ViTriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaHSDGV.Rows.Clear();
            ChapNhanDGV.Rows.Clear();
            TuChoiDGV.Rows.Clear();
            lbSL.Text = ((TTDangTuyen) ViTriCB.SelectedItem).SoLuongTuyenDung.ToString();
            lbViTri.Text = ((TTDangTuyen)ViTriCB.SelectedItem).SoLuongTuyenDung.ToString();
            var r = DangKyUngTuyen.TimDangKyUngTuyen(((TTDangTuyen)ViTriCB.SelectedItem).MaTT.ToString());
            ChoGui = r.Item1 as DataTable;
            ChapNhan = r.Item2 as DataTable;
            TuChoi = r.Item3 as DataTable;
            MaHSDGV.DataSource = ChoGui;
            ChapNhanDGV.DataSource = ChapNhan;
            TuChoiDGV.DataSource = TuChoi;
            lbSLYC.Text = MaHSDGV.Rows.Count.ToString();
            lbSLCN.Text = ChapNhanDGV.Rows.Count.ToString();
            lbSLTC.Text = TuChoiDGV.Rows.Count.ToString();
        }

        private void MaHSDGV_ChapNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DangKyUngTuyen obj = (DangKyUngTuyen)MaHSDGV.Rows[e.RowIndex].DataBoundItem;
                ChapNhan.Rows.Add(obj);
                ChapNhanDGV.DataSource = ChapNhan;
                ChoGui.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                MaHSDGV.DataSource = ChoGui;
            }
            lbSLYC.Text = MaHSDGV.Rows.Count.ToString();
            lbSLCN.Text = ChapNhanDGV.Rows.Count.ToString();
        }
        private void MaHSDGV_TuChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DangKyUngTuyen obj = (DangKyUngTuyen)MaHSDGV.Rows[e.RowIndex].DataBoundItem;
                TuChoi.Rows.Add(obj);
                TuChoiDGV.DataSource = TuChoi;
                ChoGui.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                MaHSDGV.DataSource = ChoGui;
            }
            lbSLYC.Text = MaHSDGV.Rows.Count.ToString();
            lbSLTC.Text = TuChoiDGV.Rows.Count.ToString();
        }
        private void ChapNhanDGV_TroVe1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DangKyUngTuyen obj = (DangKyUngTuyen)ChapNhanDGV.Rows[e.RowIndex].DataBoundItem;
                ChoGui.Rows.Add(obj);
                MaHSDGV.DataSource = ChoGui;
                ChapNhan.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                ChapNhanDGV.DataSource = ChapNhan;
            }
            lbSLYC.Text = MaHSDGV.Rows.Count.ToString();
            lbSLCN.Text = ChapNhanDGV.Rows.Count.ToString();
        }
        private void TuChoiDGV_TroVe2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DangKyUngTuyen obj = (DangKyUngTuyen)TuChoiDGV.Rows[e.RowIndex].DataBoundItem;
                ChoGui.Rows.Add(obj);
                MaHSDGV.DataSource = ChoGui;
                TuChoi.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                TuChoiDGV.DataSource = TuChoi;
            }
            lbSLYC.Text = MaHSDGV.Rows.Count.ToString();
            lbSLTC.Text = TuChoiDGV.Rows.Count.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MaHSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHS = MaHSDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string CCCD = MaHSDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string NgayNop = MaHSDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

            MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS,CCCD, NgayNop);
            form2.Show();
        }

        private void TuChoiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHS = MaHSDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string CCCD = MaHSDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string NgayNop = MaHSDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

            MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS, CCCD, NgayNop);
            form2.Show();
        }

        private void ChapNhanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHS = MaHSDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string CCCD = MaHSDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string NgayNop = MaHSDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

            MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS, CCCD, NgayNop);
            form2.Show();
        }
    }
}
