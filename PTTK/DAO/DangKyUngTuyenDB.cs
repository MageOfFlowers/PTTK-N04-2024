using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace PTTK.DAO
{
    internal class DangKyUngTuyenDB
    {
        internal (DataTable, DataTable, DataTable) LayDangKyUngTuyen(string MaSoThue)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                using (SqlCommand command = new SqlCommand("LayDangKyUngTuyen", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MaTT", SqlDbType.VarChar)).Value = MaSoThue;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        DataTable result1 = new DataTable();
                        DataTable result2 = new DataTable();
                        adapter.Fill(result);
                        foreach (DataRow row in result.Rows)
                        {
                            if (row["DuDieuKien"].ToString() == "ChapNhan")
                            {
                                result1.Rows.Add(row);
                                result.Rows.Remove(row);
                            }
                            else if (row["DuDieuKien"].ToString() == "TuChoi")
                            {
                                result2.Rows.Add(row);
                                result.Rows.Remove(row);
                            }
                        }
                        return (result,result1,result2);
                    }
                }
            }
        }


        internal void LuuDangKyUngTuyen(DataTable ChoGui, DataTable ChapNhan, DataTable TuChoi)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                using (SqlCommand command = new SqlCommand("LuuDangKyUngTuyen", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        foreach (DataRow row in ChoGui.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@DuDieuKien", SqlDbType.VarChar)).Value = "ChoGui";
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@DuDieuKien"]);
                        }
                        foreach (DataRow row in ChapNhan.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@DuDieuKien", SqlDbType.VarChar)).Value = "ChapNhan";
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@DuDieuKien"]);
                        }
                        foreach (DataRow row in TuChoi.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@DuDieuKien", SqlDbType.VarChar)).Value = "TuChoi";
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@DuDieuKien"]);
                        }
                    }
                }
            }
        }
    }
}
