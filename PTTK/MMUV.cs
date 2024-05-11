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
    public partial class MMUV : Form
    {
        public MMUV()
        {
            InitializeComponent();
            label2.Text = "Xin chào " + Program.taikhoan.Ten;
            label2.Location = new Point((this.ClientSize.Width - label2.Width) / 2, label2.Location.Y);
        }

        private void MMUV_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.taikhoan = null;
            Close();
        }
    }
}
