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
	internal class DoanhNghiepDB
	{
		internal DoanhNghiep LayTTDangTuyen(string MaSoThue)
		{

			using (SqlConnection connection = new SqlConnection(Program.connString))
			{
				using (SqlCommand command = new SqlCommand("LayTTDangTuyen", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.Add(new SqlParameter("@MaSoThue", SqlDbType.VarChar)).Value = MaSoThue;

					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						DataTable result = new DataTable();
						adapter.Fill(result);
						foreach (DataRow t in result.Rows)
						{
							DoanhNghiep db = new DoanhNghiep();
							db.MaSoThue = t["MaSoThue"].ToString();
							db.TenCongTy = t["TenCongTy"].ToString();
							db.DiaChi = t["DiaChi"].ToString();
							db.Email = t["Email"].ToString();
							db.NguoiDaiDien = t["NguoiDaiDien"].ToString();
							db.TrangThai = t["TrangThai"].ToString(); 
							db.UuDai = t["UuDai"].ToString();
							return db;
						}
					}
				}
			}
			return new DoanhNghiep();
		}

		internal void DangKyThanhVien(DoanhNghiep doanhNghiep)
		{
			using (SqlConnection connection = new SqlConnection(Program.connString))
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand("DangKyThanhVien", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.Add(new SqlParameter("@MaSoThue", SqlDbType.VarChar, 10)).Value = doanhNghiep.MaSoThue;
						command.Parameters.Add(new SqlParameter("@TenCongTy", SqlDbType.VarChar, 50)).Value = doanhNghiep.TenCongTy;
						command.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.VarChar, 100)).Value = doanhNghiep.DiaChi;
						command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50)).Value = doanhNghiep.Email;
						command.Parameters.Add(new SqlParameter("@NguoiDaiDien", SqlDbType.VarChar, 20)).Value = doanhNghiep.NguoiDaiDien;
						command.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.VarChar, 20)).Value = DBNull.Value;
						command.Parameters.Add(new SqlParameter("@UuDai", SqlDbType.VarChar, 10)).Value = DBNull.Value;
						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Có lỗi xảy ra:" + ex.Message, "Cảnh báo");
					return;
				}
				finally
				{
					connection?.Close();
				}
				MessageBox.Show("Đăng ký thành công", "Thông báo");
			}
		}
		internal bool KiemTraTonTai(string MaSoThue)
		{ 
			using (SqlConnection connection = new SqlConnection(Program.connString))
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand("Select count(*) from DOANH_NGHIEP where MaSoThue=@MaSoThue", connection))
					{
						command.Parameters.Add(new SqlParameter("@MaSoThue", SqlDbType.VarChar)).Value = MaSoThue;
						return Convert.ToInt32(command.ExecuteScalar()) == 1;
					}
				}
				catch (Exception)
				{
					return true;
				}
				finally
				{
					connection?.Close();
				}
			}

		}
	}
}
