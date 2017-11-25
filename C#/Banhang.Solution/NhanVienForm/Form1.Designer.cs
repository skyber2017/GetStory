namespace NhanVienForm
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label holotLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label ngayVaolamLabel;
            System.Windows.Forms.Label nhanvienIdLabel;
            System.Windows.Forms.Label tenLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngaysinhTextBox = new System.Windows.Forms.TextBox();
            this.ngayVaolamTextBox = new System.Windows.Forms.TextBox();
            this.nhanvienIdTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhanvienIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaolamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            holotLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ngayVaolamLabel = new System.Windows.Forms.Label();
            nhanvienIdLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(37, 44);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(38, 13);
            holotLabel.TabIndex = 0;
            holotLabel.Text = "Họ lót:";
            holotLabel.Click += new System.EventHandler(this.holotLabel_Click);
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(37, 70);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 2;
            ngaysinhLabel.Text = "Ngày sinh:";
            ngaysinhLabel.Click += new System.EventHandler(this.ngaysinhLabel_Click);
            // 
            // ngayVaolamLabel
            // 
            ngayVaolamLabel.AutoSize = true;
            ngayVaolamLabel.Location = new System.Drawing.Point(37, 96);
            ngayVaolamLabel.Name = "ngayVaolamLabel";
            ngayVaolamLabel.Size = new System.Drawing.Size(75, 13);
            ngayVaolamLabel.TabIndex = 4;
            ngayVaolamLabel.Text = "Ngày vào làm:";
            ngayVaolamLabel.Click += new System.EventHandler(this.ngayVaolamLabel_Click);
            // 
            // nhanvienIdLabel
            // 
            nhanvienIdLabel.AutoSize = true;
            nhanvienIdLabel.Location = new System.Drawing.Point(37, 122);
            nhanvienIdLabel.Name = "nhanvienIdLabel";
            nhanvienIdLabel.Size = new System.Drawing.Size(75, 13);
            nhanvienIdLabel.TabIndex = 6;
            nhanvienIdLabel.Text = "Mã nhân viên:";
            nhanvienIdLabel.Click += new System.EventHandler(this.nhanvienIdLabel_Click);
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(37, 148);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(79, 13);
            tenLabel.TabIndex = 8;
            tenLabel.Text = "Tên nhân viên:";
            tenLabel.Click += new System.EventHandler(this.tenLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(holotLabel);
            this.groupBox1.Controls.Add(this.holotTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhTextBox);
            this.groupBox1.Controls.Add(ngayVaolamLabel);
            this.groupBox1.Controls.Add(this.ngayVaolamTextBox);
            this.groupBox1.Controls.Add(nhanvienIdLabel);
            this.groupBox1.Controls.Add(this.nhanvienIdTextBox);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(427, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 53);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 53);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(628, 179);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(122, 41);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(100, 20);
            this.holotTextBox.TabIndex = 1;
            this.holotTextBox.TextChanged += new System.EventHandler(this.holotTextBox_TextChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(NhanVien.Libary.NhanVien);
            this.nhanVienBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienBindingSource_CurrentChanged);
            // 
            // ngaysinhTextBox
            // 
            this.ngaysinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Ngaysinh", true));
            this.ngaysinhTextBox.Location = new System.Drawing.Point(122, 67);
            this.ngaysinhTextBox.Name = "ngaysinhTextBox";
            this.ngaysinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.ngaysinhTextBox.TabIndex = 3;
            this.ngaysinhTextBox.TextChanged += new System.EventHandler(this.ngaysinhTextBox_TextChanged);
            // 
            // ngayVaolamTextBox
            // 
            this.ngayVaolamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NgayVaolam", true));
            this.ngayVaolamTextBox.Location = new System.Drawing.Point(122, 93);
            this.ngayVaolamTextBox.Name = "ngayVaolamTextBox";
            this.ngayVaolamTextBox.Size = new System.Drawing.Size(100, 20);
            this.ngayVaolamTextBox.TabIndex = 5;
            this.ngayVaolamTextBox.TextChanged += new System.EventHandler(this.ngayVaolamTextBox_TextChanged);
            // 
            // nhanvienIdTextBox
            // 
            this.nhanvienIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NhanvienId", true));
            this.nhanvienIdTextBox.Location = new System.Drawing.Point(122, 119);
            this.nhanvienIdTextBox.Name = "nhanvienIdTextBox";
            this.nhanvienIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhanvienIdTextBox.TabIndex = 7;
            this.nhanvienIdTextBox.TextChanged += new System.EventHandler(this.nhanvienIdTextBox_TextChanged);
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(122, 145);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenTextBox.TabIndex = 9;
            this.tenTextBox.TextChanged += new System.EventHandler(this.tenTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhanvienIdDataGridViewTextBoxColumn,
            this.holotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.ngayVaolamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nhanvienIdDataGridViewTextBoxColumn
            // 
            this.nhanvienIdDataGridViewTextBoxColumn.DataPropertyName = "NhanvienId";
            this.nhanvienIdDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.nhanvienIdDataGridViewTextBoxColumn.Name = "nhanvienIdDataGridViewTextBoxColumn";
            // 
            // holotDataGridViewTextBoxColumn
            // 
            this.holotDataGridViewTextBoxColumn.DataPropertyName = "Holot";
            this.holotDataGridViewTextBoxColumn.HeaderText = "Họ lót";
            this.holotDataGridViewTextBoxColumn.Name = "holotDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // ngayVaolamDataGridViewTextBoxColumn
            // 
            this.ngayVaolamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaolam";
            this.ngayVaolamDataGridViewTextBoxColumn.HeaderText = "Ngày vào làm";
            this.ngayVaolamDataGridViewTextBoxColumn.Name = "ngayVaolamDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Phiếu bán hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhanVien";
            this.Text = "Form nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.TextBox ngaysinhTextBox;
        private System.Windows.Forms.TextBox ngayVaolamTextBox;
        private System.Windows.Forms.TextBox nhanvienIdTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvienIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaolamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

