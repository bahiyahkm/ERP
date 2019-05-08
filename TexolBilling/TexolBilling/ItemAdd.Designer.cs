namespace TexolBilling
{
    partial class ItemAdd
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
            this.LblItemName = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblRate = new System.Windows.Forms.Label();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.Location = new System.Drawing.Point(196, 122);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(55, 13);
            this.LblItemName.TabIndex = 0;
            this.LblItemName.Text = "ItemName";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(196, 177);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 1;
            this.LblQuantity.Text = "Quantity";
            // 
            // LblRate
            // 
            this.LblRate.AutoSize = true;
            this.LblRate.Location = new System.Drawing.Point(196, 226);
            this.LblRate.Name = "LblRate";
            this.LblRate.Size = new System.Drawing.Size(30, 13);
            this.LblRate.TabIndex = 2;
            this.LblRate.Text = "Rate";
            // 
            // TxtItemName
            // 
            this.TxtItemName.Location = new System.Drawing.Point(362, 119);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(134, 20);
            this.TxtItemName.TabIndex = 3;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(362, 174);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(134, 20);
            this.TxtQuantity.TabIndex = 4;
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(362, 223);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(134, 20);
            this.TxtRate.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(312, 282);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 38);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 338);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.LblRate);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblItemName);
            this.Name = "ItemAdd";
            this.Text = "ItemAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblItemName;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblRate;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}