namespace UI
{
    partial class fNewProduct
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
            txtName = new TextBox();
            rDescription = new RichTextBox();
            btSave = new Button();
            btClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            mPrice = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(172, 153);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(436, 168);
            rDescription.TabIndex = 2;
            rDescription.Text = "";
            rDescription.Validating += rDescription_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(172, 351);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 3;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(514, 351);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 4;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 76);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 80);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 6;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 153);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Mô tả";
            // 
            // mPrice
            // 
            mPrice.Location = new Point(483, 80);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 27);
            mPrice.TabIndex = 8;
            // 
            // fNewProduct
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
            Name = "fNewProduct";
            Text = "Nhập mới sản phẩm";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewProduct_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private RichTextBox rDescription;
        private Button btSave;
        private Button btClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip toolTip1;
        private MaskedTextBox mPrice;
    }
}