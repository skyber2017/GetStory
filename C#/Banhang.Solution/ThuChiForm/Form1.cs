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

namespace ThuChiForm
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
            var data = new List<ThuChi.Library.ThuChi>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM ThuChi WHERE Ngay BETWEEN '" + data1 + "' AND '" + data2 + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new ThuChi.Library.ThuChi
                        {
                            Ngay = Convert.ToDateTime(reader["Ngay"]),
                            Thu = Convert.ToInt32(reader["Thu"]),
                            Chi = Convert.ToInt32(reader["Chi"])
                        });


                    }
                    thuChiBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }
    }
}
