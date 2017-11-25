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
using HangHoa.Library;
using HangHoa.Repository;
namespace HangHoaForm
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
            var data = new List<HangHoa.Library.HangHoa>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM HangHoa";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new HangHoa.Library.HangHoa
                        {
                            HanghoaId = Convert.ToString(reader["HanghoaId"]),
                            TenHanghoa = Convert.ToString(reader["TenHanghoa"]),
                            GiaBan = Convert.ToInt32(reader["GiaBan"]),
                            Mota = Convert.ToString(reader["Mota"]),
                            SoLuongTonKho = Convert.ToInt32(reader["SoLuongTonKho"]),
                            NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"])
                        });
                    }
                    hangHoaBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var cur = this.hangHoaBindingSource.Current as HangHoa.Library.HangHoa;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId))
            {
                using(var cmd = new HangHoaDeleteRepository())
                {
                    cmd.hangHoaId = cur.HanghoaId;
                    cmd.Execute();
                }

            }

        }
    }
}
