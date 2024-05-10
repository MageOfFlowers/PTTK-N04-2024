using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTTK
{
    public partial class MHThongKeDoanhNghiep : Form
    {
        public MHThongKeDoanhNghiep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MHThongKeDoanhNghiep_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_GetDoanhNghiep", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHGiaHanHopDong form2 = new MHGiaHanHopDong();
            form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col1Value;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                col1Value = selectedRow.Cells["MaSoThue"].Value.ToString();
                textBox1.Text = col1Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
