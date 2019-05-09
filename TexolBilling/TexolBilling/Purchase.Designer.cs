namespace TexolBilling
{
    partial class Purchase
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
            this.PurchaseTransactionNo = new System.Windows.Forms.Label();
            this.PurchaseDate = new System.Windows.Forms.Label();
            this.VendorId = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.txtPurchaseTranNo = new System.Windows.Forms.TextBox();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.txtPTotalAmont = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseTransactionNo
            // 
            this.PurchaseTransactionNo.AutoSize = true;
            this.PurchaseTransactionNo.Location = new System.Drawing.Point(153, 62);
            this.PurchaseTransactionNo.Name = "PurchaseTransactionNo";
            this.PurchaseTransactionNo.Size = new System.Drawing.Size(122, 13);
            this.PurchaseTransactionNo.TabIndex = 0;
            this.PurchaseTransactionNo.Text = "PurchaseTransactionNo";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSize = true;
            this.PurchaseDate.Location = new System.Drawing.Point(153, 120);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(75, 13);
            this.PurchaseDate.TabIndex = 1;
            this.PurchaseDate.Text = "PurchaseDate";
            // 
            // VendorId
            // 
            this.VendorId.AutoSize = true;
            this.VendorId.Location = new System.Drawing.Point(153, 179);
            this.VendorId.Name = "VendorId";
            this.VendorId.Size = new System.Drawing.Size(50, 13);
            this.VendorId.TabIndex = 2;
            this.VendorId.Text = "VendorId";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(153, 242);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(67, 13);
            this.TotalAmount.TabIndex = 3;
            this.TotalAmount.Text = "TotalAmount";
            // 
            // txtPurchaseTranNo
            // 
            this.txtPurchaseTranNo.Location = new System.Drawing.Point(320, 59);
            this.txtPurchaseTranNo.Name = "txtPurchaseTranNo";
            this.txtPurchaseTranNo.Size = new System.Drawing.Size(132, 20);
            this.txtPurchaseTranNo.TabIndex = 4;
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Location = new System.Drawing.Point(320, 113);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(132, 20);
            this.txtPurchaseDate.TabIndex = 5;
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(320, 172);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(132, 20);
            this.txtVendorId.TabIndex = 6;
            // 
            // txtPTotalAmont
            // 
            this.txtPTotalAmont.Location = new System.Drawing.Point(320, 235);
            this.txtPTotalAmont.Name = "txtPTotalAmont";
            this.txtPTotalAmont.Size = new System.Drawing.Size(132, 20);
            this.txtPTotalAmont.TabIndex = 7;
            this.txtPTotalAmont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPTotalAmont_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(264, 294);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 27);
            this.BtnSave.TabIndex = 8;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtPTotalAmont);
            this.Controls.Add(this.txtVendorId);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.txtPurchaseTranNo);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.VendorId);
            this.Controls.Add(this.PurchaseDate);
            this.Controls.Add(this.PurchaseTransactionNo);
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseTransactionNo;
        private System.Windows.Forms.Label PurchaseDate;
        private System.Windows.Forms.Label VendorId;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.TextBox txtPurchaseTranNo;
        private System.Windows.Forms.TextBox txtPurchaseDate;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.TextBox txtPTotalAmont;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label2;
    }
}