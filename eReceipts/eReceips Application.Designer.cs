namespace eReceipts
{
    partial class eReceipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eReceipts));
            this.add_receipt = new System.Windows.Forms.Button();
            this.view_receipt_btn = new System.Windows.Forms.Button();
            this.chartViewData = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_receipt
            // 
            this.add_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_receipt.Location = new System.Drawing.Point(72, 83);
            this.add_receipt.Name = "add_receipt";
            this.add_receipt.Size = new System.Drawing.Size(88, 23);
            this.add_receipt.TabIndex = 0;
            this.add_receipt.Text = "Add Receipt";
            this.add_receipt.UseVisualStyleBackColor = true;
            this.add_receipt.Click += new System.EventHandler(this.Add_receipt_Click);
            // 
            // view_receipt_btn
            // 
            this.view_receipt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_receipt_btn.Location = new System.Drawing.Point(228, 83);
            this.view_receipt_btn.Name = "view_receipt_btn";
            this.view_receipt_btn.Size = new System.Drawing.Size(102, 23);
            this.view_receipt_btn.TabIndex = 1;
            this.view_receipt_btn.Text = "View Receipt";
            this.view_receipt_btn.UseVisualStyleBackColor = true;
            this.view_receipt_btn.Click += new System.EventHandler(this.view_receipt_clk);
            // 
            // chartViewData
            // 
            this.chartViewData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartViewData.Location = new System.Drawing.Point(72, 137);
            this.chartViewData.Name = "chartViewData";
            this.chartViewData.Size = new System.Drawing.Size(88, 23);
            this.chartViewData.TabIndex = 2;
            this.chartViewData.Text = "Chart View";
            this.chartViewData.UseVisualStyleBackColor = true;
            this.chartViewData.Click += new System.EventHandler(this.viewChartDataBtn);
            // 
            // search_button
            // 
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.Location = new System.Drawing.Point(228, 137);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 23);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(344, 22);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(0, 13);
            this.welcome_label.TabIndex = 4;
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Location = new System.Drawing.Point(347, 54);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // eReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 249);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.chartViewData);
            this.Controls.Add(this.view_receipt_btn);
            this.Controls.Add(this.add_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "eReceipts";
            this.Text = "eReceips Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_receipt;
        private System.Windows.Forms.Button view_receipt_btn;
        private System.Windows.Forms.Button chartViewData;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button logout_btn;
    }
}

