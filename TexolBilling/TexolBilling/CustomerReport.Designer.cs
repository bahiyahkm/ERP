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
            this.BtnShowCust = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerReport
            // 
            this.dgvCustomerReport.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvCustomerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerReport.Location = new System.Drawing.Point(22, 113);
            this.dgvCustomerReport.Name = "dgvCustomerReport";
            this.dgvCustomerReport.Size = new System.Drawing.Size(747, 237);
            this.dgvCustomerReport.TabIndex = 16;
            // 
            // BtnShowCust
            // 
            this.BtnShowCust.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnShowCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowCust.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCust.Location = new System.Drawing.Point(22, 82);
            this.BtnShowCust.Name = "BtnShowCust";
            this.BtnShowCust.Size = new System.Drawing.Size(168, 25);
            this.BtnShowCust.TabIndex = 13;
            this.BtnShowCust.Text = "Show Customer Details";
            this.BtnShowCust.UseVisualStyleBackColor = false;
            this.BtnShowCust.Click += new System.EventHandler(this.BtnShowCust_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(646, 356);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(69, 31);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(569, 356);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(61, 31);
            this.BtnExport.TabIndex = 18;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(773, 391);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvCustomerReport);
            this.Controls.Add(this.BtnShowCust);
            this.Name = "CustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerReport;
        private System.Windows.Forms.Button BtnShowCust;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExport;
    }
}