namespace TexolBilling
{
    partial class PurchaseInvoiceReport
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
            this.LblVendorName = new System.Windows.Forms.Label();
            this.LblVendorAddress = new System.Windows.Forms.Label();
            this.LblVendorPhno = new System.Windows.Forms.Label();
            this.LblPurchaseTrNo = new System.Windows.Forms.Label();
            this.LblPurchaseDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblTaxAmount = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVendorName
            // 
            this.LblVendorName.AutoSize = true;
            this.LblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorName.Location = new System.Drawing.Point(44, 61);
            this.LblVendorName.Name = "LblVendorName";
            this.LblVendorName.Size = new System.Drawing.Size(94, 15);
            this.LblVendorName.TabIndex = 0;
            this.LblVendorName.Text = "VendorName:";
            // 
            // LblVendorAddress
            // 
            this.LblVendorAddress.AutoSize = true;
            this.LblVendorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorAddress.Location = new System.Drawing.Point(44, 86);
            this.LblVendorAddress.Name = "LblVendorAddress";
            this.LblVendorAddress.Size = new System.Drawing.Size(62, 15);
            this.LblVendorAddress.TabIndex = 1;
            this.LblVendorAddress.Text = "Address:";
            // 
            // LblVendorPhno
            // 
            this.LblVendorPhno.AutoSize = true;
            this.LblVendorPhno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorPhno.Location = new System.Drawing.Point(44, 112);
            this.LblVendorPhno.Name = "LblVendorPhno";
            this.LblVendorPhno.Size = new System.Drawing.Size(70, 15);
            this.LblVendorPhno.TabIndex = 2;
            this.LblVendorPhno.Text = "PhoneNo:";
            // 
            // LblPurchaseTrNo
            // 
            this.LblPurchaseTrNo.AutoSize = true;
            this.LblPurchaseTrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPurchaseTrNo.Location = new System.Drawing.Point(544, 74);
            this.LblPurchaseTrNo.Name = "LblPurchaseTrNo";
            this.LblPurchaseTrNo.Size = new System.Drawing.Size(164, 15);
            this.LblPurchaseTrNo.TabIndex = 3;
            this.LblPurchaseTrNo.Text = "PurchaseTransactionNo:";
            // 
            // LblPurchaseDate
            // 
            this.LblPurchaseDate.AutoSize = true;
            this.LblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPurchaseDate.Location = new System.Drawing.Point(544, 100);
            this.LblPurchaseDate.Name = "LblPurchaseDate";
            this.LblPurchaseDate.Size = new System.Drawing.Size(101, 15);
            this.LblPurchaseDate.TabIndex = 4;
            this.LblPurchaseDate.Text = "PurchaseDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "TotalAmount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "TaxAmount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "SubTotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Purchase Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(626, 410);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(15, 15);
            this.LblSubTotal.TabIndex = 12;
            this.LblSubTotal.Text = "0";
            // 
            // LblTaxAmount
            // 
            this.LblTaxAmount.AutoSize = true;
            this.LblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxAmount.Location = new System.Drawing.Point(626, 386);
            this.LblTaxAmount.Name = "LblTaxAmount";
            this.LblTaxAmount.Size = new System.Drawing.Size(15, 15);
            this.LblTaxAmount.TabIndex = 11;
            this.LblTaxAmount.Text = "0";
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(626, 363);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(15, 15);
            this.LblTotalAmount.TabIndex = 10;
            this.LblTotalAmount.Text = "0";
            // 
            // PurchaseInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.LblTaxAmount);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPurchaseDate);
            this.Controls.Add(this.LblPurchaseTrNo);
            this.Controls.Add(this.LblVendorPhno);
            this.Controls.Add(this.LblVendorAddress);
            this.Controls.Add(this.LblVendorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PurchaseInvoiceReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label LblVendorName;
        public System.Windows.Forms.Label LblVendorAddress;
        public System.Windows.Forms.Label LblVendorPhno;
        public System.Windows.Forms.Label LblPurchaseTrNo;
        public System.Windows.Forms.Label LblPurchaseDate;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label LblSubTotal;
        public System.Windows.Forms.Label LblTaxAmount;
        public System.Windows.Forms.Label LblTotalAmount;
    }
}