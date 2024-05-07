using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace PTTK
{
    internal static class Program
    {
        public static readonly string connString = "Server=.;Database=QL_HSUT;Integrated Security=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                using (SqlCommand command = new SqlCommand("LayBangCap", connection))
                {
                    Image img = Image.FromFile("C:/Users/User/OneDrive - VNU-HCMUS/Pictures/Saved Pictures/18 (2).jpg");
                    MemoryStream tmpStream = new MemoryStream();
                    img.Save(tmpStream, ImageFormat.Png); // change to other format if needed
                    tmpStream.Seek(0, SeekOrigin.Begin);
                    byte[] imgBytes = new byte[tmpStream.Length];
                    tmpStream.Read(imgBytes, 0, (int)tmpStream.Length);

                    command.CommandText = "UPDATE UNG_VIEN SET Anh = @payload";
                    IDataParameter par = command.CreateParameter();
                    par.ParameterName = "@payload";
                    par.DbType = DbType.Binary;
                    par.Value = imgBytes;
                    command.Parameters.Add(par);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MhChonNhaTuyenDung("389L3R"));
        }
    }
}
