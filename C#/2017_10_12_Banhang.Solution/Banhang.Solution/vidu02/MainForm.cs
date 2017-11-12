using Banhang.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu02
{
    public partial class MainForm : Form
    {
        string fileName = null;
        List<Sinhvien> data = new List<Sinhvien>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fileName == null)
            {
                using (var dialog = new SaveFileDialog())
                {
                    var result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.fileName = dialog.FileName;
                    }
                }
            }
            using (var sw = new StreamWriter(this.fileName))
            {
                var result = Newtonsoft.Json.JsonConvert.SerializeObject(this.data);
                sw.Write(result);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.sinhvienBindingSource.DataSource = this.data;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var dialog = new OpenFileDialog())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                    this.fileName = dialog.FileName;
            }
            using(var sr = new StreamReader(this.fileName))
            {
                var result = sr.ReadToEnd();
                this.data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Sinhvien>>(result);
                this.sinhvienBindingSource.DataSource = typeof(Sinhvien);
                this.sinhvienBindingSource.DataSource = this.data;
            }
        }
    }
}
