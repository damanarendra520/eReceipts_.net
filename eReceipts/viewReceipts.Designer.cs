namespace eReceipts
{
    partial class viewReceipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewReceipts));
            this.viewReceiptsData = new System.Windows.Forms.DataGridView();
            this.reloadTableDataReceipts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewReceiptsData)).BeginInit();
            this.SuspendLayout();
            // 
            // viewReceiptsData
            // 
            this.viewReceiptsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewReceiptsData.Location = new System.Drawing.Point(12, 41);
            this.viewReceiptsData.Name = "viewReceiptsData";
            this.viewReceiptsData.Size = new System.Drawing.Size(534, 270);
            this.viewReceiptsData.TabIndex = 0;
            // 
            // reloadTableDataReceipts
            // 
            this.reloadTableDataReceipts.Location = new System.Drawing.Point(471, 12);
            this.reloadTableDataReceipts.Name = "reloadTableDataReceipts";
            this.reloadTableDataReceipts.Size = new System.Drawing.Size(75, 23);
            this.reloadTableDataReceipts.TabIndex = 1;
            this.reloadTableDataReceipts.Text = "Reload";
            this.reloadTableDataReceipts.UseVisualStyleBackColor = true;
            this.reloadTableDataReceipts.Click += new System.EventHandler(this.view_receipts_data);
            // 
            // viewReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 324);
            this.Controls.Add(this.reloadTableDataReceipts);
            this.Controls.Add(this.viewReceiptsData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "viewReceipts";
            this.Text = "viewReceipts";
            ((System.ComponentModel.ISupportInitialize)(this.viewReceiptsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewReceiptsData;
        private System.Windows.Forms.Button reloadTableDataReceipts;
    }
}