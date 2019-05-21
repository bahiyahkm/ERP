namespace TexolBilling
{
    partial class ItemReport
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ToDateItem = new System.Windows.Forms.Label();
            this.BtnShowItem = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.FromDateItem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(419, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // ToDateItem
            // 
            this.ToDateItem.AutoSize = true;
            this.ToDateItem.Location = new System.Drawing.Point(364, 30);
            this.ToDateItem.Name = "ToDateItem";
            this.ToDateItem.Size = new System.Drawing.Size(46, 13);
            this.ToDateItem.TabIndex = 8;
            this.ToDateItem.Text = "To Date";
            // 
            // BtnShowItem
            // 
            this.BtnShowItem.Location = new System.Drawing.Point(652, 23);
            this.BtnShowItem.Name = "BtnShowItem";
            this.BtnShowItem.Size = new System.Drawing.Size(67, 23);
            this.BtnShowItem.TabIndex = 7;
            this.BtnShowItem.Text = "Show";
            this.BtnShowItem.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(107, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // FromDateItem
            // 
            this.FromDateItem.AutoSize = true;
            this.FromDateItem.Location = new System.Drawing.Point(45, 30);
            this.FromDateItem.Name = "FromDateItem";
            this.FromDateItem.Size = new System.Drawing.Size(56, 13);
            this.FromDateItem.TabIndex = 5;
            this.FromDateItem.Text = "From Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 237);
            this.dataGridView1.TabIndex = 10;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(652, 350);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 389);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ToDateItem);
            this.Controls.Add(this.BtnShowItem);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.FromDateItem);
            this.Name = "ItemReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label ToDateItem;
        private System.Windows.Forms.Button BtnShowItem;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label FromDateItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancel;
    }
}