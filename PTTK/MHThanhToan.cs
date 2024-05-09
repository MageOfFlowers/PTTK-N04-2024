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
            HienThi(tt);
        }
        public MHThanhToan()
        {
            InitializeComponent();
        }

        private void HienThi(ThanhToan tt) 
        {
            MaQC_lbl.Text = tt.MaQC;
        }

        private void MHThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void file_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                }
            }
        }
    }
}
