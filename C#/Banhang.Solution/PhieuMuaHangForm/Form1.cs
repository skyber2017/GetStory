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

namespace PhieuMuaHangForm
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
            var data = new List<PhieuMuaHang.Library.PhieuMuaHang>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM PhieuMuaHang WHERE Ngaytao BETWEEN '" + data1 + "' AND '" + data2 + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new PhieuMuaHang.Library.PhieuMuaHang
                        {
                            MaHD = Convert.ToString(reader["MaHD"]),
                            Khachhang = Convert.ToString(reader["Khachhang"]),
                            Ngaytao = Convert.ToDateTime(reader["Ngaytao"]),
                            Tongtien = Convert.ToInt32(reader["Tongtien"]),
                            Ghichu = Convert.ToString(reader["Ghichu"]),
                            SoLuongMua1N = Convert.ToInt32(reader["SoLuongMua1N"])
                        });


                    }
                    phieuMuaHangBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }
    }
}
