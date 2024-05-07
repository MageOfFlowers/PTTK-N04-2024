using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.DAO;

namespace PTTK.BUS
{
    public class TTDangTuyen
    {
        public string MaTT { get; set; }
        public string ViTriTuyen { get; set; }
        public int SoLuongTuyen { get; set; }
        public DateTime BatDauTuyen { get; set; }
        public DateTime KetThucTuyen { get; set; }
        public string YeuCau {  get; set; }
        public string MaSoThue {  get; set; }

        public void ExecuteStoredProcedure(string v, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<TTDangTuyen> TimTTDangTuyen(string MaSoThue)
        {
            TTDangTuyenDB ttDangTuyenDB = new TTDangTuyenDB();
            return ttDangTuyenDB.LayTTDangTuyen(MaSoThue);
        }
    }
    
}
