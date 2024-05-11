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
    public class DoanhNghiep
    {
		public string MaSoThue { get; set; }
		public string TenCongTy { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
		public string NguoiDaiDien { get; set; }
		public string TrangThai { get; set; }
		public string UuDai { get; set; }

		public DoanhNghiep TimThongTinDoanhNghiep(string MaSoThue)
		{
			DoanhNghiepDB doanhNghiepDB = new DoanhNghiepDB();
			return doanhNghiepDB.LayThongTinDoanhNghiep(MaSoThue);
		}
		public bool KiemTraTonTai(string MaSoThue)
		{
			DoanhNghiepDB doanhNghiepDB = new DoanhNghiepDB();
			return doanhNghiepDB.KiemTraTonTai(MaSoThue);
		}
		public void DangKyThanhVien(DoanhNghiep doanhNghiep)
		{
			DoanhNghiepDB doanhNghiepDB = new DoanhNghiepDB();
			doanhNghiepDB.DangKyThanhVien(doanhNghiep);
		}
	}

}
