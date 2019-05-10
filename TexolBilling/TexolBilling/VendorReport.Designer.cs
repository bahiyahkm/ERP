namespace TexolBilling
{
    partial class VendorReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ToDateVendor = new System.Windows.Forms.Label();
            this.BtnShowVendor = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FromDateVendor = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 237);
            this.dataGridView1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // ToDateVendor
            // 
            this.ToDateVendor.AutoSize = true;
            this.ToDateVendor.Location = new System.Drawing.Point(367, 32);
            this.ToDateVendor.Name = "ToDateVendor";
            this.ToDateVendor.Size = new System.Drawing.Size(46, 13);
            this.ToDateVendor.TabIndex = 20;
            this.ToDateVendor.Text = "To Date";
            // 
            // BtnShowVendor
            // 
            this.BtnShowVendor.Location = new System.Drawing.Point(655, 25);
            this.BtnShowVendor.Name = "BtnShowVendor";
            this.BtnShowVendor.Size = new System.Drawing.Size(67, 23);
            this.BtnShowVendor.TabIndex = 19;
            this.BtnShowVendor.Text = "Show";
            this.BtnShowVendor.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // FromDateVendor
            // 
            this.FromDateVendor.AutoSize = true;
            this.FromDateVendor.Location = new System.Drawing.Point(48, 32);
            this.FromDateVendor.Name = "FromDateVendor";
            this.FromDateVendor.Size = new System.Drawing.Size(56, 13);
            this.FromDateVendor.TabIndex = 17;
            this.FromDateVendor.Text = "From Date";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(655, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 23);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // VendorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ToDateVendor);
            this.Controls.Add(this.BtnShowVendor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FromDateVendor);
            this.Name = "VendorReport";
            this.Text = "VendorReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label ToDateVendor;
        private System.Windows.Forms.Button BtnShowVendor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FromDateVendor;
        private System.Windows.Forms.Button BtnCancel;
    }
}