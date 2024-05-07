using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MhChonNhaTuyenDung());
        }
    }
}
