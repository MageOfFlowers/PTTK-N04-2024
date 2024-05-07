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
    internal class UngVienDB
    {
        internal UngVien LayThongTinUngVien(string CCCD)
        {
            
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand command = new SqlCommand("LayThongTinUngVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@CCCD", SqlDbType.VarChar)).Value = CCCD;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        foreach (DataRow t in result.Rows)
                        {
                            UngVien db = new UngVien();
                            db.CCCD = t["CCCD"].ToString();
                            db.SDT = t["ViTriDangTuyen"].ToString();
                            db.Anh = (byte[])t["Anh"];
                            db.HoTen = t["YeuCau"].ToString();
                            db.DiaChi = t["MaSoThue"].ToString();
                            return db;
                        }                        
                    }
                }
            }
            return new UngVien();
        }
    }
}
