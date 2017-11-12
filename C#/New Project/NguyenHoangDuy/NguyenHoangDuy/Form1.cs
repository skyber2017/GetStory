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

namespace NguyenHoangDuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //List<hocsinh> data;
            string ConnectionString = @"Data Source=.;Initial Catalog=hocsinh;Integrated Security=True";
            var data = new List<hocsinh>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM hocsinh";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        data.Add(new hocsinh
                        {
                            Maso = Convert.ToInt64(reader["_maso"]),
                            Holot = Convert.ToString(reader["_holot"]),
                            Ten = Convert.ToString(reader["_ten"]),
                            Ngaysinh = Convert.ToDateTime(reader["_ngaysinh"]),
                            Gioitinh = Convert.ToBoolean(reader["_gioitinh"])
                        });
                        
                    }
                    hocsinhBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void ngaysinhDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ngaysinhLabel_Click(object sender, EventArgs e)
        {

        }

        private void masoLabel_Click(object sender, EventArgs e)
        {

        }

        private void gioitinhCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
