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
    public partial class MHThanhToan : Form
    {
        string MaQC;
        public MHThanhToan(string m_MaQC)
        {
            InitializeComponent();
            MaQC = m_MaQC;
        }

        private void MHThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
