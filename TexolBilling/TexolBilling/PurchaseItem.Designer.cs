namespace TexolBilling
{
    partial class PurchaseItem
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
            this.PurchaseId = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtPRate = new System.Windows.Forms.TextBox();
            this.txtPQuantity = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseId
            // 
            this.PurchaseId.AutoSize = true;
            this.PurchaseId.Location = new System.Drawing.Point(255, 74);
            this.PurchaseId.Name = "PurchaseId";
            this.PurchaseId.Size = new System.Drawing.Size(61, 13);
            this.PurchaseId.TabIndex = 0;
            this.PurchaseId.Text = "PurchaseId";
            // 
            // ItemId
            // 
            this.ItemId.AutoSize = true;
            this.ItemId.Location = new System.Drawing.Point(255, 124);
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(36, 13);
            this.ItemId.TabIndex = 1;
            this.ItemId.Text = "ItemId";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(255, 175);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(30, 13);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Rate";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(255, 223);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity";
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(384, 71);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseId.TabIndex = 4;
            this.txtPurchaseId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(384, 117);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(100, 20);
            this.txtItemId.TabIndex = 5;
            // 
            // txtPRate
            // 
            this.txtPRate.Location = new System.Drawing.Point(384, 168);
            this.txtPRate.Name = "txtPRate";
            this.txtPRate.Size = new System.Drawing.Size(100, 20);
            this.txtPRate.TabIndex = 6;
            this.txtPRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRate_KeyPress);
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.Location = new System.Drawing.Point(384, 216);
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtPQuantity.TabIndex = 7;
            this.txtPQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPQuantity_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(322, 281);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
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
            // PurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtPQuantity);
            this.Controls.Add(this.txtPRate);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtPurchaseId);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.PurchaseId);
            this.Name = "PurchaseItem";
            this.Text = "PurchaseItem";
            this.Load += new System.EventHandler(this.PurchaseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseId;
        private System.Windows.Forms.Label ItemId;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtPRate;
        private System.Windows.Forms.TextBox txtPQuantity;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}