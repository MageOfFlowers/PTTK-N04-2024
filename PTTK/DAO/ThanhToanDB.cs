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
        public void ThanhToan(ThanhToan tt)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();
                    string proc_name = "thanh_toan";
                }
                catch 
                { 
                }
            }
        }
    }
}
