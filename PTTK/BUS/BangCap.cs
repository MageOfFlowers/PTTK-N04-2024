using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DAO
{
    public class BangCap
    {
        public string MaHS { get; set; }
        public string TenBangCap { get; set; }
        public string LoaiBangCap { get; set; }
        public string ChiTietBangCap { get; set; }
        public void ExecuteStoredProcedure(string v, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataTable TimBangCap(string MaHS)
        {
            BangCapDB BangCapDB = new BangCapDB();
            return BangCapDB.LayBangCap(MaHS);
        }
    }
}
