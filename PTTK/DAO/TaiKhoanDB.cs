using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Reflection;


namespace PTTK.DAO
{
    internal class TaiKhoanDB
    {

        internal TaiKhoan DangNhap(string TaiKhoan, string MatKhau)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                using (SqlCommand command = new SqlCommand("DangNhap", connection))
                {
                    TaiKhoan tk = new TaiKhoan();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@TaiKhoan", SqlDbType.VarChar)).Value = TaiKhoan;
                    command.Parameters.Add(new SqlParameter("@MatKhau", SqlDbType.VarChar)).Value = MatKhau;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        if (result.Rows.Count == 1)
                        {
                            tk.TenDangNhap = result.Rows[0]["TenDangNhap"].ToString();
                            tk.VaiTro = result.Rows[0]["VaiTro"].ToString();
                            tk.Ten = result.Rows[0]["Ten"].ToString();
                        }
                        else
                        {
                            tk = null;
                        }
                        return tk;
                    }
                }
            }
        }
    }
}
