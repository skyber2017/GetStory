using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NhaCungCapForm
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
            var data = new List<NhaCungCap.Library.NhaCungCap>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhaCungCap";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new NhaCungCap.Library.NhaCungCap {
                            NhacungcapId = Convert.ToString(reader["NhacungcapId"]),
                            Ten = Convert.ToString(reader["Ten"]),
                            HangHoaCungCap = Convert.ToString(reader["HangHoaCungCap"]),
                            SDT = Convert.ToString(reader["SDT"]),
                            Diachi = Convert.ToString(reader["Diachi"]),
                            NhomhanghoaId = Convert.ToString(reader["NhomhanghoaId"])
                        });
                    }
                    nhaCungCapBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }



        }
    }
}
