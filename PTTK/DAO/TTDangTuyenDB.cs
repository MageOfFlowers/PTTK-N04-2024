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
                        foreach (DataRow t in result.Rows)
                        {
                            TTDangTuyen tmp = new TTDangTuyen();
                            tmp.MaTT = t["MaTT"].ToString();
                            tmp.ViTriDangTuyen = t["ViTriDangTuyen"].ToString();
                            tmp.SoLuongTuyenDung = Convert.ToInt32(t["SoLuongTuyenDung"]);
                            tmp.BatDauTuyenDung = Convert.ToDateTime(t["BatDauTuyenDung"]);
                            tmp.KetThucTuyenDung = Convert.ToDateTime(t["KetThucTuyenDung"]);
                            tmp.HanTuyenDung = Convert.ToDateTime(t["HanTuyenDung"]);
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
