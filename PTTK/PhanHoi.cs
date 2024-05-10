using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class PhanHoi : Form
    {
        DataRow tmp;
        public PhanHoi(DataRow r)
        {
            InitializeComponent();
            tmp = r;
            lbPhanHoi.Text = "Phản hồi cho " + r["HoTen"].ToString();
            PhanHoiRTB.Text = r["PhanHoi"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tmp["PhanHoi"] = PhanHoiRTB.Text;
            MessageBox.Show("Thành công");
        }

        private void PhanHoi_Load(object sender, EventArgs e)
        {

        }
    }
}
