using PTTK.BUS;
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
    public partial class MMNV : Form
    {
        public MMNV()
        {
            InitializeComponent();
            label2.Text = "Xin chào " + Program.taikhoan.Ten;
            label2.Location = new Point((this.ClientSize.Width - label2.Width) / 2, label2.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MMNV_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.taikhoan = null;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
