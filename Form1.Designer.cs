namespace WinForms1_10_2026
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpInput = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnChooseImage = new Button();
            picAvatar = new PictureBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            cboCategory = new ComboBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            panel1 = new Panel();
            dgvProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exToolStripMenuItem
            // 
            exToolStripMenuItem.Name = "exToolStripMenuItem";
            exToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exToolStripMenuItem.Size = new Size(215, 26);
            exToolStripMenuItem.Text = "Export CSV";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(215, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(grpInput, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(932, 525);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(label6);
            grpInput.Controls.Add(label5);
            grpInput.Controls.Add(label4);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(label2);
            grpInput.Controls.Add(label1);
            grpInput.Controls.Add(btnChooseImage);
            grpInput.Controls.Add(picAvatar);
            grpInput.Controls.Add(txtQuantity);
            grpInput.Controls.Add(txtUnitPrice);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(txtProductName);
            grpInput.Controls.Add(txtProductId);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(11, 11);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(314, 503);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 238);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 12;
            label6.Text = "Ảnh SP:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(6, 203);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 157);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 9;
            label3.Text = "Danh mục:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã SP:";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(108, 446);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(94, 29);
            btnChooseImage.TabIndex = 6;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(6, 261);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(302, 179);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 5;
            picAvatar.TabStop = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(84, 196);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(224, 27);
            txtQuantity.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Location = new Point(77, 150);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(231, 27);
            txtUnitPrice.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(91, 104);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(217, 28);
            cboCategory.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(65, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(243, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductId.Location = new Point(65, 26);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(243, 27);
            txtProductId.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProducts);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(331, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 503);
            panel1.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvProducts.Location = new Point(13, 66);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(574, 419);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductId";
            Column1.HeaderText = "Mã SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "Tên Sản Phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "CategoryName";
            Column3.HeaderText = "Danh Mục";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "NO";
            Column4.DefaultCellStyle = dataGridViewCellStyle1;
            Column4.HeaderText = "Đơn Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số Lượng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 90;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(156, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(431, 27);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 29);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 0;
            label7.Text = "Tìm kiếm (Tên/Mã):";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(932, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(145, 20);
            lblStatusCount.Text = "Tổng số sản phẩm: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpInput;
        private ComboBox cboCategory;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Button btnChooseImage;
        private PictureBox picAvatar;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusCount;
    }
}
