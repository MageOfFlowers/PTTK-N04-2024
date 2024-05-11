using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.DAO;

namespace PTTK.BUS
{
    public class ThanhToan
    {
        public string MaQC { get; set; }
        public string MaTT { get; set; }
        public Int64 SoTien { get; set; }
        public string PhuongThuc { get; set; }
        public int LanTT { get; set; }
        public DateTime NgayTT { get; set; }
    }
}
