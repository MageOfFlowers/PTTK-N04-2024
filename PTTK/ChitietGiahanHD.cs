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
    public partial class ChitietGiahanHD : Form
    {
        private DateTime dateTimePickerBatDauTuyenOldValue;
        private DateTime dateTimePickerKetThucTuyenOldValue;
        public ChitietGiahanHD()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        public void SetDataFromForm1(string data)
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_GetTTDangTuyenByMaTT", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaTT", data);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox1.Text = reader["MaTT"].ToString();
                        textBox2.Text = reader["MaSoThue"].ToString();
                        textBox3.Text = reader["TenCongTy"].ToString();
                        textBox4.Text = reader["ViTriTuyen"].ToString();
                        textBox5.Text = reader["SoLuongTuyen"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["BatDauTuyen"]);
                        dateTimePicker2.Value = Convert.ToDateTime(reader["KetThucTuyen"]);
                        textBox6.Text = reader["YeuCau"].ToString();

                        dateTimePickerBatDauTuyenOldValue = dateTimePicker1.Value;
                        dateTimePickerKetThucTuyenOldValue = dateTimePicker2.Value;
                    }

                    reader.Close();
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

        private void ChitietGiahanHD_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_TTDangTuyen()
        {
            using (SqlConnection connection = new SqlConnection(Program.connString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("usp_UpdateTTDangTuyen", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaTT", textBox1.Text);
                    command.Parameters.AddWithValue("@BatDauTuyen", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@KetThucTuyen", dateTimePicker2.Value);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công!");
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

        //Nút gia hạn
        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện 1: dateTimePickerBatDauTuyen mới phải nhỏ hơn hoặc bằng dateTimePickerKetThucTuyen mới
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày bắt đầu tuyển phải nhỏ hơn hoặc bằng ngày kết thúc tuyển!");
                dateTimePicker1.Value = dateTimePickerBatDauTuyenOldValue;
                return;
            }

            // Kiểm tra điều kiện 3: dateTimePickerBatDauTuyen mới phải lớn hơn hoặc bằng dateTimePickerKetThucTuyen cũ
            if (dateTimePicker1.Value < dateTimePickerKetThucTuyenOldValue)
            {
                MessageBox.Show("Ngày bắt đầu tuyển phải lớn hơn hoặc bằng ngày kết thúc tuyển cũ!");
                dateTimePicker1.Value = dateTimePickerBatDauTuyenOldValue;
                return;
            }

            // Kiểm tra điều kiện 2: dateTimePickerKetThucTuyen mới phải lớn hơn hoặc bằng 3 ngày so với ngày hiện tại
            if (dateTimePicker2.Value < DateTime.Today.AddDays(3))
            {
                MessageBox.Show("Ngày kết thúc tuyển phải lớn hơn hoặc bằng 3 ngày so với ngày hiện tại!");
                dateTimePicker2.Value = dateTimePickerKetThucTuyenOldValue;
                return;
            }

            //MessageBox.Show("Hợp lệ");

            Update_TTDangTuyen();

            // Lưu giá trị mới của dateTimePickerBatDauTuyen để sử dụng cho lần kiểm tra sau
            return;
        }

        //Nút hủy gia hạn
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
