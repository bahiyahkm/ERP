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
            this.CmbPayMet = new System.Windows.Forms.ComboBox();
            this.CmbNameS = new System.Windows.Forms.ComboBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.datetimepicker2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblItem = new System.Windows.Forms.Label();
            this.Lblquantity = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.CmbItemS = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Lblmsg = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.SalesTransactionNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesTransactionNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTransactionNo.Location = new System.Drawing.Point(498, 28);
            this.SalesTransactionNo.Name = "SalesTransactionNo";
            this.SalesTransactionNo.Size = new System.Drawing.Size(117, 15);
            this.SalesTransactionNo.TabIndex = 0;
            this.SalesTransactionNo.Text = "SalesTransactionNo:";
            // 
            // SalesDate
            // 
            this.SalesDate.AutoSize = true;
            this.SalesDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDate.Location = new System.Drawing.Point(549, 69);
            this.SalesDate.Name = "SalesDate";
            this.SalesDate.Size = new System.Drawing.Size(65, 15);
            this.SalesDate.TabIndex = 1;
            this.SalesDate.Text = "SalesDate:";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(520, 111);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(103, 15);
            this.PaymentMethod.TabIndex = 4;
            this.PaymentMethod.Text = "PaymentMethod:";
            // 
            // txtSalesTranNo
            // 
            this.txtSalesTranNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesTranNo.Location = new System.Drawing.Point(639, 25);
            this.txtSalesTranNo.Name = "txtSalesTranNo";
            this.txtSalesTranNo.Size = new System.Drawing.Size(149, 20);
            this.txtSalesTranNo.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.HotPink;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(663, 175);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(50, 25);
            this.BtnSave.TabIndex = 10;
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
            // CmbPayMet
            // 
            this.CmbPayMet.FormattingEnabled = true;
            this.CmbPayMet.Items.AddRange(new object[] {
            "Credit",
            "Cash"});
            this.CmbPayMet.Location = new System.Drawing.Point(639, 108);
            this.CmbPayMet.Name = "CmbPayMet";
            this.CmbPayMet.Size = new System.Drawing.Size(149, 21);
            this.CmbPayMet.TabIndex = 12;
            // 
            // CmbNameS
            // 
            this.CmbNameS.FormattingEnabled = true;
            this.CmbNameS.Location = new System.Drawing.Point(105, 28);
            this.CmbNameS.Name = "CmbNameS";
            this.CmbNameS.Size = new System.Drawing.Size(251, 21);
            this.CmbNameS.TabIndex = 14;
            this.CmbNameS.SelectedIndexChanged += new System.EventHandler(this.CmbNameS_SelectedIndexChanged);
            // 
            // dgvSales
            // 
            this.dgvSales.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(53, 225);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(735, 211);
            this.dgvSales.TabIndex = 15;
            // 
            // datetimepicker2
            // 
            this.datetimepicker2.Location = new System.Drawing.Point(639, 63);
            this.datetimepicker2.Name = "datetimepicker2";
            this.datetimepicker2.Size = new System.Drawing.Size(149, 20);
            this.datetimepicker2.TabIndex = 17;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.HotPink;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(720, 175);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(57, 25);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(50, 26);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(43, 15);
            this.LblName.TabIndex = 19;
            this.LblName.Text = "Name:";
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(50, 205);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(37, 15);
            this.LblItem.TabIndex = 20;
            this.LblItem.Text = "Item:";
            // 
            // Lblquantity
            // 
            this.Lblquantity.AutoSize = true;
            this.Lblquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lblquantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblquantity.Location = new System.Drawing.Point(380, 205);
            this.Lblquantity.Name = "Lblquantity";
            this.Lblquantity.Size = new System.Drawing.Size(58, 15);
            this.Lblquantity.TabIndex = 21;
            this.Lblquantity.Text = "Quantity:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(226, 205);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(38, 15);
            this.LblPrice.TabIndex = 22;
            this.LblPrice.Text = "Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(437, 198);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(104, 20);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(263, 198);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CmbItemS
            // 
            this.CmbItemS.FormattingEnabled = true;
            this.CmbItemS.Location = new System.Drawing.Point(91, 197);
            this.CmbItemS.Name = "CmbItemS";
            this.CmbItemS.Size = new System.Drawing.Size(121, 21);
            this.CmbItemS.TabIndex = 25;
            this.CmbItemS.SelectedIndexChanged += new System.EventHandler(this.CmbItemS_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.HotPink;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdd.Location = new System.Drawing.Point(547, 196);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(58, 23);
            this.BtnAdd.TabIndex = 26;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(102, 63);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 27;
            this.LblAddress.Text = "Address";
            // 
            // LblPhno
            // 
            this.LblPhno.AutoSize = true;
            this.LblPhno.Location = new System.Drawing.Point(102, 92);
            this.LblPhno.Name = "LblPhno";
            this.LblPhno.Size = new System.Drawing.Size(58, 13);
            this.LblPhno.TabIndex = 28;
            this.LblPhno.Text = "ContactNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(668, 445);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 30);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "0";
            // 
            // Lblmsg
            // 
            this.Lblmsg.AutoSize = true;
            this.Lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblmsg.Location = new System.Drawing.Point(590, 244);
            this.Lblmsg.Name = "Lblmsg";
            this.Lblmsg.Size = new System.Drawing.Size(0, 15);
            this.Lblmsg.TabIndex = 31;
            this.Lblmsg.Visible = false;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(639, 139);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(34, 22);
            this.txtTax.TabIndex = 35;
            this.txtTax.Text = "15";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(586, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tax:";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(668, 526);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(25, 30);
            this.LblSubTotal.TabIndex = 37;
            this.LblSubTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sub Total :";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTax.Location = new System.Drawing.Point(668, 485);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(25, 30);
            this.LblTax.TabIndex = 39;
            this.LblTax.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(518, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 30);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tax Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 40;
            this.label6.Visible = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(803, 559);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lblmsg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPhno);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbItemS);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.Lblquantity);
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.datetimepicker2);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.CmbNameS);
            this.Controls.Add(this.CmbPayMet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtSalesTranNo);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.SalesDate);
            this.Controls.Add(this.SalesTransactionNo);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
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
        private System.Windows.Forms.ComboBox CmbPayMet;
        private System.Windows.Forms.ComboBox CmbNameS;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DateTimePicker datetimepicker2;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbItemS;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label Lblquantity;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPhno;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lblmsg;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}