using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.DAO;

namespace PTTK.BUS
{
    public class UngVien
    {
        public string CCCD {  get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set;}
        public string DiaChi { get; set; }
        public byte[] Anh { get; set; }
        public UngVien TimThongTinUngVien(string CCCD)
        {
            UngVienDB UngVienDB = new UngVienDB();
            return UngVienDB.LayThongTinUngVien(CCCD);
        }
        public void DangKyUngVien(UngVien ungVien)
        {
            UngVienDB ungVienDB=new UngVienDB();
            ungVienDB.DangKyUngVien(ungVien);
        }
        public bool KiemTraTonTai(string CCCD)
        {
            UngVienDB ungVienDB=new UngVienDB();
            return ungVienDB.KiemTraTonTai(CCCD);
        }

    }
}
