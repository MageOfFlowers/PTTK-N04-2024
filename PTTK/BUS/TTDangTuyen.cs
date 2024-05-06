using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.BUS
{
    public class TTDangTuyen
    {
        public string MaTT { get; set; }
        public string ViTriDangTuyen { get; set; }
        public int SoLuongTuyenDung { get; set; }
        public DateTime BatDauTuyenDung { get; set; }
        public DateTime BatDauKetThuc { get; set; }
        public DateTime HanTuyenDung { get; set; }
        public string YeuCau {  get; set; }
        public string MaSoThue {  get; set; }
        public TTDangTuyen LayTTDangTuyen { get; set; }
    }
    
}
