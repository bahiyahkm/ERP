namespace TexolBilling
{
    partial class VendorReport
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
            this.dgvVendorReport = new System.Windows.Forms.DataGridView();
            this.BtnShowVendor = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendorReport
            // 
            this.dgvVendorReport.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgvVendorReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorReport.Location = new System.Drawing.Point(30, 90);
            this.dgvVendorReport.Name = "dgvVendorReport";
            this.dgvVendorReport.Size = new System.Drawing.Size(747, 237);
            this.dgvVendorReport.TabIndex = 22;
            // 
            // BtnShowVendor
            // 
            this.BtnShowVendor.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnShowVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowVendor.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowVendor.Location = new System.Drawing.Point(30, 60);
            this.BtnShowVendor.Name = "BtnShowVendor";
            this.BtnShowVendor.Size = new System.Drawing.Size(124, 24);
            this.BtnShowVendor.TabIndex = 19;
            this.BtnShowVendor.Text = "Show Vendor Details";
            this.BtnShowVendor.UseVisualStyleBackColor = false;
            this.BtnShowVendor.Click += new System.EventHandler(this.BtnShowVendor_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(676, 342);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(62, 23);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(601, 342);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(59, 23);
            this.BtnExport.TabIndex = 24;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // VendorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(786, 388);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvVendorReport);
            this.Controls.Add(this.BtnShowVendor);
            this.Name = "VendorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorReport";
            this.Load += new System.EventHandler(this.VendorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendorReport;
        private System.Windows.Forms.Button BtnShowVendor;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExport;
    }
}