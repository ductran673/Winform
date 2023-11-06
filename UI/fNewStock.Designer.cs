namespace UI
{
    partial class fNewStock
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
            button1 = new Button();
            button2 = new Button();
            rStockAddress = new RichTextBox();
            label5 = new Label();
            txtStockname = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(179, 298);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 0;
            button1.Text = "Lưu ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 298);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 1;
            button2.Text = "Đóng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rStockAddress
            // 
            rStockAddress.Location = new Point(128, 72);
            rStockAddress.Name = "rStockAddress";
            rStockAddress.Size = new Size(411, 175);
            rStockAddress.TabIndex = 22;
            rStockAddress.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 72);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 24;
            label5.Text = "Địa chỉ";
            // 
            // txtStockname
            // 
            txtStockname.Location = new Point(128, 28);
            txtStockname.Name = "txtStockname";
            txtStockname.Size = new Size(411, 27);
            txtStockname.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 16;
            label1.Text = "Tên Kho";
            // 
            // fNewStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 388);
            ControlBox = false;
            Controls.Add(rStockAddress);
            Controls.Add(label5);
            Controls.Add(txtStockname);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "fNewStock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập thông tin kho";
            FormClosing += fNewStock_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox rStockAddress;
        private Label label5;
        private TextBox txtStockname;
        private Label label1;
        private ToolTip toolTip1;
    }
}