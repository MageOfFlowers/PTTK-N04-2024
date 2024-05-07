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
    internal class TTDangTuyenDB
    {
        internal IList<TTDangTuyen> LayTTDangTuyen(string MaSoThue)
        {
            List<TTDangTuyen> db = new List<TTDangTuyen>();
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                using (SqlCommand command = new SqlCommand("LayTTDangTuyen", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MaSoThue", SqlDbType.VarChar)).Value=MaSoThue;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        Console.WriteLine(result);
                        Console.WriteLine(MaSoThue);
                        foreach (DataRow t in result.Rows)
                        {
                            TTDangTuyen tmp = new TTDangTuyen();
                            tmp.MaTT = t["MaTT"].ToString();
                            tmp.ViTriTuyen = t["ViTriTuyen"].ToString();
                            tmp.SoLuongTuyen = Convert.ToInt32(t["SoLuongTuyen"]);
                            tmp.BatDauTuyen = Convert.ToDateTime(t["BatDauTuyen"]);
                            tmp.KetThucTuyen = Convert.ToDateTime(t["KetThucTuyen"]);
                            tmp.YeuCau = t["YeuCau"].ToString();
                            tmp.MaSoThue = t["MaSoThue"].ToString();
                            db.Add(tmp);
                        }

                        return db;
                    }
                }
            }
        }



    }
}
