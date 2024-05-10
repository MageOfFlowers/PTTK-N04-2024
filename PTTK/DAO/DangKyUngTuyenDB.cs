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
                        adapter.Fill(result1);
                        adapter.Fill(result2);
                        for (int i = 0; i < result.Rows.Count; i++)
                        {
                            if (result.Rows[i]["TrangThai"].ToString() != "ChoGui")
                            {
                                result.Rows.Remove(result.Rows[i]);
                                i--;
                            }
                        }
                        for (int i = 0; i < result1.Rows.Count; i++)
                        {
                            if (result1.Rows[i]["TrangThai"].ToString() != "ChapNhan")
                            {
                                result1.Rows.Remove(result1.Rows[i]);
                                i--;
                            }
                        }
                        for (int i = 0; i < result2.Rows.Count; i++)
                        {
                            if (result2.Rows[i]["TrangThai"].ToString() != "TuChoi")
                            {
                                result2.Rows.Remove(result2.Rows[i]);
                                i--;
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
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        foreach (DataRow row in ChoGui.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.VarChar)).Value = "ChoGui";
                            command.Parameters.Add(new SqlParameter("@PhanHoi", SqlDbType.VarChar)).Value = row["PhanHoi"];
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@TrangThai"]);
                            command.Parameters.Remove(command.Parameters["@PhanHoi"]);
                        }
                        foreach (DataRow row in ChapNhan.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.VarChar)).Value = "ChapNhan";
                            command.Parameters.Add(new SqlParameter("@PhanHoi", SqlDbType.VarChar)).Value = row["PhanHoi"];
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@TrangThai"]);
                            command.Parameters.Remove(command.Parameters["@PhanHoi"]);
                        }
                        foreach (DataRow row in TuChoi.Rows)
                        {
                            command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = row["MaHS"];
                            command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.VarChar)).Value = "TuChoi";
                            command.Parameters.Add(new SqlParameter("@PhanHoi", SqlDbType.VarChar)).Value = row["PhanHoi"];
                            command.ExecuteNonQuery();
                            command.Parameters.Remove(command.Parameters["@MaHS"]);
                            command.Parameters.Remove(command.Parameters["@TrangThai"]);
                            command.Parameters.Remove(command.Parameters["@PhanHoi"]);
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
