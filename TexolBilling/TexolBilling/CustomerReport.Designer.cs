namespace TexolBilling
{
    partial class CustomerReport
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
            this.dgvCustomerReport = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.ToDateCust = new System.Windows.Forms.Label();
            this.BtnShowCust = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.FromDateCust = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerReport
            // 
            this.dgvCustomerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerReport.Location = new System.Drawing.Point(22, 113);
            this.dgvCustomerReport.Name = "dgvCustomerReport";
            this.dgvCustomerReport.Size = new System.Drawing.Size(747, 237);
            this.dgvCustomerReport.TabIndex = 16;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(418, 38);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 15;
            // 
            // ToDateCust
            // 
            this.ToDateCust.AutoSize = true;
            this.ToDateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateCust.Location = new System.Drawing.Point(355, 43);
            this.ToDateCust.Name = "ToDateCust";
            this.ToDateCust.Size = new System.Drawing.Size(57, 13);
            this.ToDateCust.TabIndex = 14;
            this.ToDateCust.Text = "To Date:";
            // 
            // BtnShowCust
            // 
            this.BtnShowCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCust.Location = new System.Drawing.Point(651, 38);
            this.BtnShowCust.Name = "BtnShowCust";
            this.BtnShowCust.Size = new System.Drawing.Size(67, 23);
            this.BtnShowCust.TabIndex = 13;
            this.BtnShowCust.Text = "Show";
            this.BtnShowCust.UseVisualStyleBackColor = true;
            this.BtnShowCust.Click += new System.EventHandler(this.BtnShowCust_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(106, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 12;
            // 
            // FromDateCust
            // 
            this.FromDateCust.AutoSize = true;
            this.FromDateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateCust.Location = new System.Drawing.Point(31, 43);
            this.FromDateCust.Name = "FromDateCust";
            this.FromDateCust.Size = new System.Drawing.Size(69, 13);
            this.FromDateCust.TabIndex = 11;
            this.FromDateCust.Text = "From Date:";
            this.FromDateCust.Click += new System.EventHandler(this.FromDateCust_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(651, 356);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(569, 356);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(67, 23);
            this.BtnExport.TabIndex = 18;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 387);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvCustomerReport);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.ToDateCust);
            this.Controls.Add(this.BtnShowCust);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.FromDateCust);
            this.Name = "CustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerReport;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label ToDateCust;
        private System.Windows.Forms.Button BtnShowCust;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label FromDateCust;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExport;
    }
}