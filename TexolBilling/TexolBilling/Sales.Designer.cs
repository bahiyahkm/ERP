﻿namespace TexolBilling
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
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.txtSalesTranNo = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbSPayMet = new System.Windows.Forms.ComboBox();
            this.cbSname = new System.Windows.Forms.ComboBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpSales = new System.Windows.Forms.DateTimePicker();
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesTransactionNo
            // 
            this.SalesTransactionNo.AutoSize = true;
            this.SalesTransactionNo.Location = new System.Drawing.Point(511, 28);
            this.SalesTransactionNo.Name = "SalesTransactionNo";
            this.SalesTransactionNo.Size = new System.Drawing.Size(103, 13);
            this.SalesTransactionNo.TabIndex = 0;
            this.SalesTransactionNo.Text = "SalesTransactionNo";
            // 
            // SalesDate
            // 
            this.SalesDate.AutoSize = true;
            this.SalesDate.Location = new System.Drawing.Point(511, 69);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(56, 13);
            this.SalesDate.TabIndex = 1;
            this.SalesDate.Text = "SalesDate";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.Location = new System.Drawing.Point(511, 108);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(84, 13);
            this.PaymentMethod.TabIndex = 4;
            this.PaymentMethod.Text = "PaymentMethod";
            // 
            // txtSalesTranNo
            // 
            this.txtSalesTranNo.Location = new System.Drawing.Point(639, 25);
            this.txtSalesTranNo.Name = "txtSalesTranNo";
            this.txtSalesTranNo.Size = new System.Drawing.Size(149, 20);
            this.txtSalesTranNo.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(593, 144);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(51, 21);
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
            this.label1.Location = new System.Drawing.Point(620, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // cbSPayMet
            // 
            this.cbSPayMet.FormattingEnabled = true;
            this.cbSPayMet.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cbSPayMet.Location = new System.Drawing.Point(639, 108);
            this.cbSPayMet.Name = "cbSPayMet";
            this.cbSPayMet.Size = new System.Drawing.Size(149, 21);
            this.cbSPayMet.TabIndex = 12;
            // 
            // cbSname
            // 
            this.cbSname.FormattingEnabled = true;
            this.cbSname.Location = new System.Drawing.Point(77, 43);
            this.cbSname.Name = "cbSname";
            this.cbSname.Size = new System.Drawing.Size(251, 21);
            this.cbSname.TabIndex = 14;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Rate,
            this.Quantity});
            this.dgvSales.Location = new System.Drawing.Point(32, 205);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(716, 233);
            this.dgvSales.TabIndex = 15;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // dtpSales
            // 
            this.dtpSales.Location = new System.Drawing.Point(639, 63);
            this.dtpSales.Name = "dtpSales";
            this.dtpSales.Size = new System.Drawing.Size(149, 20);
            this.dtpSales.TabIndex = 17;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(670, 144);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(51, 21);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dtpSales);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.cbSname);
            this.Controls.Add(this.cbSPayMet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtSalesTranNo);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.SalesDate);
            this.Controls.Add(this.SalesTransactionNo);
            this.Name = "Sales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesTransactionNo;
        private System.Windows.Forms.Label SalesDate;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.TextBox txtSalesTranNo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSPayMet;
        private System.Windows.Forms.ComboBox cbSname;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DateTimePicker dtpSales;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button BtnCancel;
    }
}