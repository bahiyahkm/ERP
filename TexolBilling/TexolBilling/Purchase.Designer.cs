﻿namespace TexolBilling
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
            this.PurchaseDate = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PurchaseTransactionNo = new System.Windows.Forms.Label();
            this.txtPurchaseTNo = new System.Windows.Forms.TextBox();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.CmbPayMet = new System.Windows.Forms.ComboBox();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.erp_dbDataSet = new TexolBilling.erp_dbDataSet();
            this.vendortblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendor_tblTableAdapter = new TexolBilling.erp_dbDataSetTableAdapters.vendor_tblTableAdapter();
            this.erp_dbDataSet1 = new TexolBilling.erp_dbDataSet1();
            this.customerstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customers_tblTableAdapter = new TexolBilling.erp_dbDataSet1TableAdapters.customers_tblTableAdapter();
            this.LblName = new System.Windows.Forms.Label();
            this.LblItems = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbItemName = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhno = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTaxAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendortblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSize = true;
            this.PurchaseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDate.Location = new System.Drawing.Point(456, 62);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(87, 15);
            this.PurchaseDate.TabIndex = 1;
            this.PurchaseDate.Text = "PurchaseDate:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(610, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(47, 25);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
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
            this.label2.Location = new System.Drawing.Point(542, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PurchaseTransactionNo
            // 
            this.PurchaseTransactionNo.AutoSize = true;
            this.PurchaseTransactionNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseTransactionNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseTransactionNo.Location = new System.Drawing.Point(400, 20);
            this.PurchaseTransactionNo.Name = "PurchaseTransactionNo";
            this.PurchaseTransactionNo.Size = new System.Drawing.Size(139, 15);
            this.PurchaseTransactionNo.TabIndex = 11;
            this.PurchaseTransactionNo.Text = "PurchaseTransactionNo:";
            // 
            // txtPurchaseTNo
            // 
            this.txtPurchaseTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchaseTNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseTNo.Location = new System.Drawing.Point(562, 17);
            this.txtPurchaseTNo.Name = "txtPurchaseTNo";
            this.txtPurchaseTNo.Size = new System.Drawing.Size(171, 22);
            this.txtPurchaseTNo.TabIndex = 12;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(451, 102);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(106, 15);
            this.PaymentMethod.TabIndex = 3;
            this.PaymentMethod.Text = "Payment Method:";
            // 
            // CmbPayMet
            // 
            this.CmbPayMet.FormattingEnabled = true;
            this.CmbPayMet.Items.AddRange(new object[] {
            "Credit",
            "Cash"});
            this.CmbPayMet.Location = new System.Drawing.Point(562, 99);
            this.CmbPayMet.Name = "CmbPayMet";
            this.CmbPayMet.Size = new System.Drawing.Size(171, 21);
            this.CmbPayMet.TabIndex = 13;
            // 
            // CmbName
            // 
            this.CmbName.FormattingEnabled = true;
            this.CmbName.Location = new System.Drawing.Point(70, 15);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(238, 21);
            this.CmbName.TabIndex = 14;
            this.CmbName.SelectedIndexChanged += new System.EventHandler(this.CBName_SelectedIndexChanged);
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Location = new System.Drawing.Point(12, 228);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.Size = new System.Drawing.Size(721, 199);
            this.dgvPurchase.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(562, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(668, 181);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(65, 25);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // erp_dbDataSet
            // 
            this.erp_dbDataSet.DataSetName = "erp_dbDataSet";
            this.erp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendortblBindingSource
            // 
            this.vendortblBindingSource.DataMember = "vendor_tbl";
            this.vendortblBindingSource.DataSource = this.erp_dbDataSet;
            // 
            // vendor_tblTableAdapter
            // 
            this.vendor_tblTableAdapter.ClearBeforeFill = true;
            // 
            // erp_dbDataSet1
            // 
            this.erp_dbDataSet1.DataSetName = "erp_dbDataSet1";
            this.erp_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerstblBindingSource
            // 
            this.customerstblBindingSource.DataMember = "customers_tbl";
            this.customerstblBindingSource.DataSource = this.erp_dbDataSet1;
            // 
            // customers_tblTableAdapter
            // 
            this.customers_tblTableAdapter.ClearBeforeFill = true;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(12, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(43, 15);
            this.LblName.TabIndex = 18;
            this.LblName.Text = "Name:";
            
            // 
            // LblItems
            // 
            this.LblItems.AutoSize = true;
            this.LblItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItems.Location = new System.Drawing.Point(9, 207);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(42, 15);
            this.LblItems.TabIndex = 19;
            this.LblItems.Text = "Items:";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(341, 207);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(58, 15);
            this.LblQuantity.TabIndex = 20;
            this.LblQuantity.Text = "Quantity:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(187, 207);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(38, 15);
            this.LblPrice.TabIndex = 21;
            this.LblPrice.Text = "Price:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(519, 202);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(53, 22);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbItemName
            // 
            this.CmbItemName.FormattingEnabled = true;
            this.CmbItemName.Location = new System.Drawing.Point(50, 203);
            this.CmbItemName.Name = "CmbItemName";
            this.CmbItemName.Size = new System.Drawing.Size(100, 21);
            this.CmbItemName.TabIndex = 23;
            this.CmbItemName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(403, 202);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 24;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(224, 202);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(67, 41);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 26;
            this.LblAddress.Text = "Address";
            
            // 
            // LblPhno
            // 
            this.LblPhno.AutoSize = true;
            this.LblPhno.Location = new System.Drawing.Point(67, 65);
            this.LblPhno.Name = "LblPhno";
            this.LblPhno.Size = new System.Drawing.Size(58, 13);
            this.LblPhno.TabIndex = 27;
            this.LblPhno.Text = "ContactNo";
           
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(514, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 30);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total Amount:";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(603, 281);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(74, 13);
            this.LblMessage.TabIndex = 35;
            this.LblMessage.Text = "LblMessage";
            this.LblMessage.Visible = false;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(562, 137);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(35, 22);
            this.txtTax.TabIndex = 37;
            this.txtTax.Text = "15";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tax:";
            // 
            // LblTaxAmount
            // 
            this.LblTaxAmount.AutoSize = true;
            this.LblTaxAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTaxAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaxAmount.Location = new System.Drawing.Point(514, 466);
            this.LblTaxAmount.Name = "LblTaxAmount";
            this.LblTaxAmount.Size = new System.Drawing.Size(25, 30);
            this.LblTaxAmount.TabIndex = 39;
            this.LblTaxAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tax Amount:";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(514, 500);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(25, 30);
            this.LblSubTotal.TabIndex = 41;
            this.LblSubTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 30);
            this.label9.TabIndex = 40;
            this.label9.Text = "SubTotal:";
            // 
            // lblsave
            // 
            this.lblsave.AutoSize = true;
            this.lblsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsave.Location = new System.Drawing.Point(622, 322);
            this.lblsave.Name = "lblsave";
            this.lblsave.Size = new System.Drawing.Size(0, 13);
            this.lblsave.TabIndex = 42;
            this.lblsave.Visible = false;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(780, 581);
            this.Controls.Add(this.lblsave);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblTaxAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPhno);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.CmbItemName);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.CmbName);
            this.Controls.Add(this.CmbPayMet);
            this.Controls.Add(this.txtPurchaseTNo);
            this.Controls.Add(this.PurchaseTransactionNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.PurchaseDate);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendortblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerstblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PurchaseDate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.ComboBox CmbPayMet;
        private System.Windows.Forms.TextBox txtPurchaseTNo;
        private System.Windows.Forms.Label PurchaseTransactionNo;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnCancel;
        private erp_dbDataSet erp_dbDataSet;
        private System.Windows.Forms.BindingSource vendortblBindingSource;
        private erp_dbDataSetTableAdapters.vendor_tblTableAdapter vendor_tblTableAdapter;
        private erp_dbDataSet1 erp_dbDataSet1;
        private System.Windows.Forms.BindingSource customerstblBindingSource;
        private erp_dbDataSet1TableAdapters.customers_tblTableAdapter customers_tblTableAdapter;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox CmbItemName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPhno;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTaxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblsave;
    }
}