namespace UI
{
    partial class fEditProduct
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btClose = new Button();
            btSave = new Button();
            rDescription = new RichTextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            mPrice = new MaskedTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 144);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 15;
            label3.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 71);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 14;
            label2.Text = "Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 67);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 13;
            label1.Text = "Tên sản phẩm";
            // 
            // btClose
            // 
            btClose.Location = new Point(522, 342);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 12;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(180, 342);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 11;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(180, 144);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(436, 168);
            rDescription.TabIndex = 10;
            rDescription.Text = "";
            rDescription.Validating += rDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            txtName.Validating += txtName_Validating;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(491, 64);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 27);
            mPrice.TabIndex = 16;
            mPrice.Validating += mPrice_Validating;
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(rDescription);
            Controls.Add(txtName);
            Name = "fEditProduct";
            Text = "Sửa đổi sản phẩm";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btClose;
        private Button btSave;
        private RichTextBox rDescription;
        private TextBox txtName;
        private ToolTip toolTip1;
        private MaskedTextBox mPrice;
    }
}