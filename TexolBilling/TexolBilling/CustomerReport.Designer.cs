namespace TexolBilling
{
    partial class CustomerReport
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
            this.ToDateCust = new System.Windows.Forms.Label();
            this.BtnShowCust = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FromDateCust = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 237);
            this.dataGridView1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(418, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // ToDateCust
            // 
            this.ToDateCust.AutoSize = true;
            this.ToDateCust.Location = new System.Drawing.Point(363, 45);
            this.ToDateCust.Name = "ToDateCust";
            this.ToDateCust.Size = new System.Drawing.Size(46, 13);
            this.ToDateCust.TabIndex = 14;
            this.ToDateCust.Text = "To Date";
            // 
            // BtnShowCust
            // 
            this.BtnShowCust.Location = new System.Drawing.Point(651, 38);
            this.BtnShowCust.Name = "BtnShowCust";
            this.BtnShowCust.Size = new System.Drawing.Size(67, 23);
            this.BtnShowCust.TabIndex = 13;
            this.BtnShowCust.Text = "Show";
            this.BtnShowCust.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // FromDateCust
            // 
            this.FromDateCust.AutoSize = true;
            this.FromDateCust.Location = new System.Drawing.Point(44, 45);
            this.FromDateCust.Name = "FromDateCust";
            this.FromDateCust.Size = new System.Drawing.Size(56, 13);
            this.FromDateCust.TabIndex = 11;
            this.FromDateCust.Text = "From Date";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(651, 356);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(67, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ToDateCust);
            this.Controls.Add(this.BtnShowCust);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FromDateCust);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label ToDateCust;
        private System.Windows.Forms.Button BtnShowCust;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FromDateCust;
        private System.Windows.Forms.Button BtnCancel;
    }
}