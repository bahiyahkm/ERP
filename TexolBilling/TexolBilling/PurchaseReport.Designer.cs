namespace TexolBilling
{
    partial class PurchaseReport
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FromDateP = new System.Windows.Forms.Label();
            this.BtnShowP = new System.Windows.Forms.Button();
            this.ToDateP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(398, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // FromDateP
            // 
            this.FromDateP.AutoSize = true;
            this.FromDateP.Location = new System.Drawing.Point(40, 44);
            this.FromDateP.Name = "FromDateP";
            this.FromDateP.Size = new System.Drawing.Size(56, 13);
            this.FromDateP.TabIndex = 2;
            this.FromDateP.Text = "From Date";
            // 
            // BtnShowP
            // 
            this.BtnShowP.Location = new System.Drawing.Point(637, 38);
            this.BtnShowP.Name = "BtnShowP";
            this.BtnShowP.Size = new System.Drawing.Size(75, 23);
            this.BtnShowP.TabIndex = 3;
            this.BtnShowP.Text = "Show";
            this.BtnShowP.UseVisualStyleBackColor = true;
            // 
            // ToDateP
            // 
            this.ToDateP.AutoSize = true;
            this.ToDateP.Location = new System.Drawing.Point(341, 44);
            this.ToDateP.Name = "ToDateP";
            this.ToDateP.Size = new System.Drawing.Size(46, 13);
            this.ToDateP.TabIndex = 4;
            this.ToDateP.Text = "To Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 244);
            this.dataGridView1.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(686, 357);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 392);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToDateP);
            this.Controls.Add(this.BtnShowP);
            this.Controls.Add(this.FromDateP);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "PurchaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label FromDateP;
        private System.Windows.Forms.Button BtnShowP;
        private System.Windows.Forms.Label ToDateP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancel;
    }
}