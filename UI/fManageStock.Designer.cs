namespace UI
{
    partial class fManageStock
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnThemKho = new Button();
            cbStock = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            IDKho = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            StockAddress = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            dataGridView2 = new DataGridView();
            lbsoluongkho = new Label();
            toolTip1 = new ToolTip(components);
            MaKho = new DataGridViewTextBoxColumn();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            MoTaSP = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHO HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThemKho
            // 
            btnThemKho.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemKho.Location = new Point(703, 51);
            btnThemKho.Name = "btnThemKho";
            btnThemKho.Size = new Size(91, 29);
            btnThemKho.TabIndex = 1;
            btnThemKho.Text = "Thêm kho hàng";
            btnThemKho.UseVisualStyleBackColor = true;
            btnThemKho.Click += btnThemKho_Click;
            // 
            // cbStock
            // 
            cbStock.FormattingEnabled = true;
            cbStock.Location = new Point(454, 52);
            cbStock.Name = "cbStock";
            cbStock.Size = new Size(243, 28);
            cbStock.TabIndex = 2;
            cbStock.SelectedIndexChanged += cbStock_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn kho :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDKho, StockName, StockAddress, Edit, Delete });
            dataGridView1.Location = new Point(0, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(611, 439);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDKho
            // 
            IDKho.DataPropertyName = "StockID";
            IDKho.HeaderText = "Mã Kho";
            IDKho.MinimumWidth = 6;
            IDKho.Name = "IDKho";
            IDKho.Width = 89;
            // 
            // StockName
            // 
            StockName.DataPropertyName = "Name";
            StockName.HeaderText = "Tên Kho";
            StockName.MinimumWidth = 6;
            StockName.Name = "StockName";
            StockName.Width = 91;
            // 
            // StockAddress
            // 
            StockAddress.DataPropertyName = "Address";
            StockAddress.HeaderText = "Địa chỉ";
            StockAddress.MinimumWidth = 6;
            StockAddress.Name = "StockAddress";
            StockAddress.Width = 84;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { MaKho, MaSP, TenSP, MoTaSP });
            dataGridView2.Location = new Point(616, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(610, 439);
            dataGridView2.TabIndex = 5;
            // 
            // lbsoluongkho
            // 
            lbsoluongkho.AutoSize = true;
            lbsoluongkho.Location = new Point(12, 60);
            lbsoluongkho.Name = "lbsoluongkho";
            lbsoluongkho.Size = new Size(108, 20);
            lbsoluongkho.TabIndex = 6;
            lbsoluongkho.Text = "Số lượng kho : ";
            // 
            // MaKho
            // 
            MaKho.DataPropertyName = "StockID";
            MaKho.HeaderText = "Mã Kho";
            MaKho.MinimumWidth = 6;
            MaKho.Name = "MaKho";
            MaKho.Width = 125;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "ProductID";
            MaSP.HeaderText = "Mã Sản Phẩm";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "Name";
            TenSP.HeaderText = "Tên Sản Phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 125;
            // 
            // MoTaSP
            // 
            MoTaSP.DataPropertyName = "Description";
            MoTaSP.HeaderText = "Mô Tả Sản Phẩm";
            MoTaSP.MinimumWidth = 6;
            MoTaSP.Name = "MoTaSP";
            MoTaSP.Width = 125;
            // 
            // fManageStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1226, 532);
            Controls.Add(lbsoluongkho);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(cbStock);
            Controls.Add(btnThemKho);
            Controls.Add(label1);
            Name = "fManageStock";
            Text = "Quản lý kho hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fManageStock_Activated;
            Load += fManageStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThemKho;
        private ComboBox cbStock;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lbsoluongkho;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn IDKho;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn StockAddress;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn MaKho;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn MoTaSP;
    }
}
