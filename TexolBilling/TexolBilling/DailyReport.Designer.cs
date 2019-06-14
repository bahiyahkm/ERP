namespace TexolBilling
{
    partial class DailyReport
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
            this.ToDateS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalSale = new System.Windows.Forms.Label();
            this.LblTotalPurchase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToDateS
            // 
            this.ToDateS.AutoSize = true;
            this.ToDateS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDateS.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateS.Location = new System.Drawing.Point(59, 222);
            this.ToDateS.Name = "ToDateS";
            this.ToDateS.Size = new System.Drawing.Size(196, 50);
            this.ToDateS.TabIndex = 4;
            this.ToDateS.Text = "TotalSales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "TotalPurchase:";
            // 
            // LblTotalSale
            // 
            this.LblTotalSale.AutoSize = true;
            this.LblTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSale.Location = new System.Drawing.Point(291, 222);
            this.LblTotalSale.Name = "LblTotalSale";
            this.LblTotalSale.Size = new System.Drawing.Size(0, 42);
            this.LblTotalSale.TabIndex = 7;
            // 
            // LblTotalPurchase
            // 
            this.LblTotalPurchase.AutoSize = true;
            this.LblTotalPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPurchase.Location = new System.Drawing.Point(324, 128);
            this.LblTotalPurchase.Name = "LblTotalPurchase";
            this.LblTotalPurchase.Size = new System.Drawing.Size(0, 42);
            this.LblTotalPurchase.TabIndex = 6;
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotalSale);
            this.Controls.Add(this.LblTotalPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDateS);
            this.Name = "DailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyReport";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label ToDateS;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblTotalSale;
        public System.Windows.Forms.Label LblTotalPurchase;
    }
}