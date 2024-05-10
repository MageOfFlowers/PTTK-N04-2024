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
    public partial class MHGiaHanHopDong : Form
    {
        public MHGiaHanHopDong()
        {
            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_LocDoanhNghiepQuaHanTT", connection);
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

        public string TextBoxData
        {
            get { return textBox1.Text; }
        }

        public string TextBoxData2
        {
            get { return textBox2.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHChitietGiahanHD form2 = new MHChitietGiahanHD();
            form2.SetDataFromGHHD(TextBoxData);
            form2.FormClosed += refreshData;
            form2.Show();
        }

        private void refreshData(object sender, FormClosedEventArgs e)
        {
            HienThi();
            Load_DangTuyen(TextBoxData);
        }

        private void Load_DangTuyen(string data)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_LocDangTuyenQuaHanTT", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaSoThue", data);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GiaHanHopDong_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col1Value;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                col1Value = selectedRow.Cells["MaSoThue"].Value.ToString();
                Load_DangTuyen(col1Value);
                textBox2.Text = col1Value;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col2Value;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                col2Value = selectedRow.Cells["MaTT"].Value.ToString();
                textBox1.Text = col2Value;
            }
        }
    }
}
