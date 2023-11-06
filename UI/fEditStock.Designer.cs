namespace UI
{
    partial class fEditStock
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
            rStockAddress = new RichTextBox();
            label5 = new Label();
            txtStockname = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // rStockAddress
            // 
            rStockAddress.Location = new Point(222, 119);
            rStockAddress.Name = "rStockAddress";
            rStockAddress.Size = new Size(357, 169);
            rStockAddress.TabIndex = 29;
            rStockAddress.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 119);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 30;
            label5.Text = "Địa chỉ";
            // 
            // txtStockname
            // 
            txtStockname.Location = new Point(222, 75);
            txtStockname.Name = "txtStockname";
            txtStockname.Size = new Size(357, 27);
            txtStockname.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 78);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 28;
            label1.Text = "Tên Kho";
            // 
            // button2
            // 
            button2.Location = new Point(403, 339);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "Đóng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(303, 339);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Lưu ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fEditStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rStockAddress);
            Controls.Add(label5);
            Controls.Add(txtStockname);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "fEditStock";
            Text = "Sửa đổi thông tin kho";
            FormClosing += fEditStock_FormClosing;
            Load += fEditStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rStockAddress;
        private Label label5;
        private TextBox txtStockname;
        private Label label1;
        private Button button2;
        private Button button1;
        private ToolTip toolTip1;
    }
}