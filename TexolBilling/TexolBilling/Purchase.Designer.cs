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
            this.CBPayMet = new System.Windows.Forms.ComboBox();
            this.CBName = new System.Windows.Forms.ComboBox();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSize = true;
            this.PurchaseDate.Location = new System.Drawing.Point(434, 70);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(75, 13);
            this.PurchaseDate.TabIndex = 1;
            this.PurchaseDate.Text = "PurchaseDate";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(525, 143);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(61, 25);
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
            this.label2.Location = new System.Drawing.Point(542, 16);
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
            this.PurchaseTransactionNo.Location = new System.Drawing.Point(434, 24);
            this.PurchaseTransactionNo.Name = "PurchaseTransactionNo";
            this.PurchaseTransactionNo.Size = new System.Drawing.Size(122, 13);
            this.PurchaseTransactionNo.TabIndex = 11;
            this.PurchaseTransactionNo.Text = "PurchaseTransactionNo";
            // 
            // txtPurchaseTNo
            // 
            this.txtPurchaseTNo.Location = new System.Drawing.Point(562, 17);
            this.txtPurchaseTNo.Name = "txtPurchaseTNo";
            this.txtPurchaseTNo.Size = new System.Drawing.Size(171, 20);
            this.txtPurchaseTNo.TabIndex = 12;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.Location = new System.Drawing.Point(434, 113);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.PaymentMethod.TabIndex = 3;
            this.PaymentMethod.Text = "Payment Method";
            // 
            // CBPayMet
            // 
            this.CBPayMet.FormattingEnabled = true;
            this.CBPayMet.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.CBPayMet.Location = new System.Drawing.Point(562, 104);
            this.CBPayMet.Name = "CBPayMet";
            this.CBPayMet.Size = new System.Drawing.Size(171, 21);
            this.CBPayMet.TabIndex = 13;
            // 
            // CBName
            // 
            this.CBName.FormattingEnabled = true;
            this.CBName.Location = new System.Drawing.Point(70, 46);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(238, 21);
            this.CBName.TabIndex = 14;
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Rate,
            this.Quantity});
            this.dgvPurchase.Location = new System.Drawing.Point(12, 182);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.Size = new System.Drawing.Size(721, 232);
            this.dgvPurchase.TabIndex = 15;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(562, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(611, 143);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 25);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.CBPayMet);
            this.Controls.Add(this.txtPurchaseTNo);
            this.Controls.Add(this.PurchaseTransactionNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.PurchaseDate);
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
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
        private System.Windows.Forms.ComboBox CBName;
        private System.Windows.Forms.ComboBox CBPayMet;
        private System.Windows.Forms.TextBox txtPurchaseTNo;
        private System.Windows.Forms.Label PurchaseTransactionNo;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button BtnCancel;
    }
}