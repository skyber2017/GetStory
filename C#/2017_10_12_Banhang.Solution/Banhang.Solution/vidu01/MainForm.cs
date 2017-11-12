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
using vidu01Lib;

namespace vidu01
{
    public partial class MainForm : Form
    {
        string fileName = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var hanghoa = new Hanghoa();
            hanghoa.MaHanghoa = "sp001";
            hanghoa.TenHanghoa = "Nước suối";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.fileName = dialog.FileName;
                }
            }
            using (var sr = new StreamReader(this.fileName))
            {
                this.noidungTextBox.Text = sr.ReadToEnd();
            }
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
                sw.Write(this.noidungTextBox.Text);
            }
        }
    }
}
