using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.DAO;

namespace PTTK.BUS
{
    internal class TaiKhoan
    {
        public string TenDangNhap {  get; set; }
        public string Ten {  get; set; }
        public string VaiTro {  get; set; }

        public TaiKhoan DangNhap(string TenDangNhap, string MatKhau)
        {
            TaiKhoanDB tk = new TaiKhoanDB();
            return tk.DangNhap(TenDangNhap,MatKhau);
        }
    }
}
