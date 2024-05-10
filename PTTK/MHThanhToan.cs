using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK.BUS;
using PTTK.DAO;
using System.Windows.Forms;

namespace PTTK
{
    public partial class MHThanhToan : Form
    {
        ThanhToan tt;
        public MHThanhToan(ThanhToan m_tt)
        {
            InitializeComponent();
            tt = m_tt;
            HienThi();
        }
        public MHThanhToan()
        {
            InitializeComponent();
            HienThi();
        }

        private void MHThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void HienThi()
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
