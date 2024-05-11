using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.BUS;
using PTTK.DAO;

namespace PTTK
{
    public class ThanhToanController
    {
        public DataTable LayDSHoaDon()
        {
            return ThanhToanDB.LayDSHoaDon();
        }
        public int LayLanThanhToan(string MaQC)
        {
            return ThanhToanDB.LayLanThanhToan(MaQC);
        }

        public void ThanhToan(ThanhToan tt)
        {
            ThanhToanDB.ThanhToan(tt);
        }
    }
}
