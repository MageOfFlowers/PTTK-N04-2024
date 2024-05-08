using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.DAO
{
    internal class UngVienDB
    {
        internal UngVien LayThongTinUngVien(string CCCD)
        {
            
            using (SqlConnection connection = new SqlConnection(Program.connString))
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
                            db.SDT = t["SDT"].ToString();
                            db.Anh = (byte[])t["Anh"];
                            db.HoTen = t["HoTen"].ToString();
                            db.DiaChi = t["DiaChi"].ToString();
                            return db;
                        }                        
                    }
                }
            }
            return new UngVien();
        }

        internal void DangKyUngVien(UngVien ungVien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connString))
                {
                    using (SqlCommand command = new SqlCommand("DangKyUngVien", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CCCD", SqlDbType.VarChar,10)).Value = ungVien.CCCD;
                        command.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.VarChar,20)).Value = ungVien.HoTen;
                        command.Parameters.Add(new SqlParameter("@SDT", SqlDbType.VarChar,10)).Value = ungVien.SDT;
                        command.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.VarChar,50)).Value = ungVien.DiaChi;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        internal bool KiemTraTonTai(string CCCD)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connString))
                {
                    using (SqlCommand command = new SqlCommand("Select count(*) from UNG_VIEN where CCCD=@CCCD", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@CCCD", SqlDbType.VarChar)).Value = CCCD;
                        return Convert.ToInt32(command.ExecuteScalar())==1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
    }
}
