using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PTTK.BUS
{
    public class DoanhNghiep
    {
        public string TenCongty { get; set; }
        public string MaSoThue { get; set; }
        public string NguoiDaiDien { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string MaUD { get; set; }

        public DoanhNghiep LayTTDoanhNghiep { get; set; }
    }

}
