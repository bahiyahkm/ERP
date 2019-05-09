namespace TexolBilling
{
    partial class Sales
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
            this.components = new System.ComponentModel.Container();
            this.SalesTransactionNo = new System.Windows.Forms.Label();
            this.SalesDate = new System.Windows.Forms.Label();
            this.SalesStaffId = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.txtSalesTranNo = new System.Windows.Forms.TextBox();
            this.txtSalesDate = new System.Windows.Forms.TextBox();
            this.txtSalSId = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtSTotalAmount = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesTransactionNo
            // 
            this.SalesTransactionNo.AutoSize = true;
            this.SalesTransactionNo.Location = new System.Drawing.Point(178, 60);
            this.SalesTransactionNo.Name = "SalesTransactionNo";
            this.SalesTransactionNo.Size = new System.Drawing.Size(103, 13);
            this.SalesTransactionNo.TabIndex = 0;
            this.SalesTransactionNo.Text = "SalesTransactionNo";
            // 
            // SalesDate
            // 
            this.SalesDate.AutoSize = true;
            this.SalesDate.Location = new System.Drawing.Point(178, 106);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(56, 13);
            this.SalesDate.TabIndex = 1;
            this.SalesDate.Text = "SalesDate";
            // 
            // SalesStaffId
            // 
            this.SalesStaffId.AutoSize = true;
            this.SalesStaffId.Location = new System.Drawing.Point(178, 155);
            this.SalesStaffId.Name = "SalesStaffId";
            this.SalesStaffId.Size = new System.Drawing.Size(64, 13);
            this.SalesStaffId.TabIndex = 2;
            this.SalesStaffId.Text = "SalesStaffId";
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Location = new System.Drawing.Point(178, 201);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(60, 13);
            this.CustomerId.TabIndex = 3;
            this.CustomerId.Text = "CustomerId";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(178, 241);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(67, 13);
            this.TotalAmount.TabIndex = 4;
            this.TotalAmount.Text = "TotalAmount";
            // 
            // txtSalesTranNo
            // 
            this.txtSalesTranNo.Location = new System.Drawing.Point(340, 53);
            this.txtSalesTranNo.Name = "txtSalesTranNo";
            this.txtSalesTranNo.Size = new System.Drawing.Size(100, 20);
            this.txtSalesTranNo.TabIndex = 5;
            // 
            // txtSalesDate
            // 
            this.txtSalesDate.Location = new System.Drawing.Point(340, 99);
            this.txtSalesDate.Name = "txtSalesDate";
            this.txtSalesDate.Size = new System.Drawing.Size(100, 20);
            this.txtSalesDate.TabIndex = 6;
            // 
            // txtSalSId
            // 
            this.txtSalSId.Location = new System.Drawing.Point(340, 148);
            this.txtSalSId.Name = "txtSalSId";
            this.txtSalSId.Size = new System.Drawing.Size(100, 20);
            this.txtSalSId.TabIndex = 7;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(340, 194);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 8;
            // 
            // txtSTotalAmount
            // 
            this.txtSTotalAmount.Location = new System.Drawing.Point(340, 241);
            this.txtSTotalAmount.Name = "txtSTotalAmount";
            this.txtSTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSTotalAmount.TabIndex = 9;
            this.txtSTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTotalAmount_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(279, 288);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 29);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtSTotalAmount);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtSalSId);
            this.Controls.Add(this.txtSalesDate);
            this.Controls.Add(this.txtSalesTranNo);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.SalesStaffId);
            this.Controls.Add(this.SalesDate);
            this.Controls.Add(this.SalesTransactionNo);
            this.Name = "Sales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesTransactionNo;
        private System.Windows.Forms.Label SalesDate;
        private System.Windows.Forms.Label SalesStaffId;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.TextBox txtSalesTranNo;
        private System.Windows.Forms.TextBox txtSalesDate;
        private System.Windows.Forms.TextBox txtSalSId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtSTotalAmount;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Label label1;
    }
}