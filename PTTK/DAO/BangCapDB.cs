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
    internal class BangCapDB
    {
        internal DataTable LayBangCap(string MaHS)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                using (SqlCommand command = new SqlCommand("LayBangCap", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MaHS", SqlDbType.VarChar)).Value = MaHS;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        
                        adapter.Fill(result);
                        
                    }
                }
            }
            return result;
        }
    }
}
