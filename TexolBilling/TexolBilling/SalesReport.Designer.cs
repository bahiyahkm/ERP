namespace TexolBilling
{
    partial class SalesReport
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
            this.FromDateS = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ToDateS = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // FromDateS
            // 
            this.FromDateS.AutoSize = true;
            this.FromDateS.Location = new System.Drawing.Point(54, 46);
            this.FromDateS.Name = "FromDateS";
            this.FromDateS.Size = new System.Drawing.Size(56, 13);
            this.FromDateS.TabIndex = 0;
            this.FromDateS.Text = "From Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(116, 39);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // ToDateS
            // 
            this.ToDateS.AutoSize = true;
            this.ToDateS.Location = new System.Drawing.Point(373, 46);
            this.ToDateS.Name = "ToDateS";
            this.ToDateS.Size = new System.Drawing.Size(46, 13);
            this.ToDateS.TabIndex = 3;
            this.ToDateS.Text = "To Date";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(428, 39);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 4;
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 131);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(747, 237);
            this.dgvSalesReport.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(704, 385);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(654, 39);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 7;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TotalAmount:";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(610, 395);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(14, 13);
            this.LblMessage.TabIndex = 9;
            this.LblMessage.Text = "0";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.ToDateS);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.FromDateS);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromDateS;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label ToDateS;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMessage;
    }
}