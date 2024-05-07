using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.BUS;

namespace PTTK.DAO
{
    internal class ThanhToanDB
    {
        private readonly SqlConnection connection = new SqlConnection(Program.connString)
        public void ThanhToan(ThanhToan tt)
        {

            string proc_name = "thanh_toan";
            try
            {
                using (SqlCommand command = new SqlCommand(proc_name, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@ma_qc", tt);
                }
            }
            catch
            {
            }
        }
    }
}
