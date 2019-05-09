namespace TexolBilling
{
    partial class SalesItem
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
            this.SalesId = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.txtSItemId = new System.Windows.Forms.TextBox();
            this.txtSRate = new System.Windows.Forms.TextBox();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesId
            // 
            this.SalesId.AutoSize = true;
            this.SalesId.Location = new System.Drawing.Point(207, 92);
            this.SalesId.Name = "SalesId";
            this.SalesId.Size = new System.Drawing.Size(42, 13);
            this.SalesId.TabIndex = 0;
            this.SalesId.Text = "SalesId";
            // 
            // ItemId
            // 
            this.ItemId.AutoSize = true;
            this.ItemId.Location = new System.Drawing.Point(207, 132);
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(36, 13);
            this.ItemId.TabIndex = 1;
            this.ItemId.Text = "ItemId";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(207, 175);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(30, 13);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Rate";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(207, 213);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity";
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(355, 89);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(100, 20);
            this.txtSalesId.TabIndex = 4;
            // 
            // txtSItemId
            // 
            this.txtSItemId.Location = new System.Drawing.Point(355, 129);
            this.txtSItemId.Name = "txtSItemId";
            this.txtSItemId.Size = new System.Drawing.Size(100, 20);
            this.txtSItemId.TabIndex = 5;
            // 
            // txtSRate
            // 
            this.txtSRate.Location = new System.Drawing.Point(355, 172);
            this.txtSRate.Name = "txtSRate";
            this.txtSRate.Size = new System.Drawing.Size(100, 20);
            this.txtSRate.TabIndex = 6;
            this.txtSRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSRate_KeyPress);
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.Location = new System.Drawing.Point(355, 210);
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSQuantity.TabIndex = 7;
            this.txtSQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSQuantity_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(291, 273);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 31);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // SalesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtSQuantity);
            this.Controls.Add(this.txtSRate);
            this.Controls.Add(this.txtSItemId);
            this.Controls.Add(this.txtSalesId);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.SalesId);
            this.Name = "SalesItem";
            this.Text = "SalesItem";
            this.Load += new System.EventHandler(this.SalesItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesId;
        private System.Windows.Forms.Label ItemId;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.TextBox txtSItemId;
        private System.Windows.Forms.TextBox txtSRate;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label1;
    }
}