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

namespace PhieuBanHangForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data1 = dateTimePicker1.Value.ToShortDateString();
            string data2 = dateTimePicker2.Value.ToShortDateString();
            //label2.Text = "SELECT * FROM PhieuBanHang WHERE Ngaytao BETWEEN " + data1 + " AND " + data2;
            string ConnectionString = @"Data Source=.;Initial Catalog=QuanlySinhvien;Integrated Security=True";
            var data = new List<PhieuBanHang.Library.PhieuBanHang>();
            
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM PhieuBanHang WHERE Ngaytao BETWEEN '" + data1 + "' AND '" + data2 + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new PhieuBanHang.Library.PhieuBanHang
                        {
                            MaHD = Convert.ToString(reader["MaHD"]),
                            Nhanvien = Convert.ToString(reader["Nhanvien"]),
                            Ngaytao = Convert.ToDateTime(reader["Ngaytao"]),
                            Tongtien = Convert.ToInt32(reader["Tongtien"]),
                            Ghichu = Convert.ToString(reader["Ghichu"]),
                            TongHangHoa1N = Convert.ToInt32(reader["TongHangHoa1N"])
                        });
                       

                    }
                    phieuBanHangBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phieuBanHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
