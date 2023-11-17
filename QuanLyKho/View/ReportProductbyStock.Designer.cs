namespace QuanLyKho.View
{
    partial class ReportProductbyStock
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
            cbStocks = new ComboBox();
            SuspendLayout();
            // 
            // cbStocks
            // 
            cbStocks.FormattingEnabled = true;
            cbStocks.Location = new Point(561, 22);
            cbStocks.Name = "cbStocks";
            cbStocks.Size = new Size(151, 28);
            cbStocks.TabIndex = 0;
     
            // 
            // ReportProductbyStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbStocks);
            Name = "ReportProductbyStock";
            Text = "Báo Cáo Sản Phẩm Theo Kho";
            Load += ReportProductbyStock_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbStocks;
    }
}