using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DAO
{
    public class TTDangTuyenDB
    {
        public TTDangTuyen LayTTDangTuyen()
        {
            TTDangTuyen db = new TTDangTuyen();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@param1", SqlDbType.Int) { Value = 123 },
                new SqlParameter("@param2", SqlDbType.VarChar, 50) { Value = "test" }
            };
            db.ExecuteStoredProcedure("YourStoredProcedure", parameters);
        }
    }
}
