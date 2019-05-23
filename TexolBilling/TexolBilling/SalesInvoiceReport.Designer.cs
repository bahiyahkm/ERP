namespace TexolBilling
{
    partial class SalesInvoiceReport
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
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.LblSalesDate = new System.Windows.Forms.Label();
            this.LblSalesTrno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPhno = new System.Windows.Forms.Label();
            this.LblCustomerAddress = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTaxAmount = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(539, 372);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(82, 13);
            this.PaymentMethod.TabIndex = 5;
            this.PaymentMethod.Text = "TotalAmount:";
            // 
            // LblSalesDate
            // 
            this.LblSalesDate.AutoSize = true;
            this.LblSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalesDate.Location = new System.Drawing.Point(619, 97);
            this.LblSalesDate.Name = "LblSalesDate";
            this.LblSalesDate.Size = new System.Drawing.Size(69, 13);
            this.LblSalesDate.TabIndex = 6;
            this.LblSalesDate.Text = "SalesDate:";
            this.LblSalesDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSalesTrno
            // 
            this.LblSalesTrno.AutoSize = true;
            this.LblSalesTrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalesTrno.Location = new System.Drawing.Point(619, 69);
            this.LblSalesTrno.Name = "LblSalesTrno";
            this.LblSalesTrno.Size = new System.Drawing.Size(118, 13);
            this.LblSalesTrno.TabIndex = 7;
            this.LblSalesTrno.Text = "SalesTransactioNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sales Invoice";
            // 
            // LblPhno
            // 
            this.LblPhno.AutoSize = true;
            this.LblPhno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhno.Location = new System.Drawing.Point(72, 137);
            this.LblPhno.Name = "LblPhno";
            this.LblPhno.Size = new System.Drawing.Size(63, 13);
            this.LblPhno.TabIndex = 9;
            this.LblPhno.Text = "PhoneNo:";
            // 
            // LblCustomerAddress
            // 
            this.LblCustomerAddress.AutoSize = true;
            this.LblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerAddress.Location = new System.Drawing.Point(72, 109);
            this.LblCustomerAddress.Name = "LblCustomerAddress";
            this.LblCustomerAddress.Size = new System.Drawing.Size(56, 13);
            this.LblCustomerAddress.TabIndex = 10;
            this.LblCustomerAddress.Text = "Address:";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(72, 84);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(95, 13);
            this.LblCustomerName.TabIndex = 11;
            this.LblCustomerName.Text = "CustomerName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "SubTotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tax Amount:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 213);
            this.dataGridView1.TabIndex = 14;
            // 
            // LblTaxAmount
            // 
            this.LblTaxAmount.AutoSize = true;
            this.LblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxAmount.Location = new System.Drawing.Point(623, 394);
            this.LblTaxAmount.Name = "LblTaxAmount";
            this.LblTaxAmount.Size = new System.Drawing.Size(14, 13);
            this.LblTaxAmount.TabIndex = 17;
            this.LblTaxAmount.Text = "0";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(623, 416);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(14, 13);
            this.LblSubTotal.TabIndex = 16;
            this.LblSubTotal.Text = "0";
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(623, 372);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(14, 13);
            this.LblTotalAmount.TabIndex = 15;
            this.LblTotalAmount.Text = "0";
            // 
            // SalesInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTaxAmount);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.LblCustomerAddress);
            this.Controls.Add(this.LblPhno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSalesTrno);
            this.Controls.Add(this.LblSalesDate);
            this.Controls.Add(this.PaymentMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalesInvoiceReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label PaymentMethod;
        public System.Windows.Forms.Label LblSalesDate;
        public System.Windows.Forms.Label LblSalesTrno;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LblPhno;
        public System.Windows.Forms.Label LblCustomerAddress;
        public System.Windows.Forms.Label LblCustomerName;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label LblTaxAmount;
        public System.Windows.Forms.Label LblSubTotal;
        public System.Windows.Forms.Label LblTotalAmount;
    }
}