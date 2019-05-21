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
            this.dtpFrom.Location = new System.Drawing.Point(105, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(398, 38);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // FromDateP
            // 
            this.FromDateP.AutoSize = true;
            this.FromDateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateP.Location = new System.Drawing.Point(30, 43);
            this.FromDateP.Name = "FromDateP";
            this.FromDateP.Size = new System.Drawing.Size(69, 13);
            this.FromDateP.TabIndex = 2;
            this.FromDateP.Text = "From Date:";
            // 
            // BtnShowP
            // 
            this.BtnShowP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowP.Location = new System.Drawing.Point(637, 38);
            this.BtnShowP.Name = "BtnShowP";
            this.BtnShowP.Size = new System.Drawing.Size(75, 23);
            this.BtnShowP.TabIndex = 3;
            this.BtnShowP.Text = "Show";
            this.BtnShowP.UseVisualStyleBackColor = true;
            this.BtnShowP.Click += new System.EventHandler(this.BtnShowP_Click);
            // 
            // ToDateP
            // 
            this.ToDateP.AutoSize = true;
            this.ToDateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateP.Location = new System.Drawing.Point(335, 43);
            this.ToDateP.Name = "ToDateP";
            this.ToDateP.Size = new System.Drawing.Size(57, 13);
            this.ToDateP.TabIndex = 4;
            this.ToDateP.Text = "To Date:";
            // 
            // dgvPurchaseReport
            // 
            this.dgvPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseReport.Location = new System.Drawing.Point(43, 107);
            this.dgvPurchaseReport.Name = "dgvPurchaseReport";
            this.dgvPurchaseReport.Size = new System.Drawing.Size(684, 244);
            this.dgvPurchaseReport.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(603, 357);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TotalAmount:";
            // 
            // LblTAmount
            // 
            this.LblTAmount.AutoSize = true;
            this.LblTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTAmount.Location = new System.Drawing.Point(457, 362);
            this.LblTAmount.Name = "LblTAmount";
            this.LblTAmount.Size = new System.Drawing.Size(14, 13);
            this.LblTAmount.TabIndex = 8;
            this.LblTAmount.Text = "0";
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(522, 357);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 9;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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