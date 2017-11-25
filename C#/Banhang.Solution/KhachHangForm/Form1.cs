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

namespace KhachHangForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuanlySinhvien;Integrated Security=True";
            var data = new List<KhachHang.Library.KhachHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM KhachHang";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new KhachHang.Library.KhachHang
                        {
                            KhachhangId = Convert.ToString(reader["KhachhangId"]),
                            Ho = Convert.ToString(reader["Ho"]),
                            Tenlot = Convert.ToString(reader["Tenlot"]),
                            Ten = Convert.ToString(reader["Ten"]),
                            Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                            Email = Convert.ToString(reader["Email"]),
                            SDT = Convert.ToString(reader["SDT"]),
                            Diachi = Convert.ToString(reader["Diachi"])
                        });
                    }
                    khachHangBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new PhieuMuaHangForm.Form1();
            f.Show();
        }
    }
}
