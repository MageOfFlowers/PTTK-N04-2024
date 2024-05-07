using PTTK.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        public string MaTT { get; set; }
        public void ExecuteStoredProcedure(string v, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public (DataTable, DataTable, DataTable) TimDangKyUngTuyen(string MaTT)
        {
            DangKyUngTuyenDB DangKyUngTuyenDB = new DangKyUngTuyenDB();
            return DangKyUngTuyenDB.LayDangKyUngTuyen(MaTT);
        }
    }
}
