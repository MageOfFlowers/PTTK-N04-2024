using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK.BUS;

namespace PTTK.DAO
{
    internal class ThanhToanDB
    {
        private static readonly SqlConnection connection = new SqlConnection(Program.connString);

        public static DataTable LayDSHoaDon()
        {
            DataTable ds = new DataTable();
            string proc_name = "lay_ds_hoa_don";
            try
            {
                using (SqlCommand command = new SqlCommand(proc_name, connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        adapter.Fill(ds);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        public static int LayLanThanhToan(string MaQC)
        {
            int lanTra = 1;
            string proc_name = "lay_lan_thanh_toan";
            try
            {
                using (SqlCommand command = new SqlCommand(proc_name, connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maqc", MaQC);

                    lanTra = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return lanTra;
        }

        public static void ThanhToan(ThanhToan tt)
        {

            string proc_name = "thuc_hien_thanh_toan";
            try
            {
                using (SqlCommand command = new SqlCommand(proc_name, connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ma_qc", tt.MaQC);
                    command.Parameters.AddWithValue("@lan_tra", tt.LanTT);
                    command.Parameters.AddWithValue("@so_tien", tt.SoTien);
                    command.Parameters.AddWithValue("@ngay_thanh_toan", tt.NgayTT);
                    command.Parameters.AddWithValue("@phuong_thuc", tt.PhuongThuc);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                connection.Close(); 
            }
        }
    }
}
