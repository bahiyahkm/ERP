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
            this.BtnShowItem = new System.Windows.Forms.Button();
            this.dgvItemReport = new System.Windows.Forms.DataGridView();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemReport)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowItem
            // 
            this.BtnShowItem.BackColor = System.Drawing.Color.Peru;
            this.BtnShowItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowItem.Location = new System.Drawing.Point(27, 69);
            this.BtnShowItem.Name = "BtnShowItem";
            this.BtnShowItem.Size = new System.Drawing.Size(124, 32);
            this.BtnShowItem.TabIndex = 7;
            this.BtnShowItem.Text = "Show Item Details";
            this.BtnShowItem.UseVisualStyleBackColor = false;
            this.BtnShowItem.Click += new System.EventHandler(this.BtnShowItem_Click);
            // 
            // dgvItemReport
            // 
            this.dgvItemReport.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgvItemReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemReport.Location = new System.Drawing.Point(27, 107);
            this.dgvItemReport.Name = "dgvItemReport";
            this.dgvItemReport.Size = new System.Drawing.Size(747, 237);
            this.dgvItemReport.TabIndex = 10;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Peru;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(652, 350);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(69, 27);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.Peru;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(579, 350);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(69, 27);
            this.BtnExport.TabIndex = 12;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(786, 389);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dgvItemReport);
            this.Controls.Add(this.BtnShowItem);
            this.Name = "ItemReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnShowItem;
        private System.Windows.Forms.DataGridView dgvItemReport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExport;
    }
}