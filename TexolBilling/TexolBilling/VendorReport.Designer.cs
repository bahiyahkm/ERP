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
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.ToDateVendor = new System.Windows.Forms.Label();
            this.BtnShowVendor = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.FromDateVendor = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendorReport
            // 
            this.dgvVendorReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorReport.Location = new System.Drawing.Point(30, 90);
            this.dgvVendorReport.Name = "dgvVendorReport";
            this.dgvVendorReport.Size = new System.Drawing.Size(747, 237);
            this.dgvVendorReport.TabIndex = 22;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(422, 25);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 21;
            // 
            // ToDateVendor
            // 
            this.ToDateVendor.AutoSize = true;
            this.ToDateVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateVendor.Location = new System.Drawing.Point(359, 30);
            this.ToDateVendor.Name = "ToDateVendor";
            this.ToDateVendor.Size = new System.Drawing.Size(57, 13);
            this.ToDateVendor.TabIndex = 20;
            this.ToDateVendor.Text = "To Date:";
            // 
            // BtnShowVendor
            // 
            this.BtnShowVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowVendor.Location = new System.Drawing.Point(655, 25);
            this.BtnShowVendor.Name = "BtnShowVendor";
            this.BtnShowVendor.Size = new System.Drawing.Size(67, 23);
            this.BtnShowVendor.TabIndex = 19;
            this.BtnShowVendor.Text = "Show";
            this.BtnShowVendor.UseVisualStyleBackColor = true;
            this.BtnShowVendor.Click += new System.EventHandler(this.BtnShowVendor_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(110, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 18;
            // 
            // FromDateVendor
            // 
            this.FromDateVendor.AutoSize = true;
            this.FromDateVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateVendor.Location = new System.Drawing.Point(35, 30);
            this.FromDateVendor.Name = "FromDateVendor";
            this.FromDateVendor.Size = new System.Drawing.Size(69, 13);
            this.FromDateVendor.TabIndex = 17;
            this.FromDateVendor.Text = "From Date:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(683, 342);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 23);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(601, 342);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(67, 23);
            this.BtnExport.TabIndex = 24;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // VendorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 388);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvVendorReport);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.ToDateVendor);
            this.Controls.Add(this.BtnShowVendor);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.FromDateVendor);
            this.Name = "VendorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendorReport;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label ToDateVendor;
        private System.Windows.Forms.Button BtnShowVendor;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label FromDateVendor;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExport;
    }
}