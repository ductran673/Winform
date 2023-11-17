namespace QuanLyKho.View
{
    partial class ReportListProduct
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
            cbProducts = new ComboBox();
            SuspendLayout();
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(555, 27);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(151, 28);
            cbProducts.TabIndex = 0;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // ReportListProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbProducts);
            Name = "ReportListProduct";
            Text = "Báo Cáo Danh Sách Sản Phẩm";
            Load += ReportListProduct_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbProducts;
    }
}