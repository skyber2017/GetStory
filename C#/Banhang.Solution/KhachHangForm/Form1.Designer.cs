namespace KhachHangForm
{
    partial class Form1
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
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label khachhangIdLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tenlotLabel;
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.khachhangIdTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tenlotTextBox = new System.Windows.Forms.TextBox();
            this.khachhangIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            diachiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            khachhangIdLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tenlotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(16, 221);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(43, 13);
            diachiLabel.TabIndex = 13;
            diachiLabel.Text = "Địa chỉ:";
            diachiLabel.Click += new System.EventHandler(this.diachiLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(16, 195);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(16, 163);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 17;
            gioitinhLabel.Text = "Giới tính:";
            gioitinhLabel.Click += new System.EventHandler(this.gioitinhLabel_Click);
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(16, 51);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(24, 13);
            hoLabel.TabIndex = 19;
            hoLabel.Text = "Họ:";
            hoLabel.Click += new System.EventHandler(this.hoLabel_Click);
            // 
            // khachhangIdLabel
            // 
            khachhangIdLabel.AutoSize = true;
            khachhangIdLabel.Location = new System.Drawing.Point(16, 25);
            khachhangIdLabel.Name = "khachhangIdLabel";
            khachhangIdLabel.Size = new System.Drawing.Size(85, 13);
            khachhangIdLabel.TabIndex = 21;
            khachhangIdLabel.Text = "Mã khách hàng:";
            khachhangIdLabel.Click += new System.EventHandler(this.khachhangIdLabel_Click);
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(16, 137);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(73, 13);
            sDTLabel.TabIndex = 23;
            sDTLabel.Text = "Số điện thọai:";
            sDTLabel.Click += new System.EventHandler(this.sDTLabel_Click);
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(16, 109);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 25;
            tenLabel.Text = "Tên:";
            tenLabel.Click += new System.EventHandler(this.tenLabel_Click);
            // 
            // tenlotLabel
            // 
            tenlotLabel.AutoSize = true;
            tenlotLabel.Location = new System.Drawing.Point(16, 79);
            tenlotLabel.Name = "tenlotLabel";
            tenlotLabel.Size = new System.Drawing.Size(43, 13);
            tenlotLabel.TabIndex = 27;
            tenlotLabel.Text = "Tên lót:";
            tenlotLabel.Click += new System.EventHandler(this.tenlotLabel_Click);
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
            this.btnLoad.Location = new System.Drawing.Point(669, 205);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khachhangIdDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenlotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(KhachHang.Library.KhachHang);
            this.khachHangBindingSource.CurrentChanged += new System.EventHandler(this.khachHangBindingSource_CurrentChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(diachiLabel);
            this.groupBox1.Controls.Add(this.diachiTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhTextBox);
            this.groupBox1.Controls.Add(hoLabel);
            this.groupBox1.Controls.Add(this.hoTextBox);
            this.groupBox1.Controls.Add(khachhangIdLabel);
            this.groupBox1.Controls.Add(this.khachhangIdTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Controls.Add(tenlotLabel);
            this.groupBox1.Controls.Add(this.tenlotTextBox);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 29;
            this.button1.Text = "Phiếu mua hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(107, 218);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(166, 20);
            this.diachiTextBox.TabIndex = 14;
            this.diachiTextBox.TextChanged += new System.EventHandler(this.diachiTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(107, 192);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(166, 20);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Gioitinh", true));
            this.gioitinhTextBox.Location = new System.Drawing.Point(107, 160);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(166, 20);
            this.gioitinhTextBox.TabIndex = 18;
            this.gioitinhTextBox.TextChanged += new System.EventHandler(this.gioitinhTextBox_TextChanged);
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(107, 48);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(166, 20);
            this.hoTextBox.TabIndex = 20;
            this.hoTextBox.TextChanged += new System.EventHandler(this.hoTextBox_TextChanged);
            // 
            // khachhangIdTextBox
            // 
            this.khachhangIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "KhachhangId", true));
            this.khachhangIdTextBox.Location = new System.Drawing.Point(107, 22);
            this.khachhangIdTextBox.Name = "khachhangIdTextBox";
            this.khachhangIdTextBox.Size = new System.Drawing.Size(166, 20);
            this.khachhangIdTextBox.TabIndex = 22;
            this.khachhangIdTextBox.TextChanged += new System.EventHandler(this.khachhangIdTextBox_TextChanged);
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(107, 134);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(166, 20);
            this.sDTTextBox.TabIndex = 24;
            this.sDTTextBox.TextChanged += new System.EventHandler(this.sDTTextBox_TextChanged);
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(107, 106);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(166, 20);
            this.tenTextBox.TabIndex = 26;
            this.tenTextBox.TextChanged += new System.EventHandler(this.tenTextBox_TextChanged);
            // 
            // tenlotTextBox
            // 
            this.tenlotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Tenlot", true));
            this.tenlotTextBox.Location = new System.Drawing.Point(107, 76);
            this.tenlotTextBox.Name = "tenlotTextBox";
            this.tenlotTextBox.Size = new System.Drawing.Size(166, 20);
            this.tenlotTextBox.TabIndex = 28;
            this.tenlotTextBox.TextChanged += new System.EventHandler(this.tenlotTextBox_TextChanged);
            // 
            // khachhangIdDataGridViewTextBoxColumn
            // 
            this.khachhangIdDataGridViewTextBoxColumn.DataPropertyName = "KhachhangId";
            this.khachhangIdDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.khachhangIdDataGridViewTextBoxColumn.Name = "khachhangIdDataGridViewTextBoxColumn";
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Họ";
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            // 
            // tenlotDataGridViewTextBoxColumn
            // 
            this.tenlotDataGridViewTextBoxColumn.DataPropertyName = "Tenlot";
            this.tenlotDataGridViewTextBoxColumn.HeaderText = "Tên lót";
            this.tenlotDataGridViewTextBoxColumn.Name = "tenlotDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thọai";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox gioitinhTextBox;
        private System.Windows.Forms.TextBox hoTextBox;
        private System.Windows.Forms.TextBox khachhangIdTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox tenlotTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhangIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
    }
}

