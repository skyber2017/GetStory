namespace NguyenHoangDuy
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
            System.Windows.Forms.Label hinhanhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label holotLabel;
            System.Windows.Forms.Label masoLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label tenLabel;
            this.hocsinhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hocsinhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hinhanhPictureBox = new System.Windows.Forms.PictureBox();
            this.hocsinhDataGridView = new System.Windows.Forms.DataGridView();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.masoTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.hocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gioitinhStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            hinhanhLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            holotLabel = new System.Windows.Forms.Label();
            masoLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingNavigator)).BeginInit();
            this.hocsinhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hinhanhLabel
            // 
            hinhanhLabel.AutoSize = true;
            hinhanhLabel.Location = new System.Drawing.Point(364, 49);
            hinhanhLabel.Name = "hinhanhLabel";
            hinhanhLabel.Size = new System.Drawing.Size(53, 13);
            hinhanhLabel.TabIndex = 5;
            hinhanhLabel.Text = "Hình ảnh:";
            // 
            // hocsinhBindingNavigator
            // 
            this.hocsinhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hocsinhBindingNavigator.BindingSource = this.hocsinhBindingSource;
            this.hocsinhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hocsinhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hocsinhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hocsinhBindingNavigatorSaveItem});
            this.hocsinhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hocsinhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hocsinhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hocsinhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hocsinhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hocsinhBindingNavigator.Name = "hocsinhBindingNavigator";
            this.hocsinhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hocsinhBindingNavigator.Size = new System.Drawing.Size(694, 25);
            this.hocsinhBindingNavigator.TabIndex = 0;
            this.hocsinhBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hocsinhBindingNavigatorSaveItem
            // 
            this.hocsinhBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hocsinhBindingNavigatorSaveItem.Enabled = false;
            this.hocsinhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hocsinhBindingNavigatorSaveItem.Image")));
            this.hocsinhBindingNavigatorSaveItem.Name = "hocsinhBindingNavigatorSaveItem";
            this.hocsinhBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hocsinhBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // hinhanhPictureBox
            // 
            this.hinhanhPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hocsinhBindingSource, "Hinhanh", true));
            this.hinhanhPictureBox.Location = new System.Drawing.Point(427, 49);
            this.hinhanhPictureBox.Name = "hinhanhPictureBox";
            this.hinhanhPictureBox.Size = new System.Drawing.Size(200, 50);
            this.hinhanhPictureBox.TabIndex = 6;
            this.hinhanhPictureBox.TabStop = false;
            // 
            // hocsinhDataGridView
            // 
            this.hocsinhDataGridView.AutoGenerateColumns = false;
            this.hocsinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hocsinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masoDataGridViewTextBoxColumn,
            this.holotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.gioitinhStringDataGridViewTextBoxColumn,
            this.hinhanhDataGridViewImageColumn});
            this.hocsinhDataGridView.DataSource = this.hocsinhBindingSource;
            this.hocsinhDataGridView.Location = new System.Drawing.Point(12, 255);
            this.hocsinhDataGridView.Name = "hocsinhDataGridView";
            this.hocsinhDataGridView.Size = new System.Drawing.Size(648, 180);
            this.hocsinhDataGridView.TabIndex = 15;
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(9, 129);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 15;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hocsinhBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(72, 124);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(200, 24);
            this.gioitinhCheckBox.TabIndex = 16;
            this.gioitinhCheckBox.Text = "Nữ";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(8, 68);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(38, 13);
            holotLabel.TabIndex = 21;
            holotLabel.Text = "Họ lót:";
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hocsinhBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(71, 65);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(200, 20);
            this.holotTextBox.TabIndex = 22;
            // 
            // masoLabel
            // 
            masoLabel.AutoSize = true;
            masoLabel.Location = new System.Drawing.Point(8, 40);
            masoLabel.Name = "masoLabel";
            masoLabel.Size = new System.Drawing.Size(39, 13);
            masoLabel.TabIndex = 23;
            masoLabel.Text = "Mã số:";
            // 
            // masoTextBox
            // 
            this.masoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hocsinhBindingSource, "Maso", true));
            this.masoTextBox.Location = new System.Drawing.Point(71, 37);
            this.masoTextBox.Name = "masoTextBox";
            this.masoTextBox.Size = new System.Drawing.Size(200, 20);
            this.masoTextBox.TabIndex = 24;
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(8, 162);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 25;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hocsinhBindingSource, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(71, 158);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 26;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(9, 97);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 27;
            tenLabel.Text = "Tên:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hocsinhBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(72, 94);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenTextBox.TabIndex = 28;
            // 
            // hocsinhBindingSource
            // 
            this.hocsinhBindingSource.DataSource = typeof(NguyenHoangDuy.hocsinh);
            // 
            // masoDataGridViewTextBoxColumn
            // 
            this.masoDataGridViewTextBoxColumn.DataPropertyName = "Maso";
            this.masoDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.masoDataGridViewTextBoxColumn.Name = "masoDataGridViewTextBoxColumn";
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
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            // 
            // gioitinhStringDataGridViewTextBoxColumn
            // 
            this.gioitinhStringDataGridViewTextBoxColumn.DataPropertyName = "GioitinhString";
            this.gioitinhStringDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhStringDataGridViewTextBoxColumn.Name = "gioitinhStringDataGridViewTextBoxColumn";
            this.gioitinhStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhanhDataGridViewImageColumn
            // 
            this.hinhanhDataGridViewImageColumn.DataPropertyName = "Hinhanh";
            this.hinhanhDataGridViewImageColumn.HeaderText = "Hình ảnh";
            this.hinhanhDataGridViewImageColumn.Name = "hinhanhDataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(this.gioitinhCheckBox);
            this.Controls.Add(holotLabel);
            this.Controls.Add(this.holotTextBox);
            this.Controls.Add(masoLabel);
            this.Controls.Add(this.masoTextBox);
            this.Controls.Add(ngaysinhLabel);
            this.Controls.Add(this.ngaysinhDateTimePicker);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.hocsinhDataGridView);
            this.Controls.Add(hinhanhLabel);
            this.Controls.Add(this.hinhanhPictureBox);
            this.Controls.Add(this.hocsinhBindingNavigator);
            this.Name = "Form1";
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingNavigator)).EndInit();
            this.hocsinhBindingNavigator.ResumeLayout(false);
            this.hocsinhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hocsinhBindingSource;
        private System.Windows.Forms.BindingNavigator hocsinhBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hocsinhBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox hinhanhPictureBox;
        private System.Windows.Forms.DataGridView hocsinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhanhDataGridViewImageColumn;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.TextBox masoTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.TextBox tenTextBox;
    }
}

