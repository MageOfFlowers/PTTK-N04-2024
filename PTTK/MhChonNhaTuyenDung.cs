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
        IList<TTDangTuyen> DsTTDangTuyen = new List<TTDangTuyen>();
        TTDangTuyen TTDangTuyen = new TTDangTuyen();
        DangKyUngTuyen DangKyUngTuyen = new DangKyUngTuyen();
        DataTable ChoGui = new DataTable();
        DataTable ChapNhan = new DataTable();
        DataTable TuChoi = new DataTable();

        public MhChonNhaTuyenDung(string MaSoThue)
        {
            InitializeComponent();
            DsTTDangTuyen=TTDangTuyen.TimTTDangTuyen(MaSoThue);
            for (int intCount = 0; intCount < DsTTDangTuyen.Count; intCount++)
            {
                var val = DsTTDangTuyen[intCount];
                ViTriCB.Items.Add(val);
                ViTriCB.DisplayMember = "MaTT";
            }
            DataGridViewButtonColumn ChapNhanCol = new DataGridViewButtonColumn();
            ChapNhanCol.Name = "ChapNhanCol";
            ChapNhanCol.HeaderText = "";
            ChapNhanCol.Text = "Chấp nhận";
            ChapNhanCol.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TuChoiCol = new DataGridViewButtonColumn();
            TuChoiCol.Name = "TuChoiCol";
            TuChoiCol.HeaderText = "";
            TuChoiCol.Text = "Từ chối";
            TuChoiCol.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TroVeCol1 = new DataGridViewButtonColumn();
            TroVeCol1.Name = "TroVeCol1";
            TroVeCol1.HeaderText = "";
            TroVeCol1.Text = "Xóa";
            TroVeCol1.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn TroVeCol2 = new DataGridViewButtonColumn();
            TroVeCol2.Name = "TroVeCol2";
            TroVeCol2.HeaderText = "";
            TroVeCol2.Text = "Xóa";
            TroVeCol2.UseColumnTextForButtonValue = true;


            MaHSDGV.Columns.Add(ChapNhanCol);

            MaHSDGV.Columns.Add(TuChoiCol);

            ChapNhanDGV.Columns.Add(TroVeCol1);

            TuChoiDGV.Columns.Add(TroVeCol2);

            MaHSDGV.Columns["ChapNhanCol"].Width = 65;
            MaHSDGV.Columns["TuChoiCol"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;
            
            ChapNhanDGV.Columns["TroVeCol1"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;
            TuChoiDGV.Columns["TroVeCol2"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;
            

        }

        private void MhChonNhaTuyenDung_Load(object sender, EventArgs e)
        {

        }

        private void ViTriCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbSL.Text = ((TTDangTuyen) ViTriCB.SelectedItem).SoLuongTuyen.ToString();
            lbViTri.Text = ((TTDangTuyen)ViTriCB.SelectedItem).ViTriTuyen.ToString();
            var r = DangKyUngTuyen.TimDangKyUngTuyen(((TTDangTuyen)ViTriCB.SelectedItem).MaTT.ToString());
            ChoGui = r.Item1 as DataTable;
            ChapNhan = r.Item2 as DataTable;
            TuChoi = r.Item3 as DataTable;
            MaHSDGV.DataSource = ChoGui;
            ChapNhanDGV.DataSource = ChapNhan;
            TuChoiDGV.DataSource = TuChoi;
            lbSLYC.Text = (MaHSDGV.Rows.Count-1).ToString();
            lbSLCN.Text = (ChapNhanDGV.Rows.Count-1).ToString();
            lbSLTC.Text = (TuChoiDGV.Rows.Count-1).ToString();
            MaHSDGV.Columns["MaHS"].Width = 80;
            MaHSDGV.Columns["NgayGui"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MaHSDGV.Columns["NgayNop"].Visible = false;
            MaHSDGV.Columns["TrangThai"].Visible = false;
            MaHSDGV.Columns["DoUuTien"].Visible = false;
            MaHSDGV.Columns["CCCD"].Visible = false;
            ChapNhanDGV.Columns["MaHS"].Width = MaHSDGV.Columns["MaHS"].Width;
            ChapNhanDGV.Columns["NgayGui"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ChapNhanDGV.Columns["NgayNop"].Visible = false;
            ChapNhanDGV.Columns["TrangThai"].Visible = false;
            ChapNhanDGV.Columns["DoUuTien"].Visible = false;
            ChapNhanDGV.Columns["CCCD"].Visible = false;
            TuChoiDGV.Columns["MaHS"].Width = MaHSDGV.Columns["MaHS"].Width;
            TuChoiDGV.Columns["NgayGui"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TuChoiDGV.Columns["NgayNop"].Visible = false;
            TuChoiDGV.Columns["TrangThai"].Visible = false;
            TuChoiDGV.Columns["DoUuTien"].Visible = false;
            TuChoiDGV.Columns["CCCD"].Visible = false;
            MaHSDGV.Columns["PhanHoi"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;
            ChapNhanDGV.Columns["PhanHoi"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;
            TuChoiDGV.Columns["PhanHoi"].Width = MaHSDGV.Columns["ChapNhanCol"].Width;

            MaHSDGV.Columns["ChapNhanCol"].DisplayIndex = 5;
            MaHSDGV.Columns["TuChoiCol"].DisplayIndex = 4;
            MaHSDGV.Columns["MaHS"].DisplayIndex = 0;
            MaHSDGV.Columns["HoTen"].DisplayIndex = 1;
            MaHSDGV.Columns["NgayGui"].DisplayIndex = 2;
            MaHSDGV.Columns["PhanHoi"].DisplayIndex = 3;

            ChapNhanDGV.Columns["TroVeCol1"].DisplayIndex = 4;
            ChapNhanDGV.Columns["MaHS"].DisplayIndex = 0;
            ChapNhanDGV.Columns["HoTen"].DisplayIndex = 1;
            ChapNhanDGV.Columns["NgayGui"].DisplayIndex = 2;
            ChapNhanDGV.Columns["PhanHoi"].DisplayIndex = 3;

            TuChoiDGV.Columns["TroVeCol2"].DisplayIndex = 4;
            TuChoiDGV.Columns["MaHS"].DisplayIndex = 0;
            TuChoiDGV.Columns["HoTen"].DisplayIndex = 1;
            TuChoiDGV.Columns["NgayGui"].DisplayIndex = 2;
            TuChoiDGV.Columns["PhanHoi"].DisplayIndex = 3;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MaHSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 8))
            {
                PhanHoi form2 = new PhanHoi(((DataRowView)MaHSDGV.Rows[e.RowIndex].DataBoundItem).Row);
                form2.Show();
                ChoGui.Rows[e.RowIndex]["PhanHoi"] = MaHSDGV.Rows[e.RowIndex].Cells["PhanHoi"].Value.ToString();
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex == 0))
            {
                ChapNhan.ImportRow(ChoGui.Rows[e.RowIndex]);
                ChoGui.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                ChapNhanDGV.DataSource = ChapNhan;
                MaHSDGV.DataSource = ChoGui;
                lbSLYC.Text = (MaHSDGV.Rows.Count - 1).ToString();
                lbSLCN.Text = (ChapNhanDGV.Rows.Count - 1).ToString();
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex == 1))
            {
                TuChoi.ImportRow(ChoGui.Rows[e.RowIndex]);
                ChoGui.Rows.Remove(ChoGui.Rows[e.RowIndex]);
                MaHSDGV.DataSource = ChoGui;
                TuChoiDGV.DataSource = TuChoi;
                lbSLYC.Text = (MaHSDGV.Rows.Count - 1).ToString();
                lbSLTC.Text = (TuChoiDGV.Rows.Count - 1).ToString();
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex >= 2))
            {
                string MaHS = MaHSDGV.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                string CCCD = MaHSDGV.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                string NgayNop = MaHSDGV.Rows[e.RowIndex].Cells["NgayNop"].Value.ToString();

                MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS, CCCD, NgayNop);
                form2.Show();
            }
            
        }

        private void TuChoiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 7))
            {
                PhanHoi form2 = new PhanHoi(((DataRowView)TuChoiDGV.Rows[e.RowIndex].DataBoundItem).Row);
                form2.Show();
                TuChoi.Rows[e.RowIndex]["PhanHoi"] = TuChoiDGV.Rows[e.RowIndex].Cells["PhanHoi"].Value.ToString();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                ChoGui.ImportRow(TuChoi.Rows[e.RowIndex]);
                TuChoi.Rows.Remove(TuChoi.Rows[e.RowIndex]);
                MaHSDGV.DataSource = ChoGui;
                TuChoiDGV.DataSource = TuChoi;
                lbSLYC.Text = (MaHSDGV.Rows.Count - 1).ToString();
                lbSLTC.Text = (TuChoiDGV.Rows.Count - 1).ToString();
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex >= 1))
            {
                string MaHS = TuChoiDGV.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                string CCCD = TuChoiDGV.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                string NgayNop = TuChoiDGV.Rows[e.RowIndex].Cells["NgayNop"].Value.ToString();

                MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS, CCCD, NgayNop);
                form2.Show();
            }
        }

        private void ChapNhanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 7))
            {
                PhanHoi form2 = new PhanHoi(((DataRowView)ChapNhanDGV.Rows[e.RowIndex].DataBoundItem).Row);
                form2.Show();
                ChapNhan.Rows[e.RowIndex]["PhanHoi"] = ChapNhanDGV.Rows[e.RowIndex].Cells["PhanHoi"].Value.ToString();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                ChoGui.ImportRow(ChapNhan.Rows[e.RowIndex]);
                ChapNhan.Rows.Remove(ChapNhan.Rows[e.RowIndex]);
                MaHSDGV.DataSource = ChoGui;
                ChapNhanDGV.DataSource = ChapNhan;
                lbSLYC.Text = (MaHSDGV.Rows.Count - 1).ToString();
                lbSLCN.Text = (ChapNhanDGV.Rows.Count - 1).ToString();
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex >= 1))
            {
                string MaHS = ChapNhanDGV.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                string CCCD = ChapNhanDGV.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                string NgayNop = ChapNhanDGV.Rows[e.RowIndex].Cells["NgayNop"].Value.ToString();

                MHXacThucHoSoDaXuLy form2 = new MHXacThucHoSoDaXuLy(MaHS, CCCD, NgayNop);
                form2.Show();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DangKyUngTuyen dk = new DangKyUngTuyen();
            dk.LuuDangKyUngTuyen(ChoGui, ChapNhan, TuChoi);
            MessageBox.Show("Thành công");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
