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
            dataGridView2 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            NameUnit = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            lbsoluongkho = new Label();
            toolTip1 = new ToolTip(components);
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(25, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(436, 439);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, NameProduct, Description, NameUnit, Quantity });
            dataGridView2.Location = new Point(572, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(605, 439);
            dataGridView2.TabIndex = 5;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.HeaderText = "Mã Sản Phẩm";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 128;
            // 
            // NameProduct
            // 
            NameProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameProduct.HeaderText = "Tên Sản Phẩm";
            NameProduct.MinimumWidth = 6;
            NameProduct.Name = "NameProduct";
            NameProduct.Width = 130;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.HeaderText = "Mô Tả";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 80;
            // 
            // NameUnit
            // 
            NameUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameUnit.HeaderText = "Tên Đơn Vị";
            NameUnit.MinimumWidth = 6;
            NameUnit.Name = "NameUnit";
            NameUnit.Width = 110;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.HeaderText = "Số Lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 101;
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
            // fManageStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 532);
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
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn NameUnit;
        private DataGridViewTextBoxColumn Quantity;
        private Label lbsoluongkho;
        private ToolTip toolTip1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
