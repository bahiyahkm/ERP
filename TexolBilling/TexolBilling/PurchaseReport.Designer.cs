namespace TexolBilling
{
    partial class PurchaseReport
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.FromDateP = new System.Windows.Forms.Label();
            this.BtnShowP = new System.Windows.Forms.Button();
            this.ToDateP = new System.Windows.Forms.Label();
            this.dgvPurchaseReport = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTAmount = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(115, 39);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(408, 39);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // FromDateP
            // 
            this.FromDateP.AutoSize = true;
            this.FromDateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromDateP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateP.Location = new System.Drawing.Point(40, 44);
            this.FromDateP.Name = "FromDateP";
            this.FromDateP.Size = new System.Drawing.Size(69, 15);
            this.FromDateP.TabIndex = 2;
            this.FromDateP.Text = "From Date:";
            // 
            // BtnShowP
            // 
            this.BtnShowP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnShowP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowP.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowP.Location = new System.Drawing.Point(623, 36);
            this.BtnShowP.Name = "BtnShowP";
            this.BtnShowP.Size = new System.Drawing.Size(75, 23);
            this.BtnShowP.TabIndex = 3;
            this.BtnShowP.Text = "Show";
            this.BtnShowP.UseVisualStyleBackColor = false;
            this.BtnShowP.Click += new System.EventHandler(this.BtnShowP_Click);
            // 
            // ToDateP
            // 
            this.ToDateP.AutoSize = true;
            this.ToDateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDateP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateP.Location = new System.Drawing.Point(345, 44);
            this.ToDateP.Name = "ToDateP";
            this.ToDateP.Size = new System.Drawing.Size(53, 15);
            this.ToDateP.TabIndex = 4;
            this.ToDateP.Text = "To Date:";
            // 
            // dgvPurchaseReport
            // 
            this.dgvPurchaseReport.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseReport.Location = new System.Drawing.Point(43, 65);
            this.dgvPurchaseReport.Name = "dgvPurchaseReport";
            this.dgvPurchaseReport.Size = new System.Drawing.Size(655, 286);
            this.dgvPurchaseReport.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(603, 357);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TotalAmount:";
            // 
            // LblTAmount
            // 
            this.LblTAmount.AutoSize = true;
            this.LblTAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTAmount.Location = new System.Drawing.Point(457, 362);
            this.LblTAmount.Name = "LblTAmount";
            this.LblTAmount.Size = new System.Drawing.Size(14, 15);
            this.LblTAmount.TabIndex = 8;
            this.LblTAmount.Text = "0";
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(522, 357);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 9;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(763, 392);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.LblTAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvPurchaseReport);
            this.Controls.Add(this.ToDateP);
            this.Controls.Add(this.BtnShowP);
            this.Controls.Add(this.FromDateP);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "PurchaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label FromDateP;
        private System.Windows.Forms.Button BtnShowP;
        private System.Windows.Forms.Label ToDateP;
        private System.Windows.Forms.DataGridView dgvPurchaseReport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTAmount;
        private System.Windows.Forms.Button BtnExport;
    }
}