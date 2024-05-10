using PTTK.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.BUS
{
    public class DangKyUngTuyen
    {
        public string MaHS {  get; set; }
        public DateTime NgayNopHoSo {  get; set; }
        public string DuDienKien { get; set; }
        public string CCCD { get; set; }
        public string HoTen {  get; set; }
        public string MaTT { get; set; }

        public (DataTable, DataTable, DataTable) TimDangKyUngTuyen(string MaTT)
        {
            DangKyUngTuyenDB DangKyUngTuyenDB = new DangKyUngTuyenDB();
            return DangKyUngTuyenDB.LayDangKyUngTuyen(MaTT);
        }
        public void LuuDangKyUngTuyen(DataTable ChoGui, DataTable ChapNhan, DataTable TuChoi)
        {
            DangKyUngTuyenDB DangKyUngTuyenDB = new DangKyUngTuyenDB();
            DangKyUngTuyenDB.LuuDangKyUngTuyen(ChoGui,ChapNhan,TuChoi);
        }
    }
}
