namespace eReceipts
{
    partial class addReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReceipt));
            this.receipt_No = new System.Windows.Forms.Label();
            this.receipt_date = new System.Windows.Forms.Label();
            this.receipt_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_receipt = new System.Windows.Forms.Label();
            this.receipt_savings = new System.Windows.Forms.Label();
            this.receipt_place = new System.Windows.Forms.Label();
            this.receipt_number = new System.Windows.Forms.TextBox();
            this.txtbox_place = new System.Windows.Forms.TextBox();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.txtbox_savings = new System.Windows.Forms.TextBox();
            this.add_receipt_button = new System.Windows.Forms.Button();
            this.button_cancel_receipt = new System.Windows.Forms.Button();
            this.button_add_receipt = new System.Windows.Forms.Button();
            this.receipt_upload_image = new System.Windows.Forms.PictureBox();
            this.txtbox_date1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_upload_image)).BeginInit();
            this.SuspendLayout();
            // 
            // receipt_No
            // 
            this.receipt_No.AutoSize = true;
            this.receipt_No.Location = new System.Drawing.Point(27, 44);
            this.receipt_No.Name = "receipt_No";
            this.receipt_No.Size = new System.Drawing.Size(51, 13);
            this.receipt_No.TabIndex = 0;
            this.receipt_No.Text = "Receipt#";
            // 
            // receipt_date
            // 
            this.receipt_date.AutoSize = true;
            this.receipt_date.Location = new System.Drawing.Point(27, 81);
            this.receipt_date.Name = "receipt_date";
            this.receipt_date.Size = new System.Drawing.Size(30, 13);
            this.receipt_date.TabIndex = 1;
            this.receipt_date.Text = "Date";
            // 
            // receipt_amount
            // 
            this.receipt_amount.AutoSize = true;
            this.receipt_amount.Location = new System.Drawing.Point(27, 120);
            this.receipt_amount.Name = "receipt_amount";
            this.receipt_amount.Size = new System.Drawing.Size(43, 13);
            this.receipt_amount.TabIndex = 2;
            this.receipt_amount.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-495, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receipt#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-495, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Receipt#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-495, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Receipt#";
            // 
            // add_receipt
            // 
            this.add_receipt.AutoSize = true;
            this.add_receipt.Location = new System.Drawing.Point(27, 234);
            this.add_receipt.Name = "add_receipt";
            this.add_receipt.Size = new System.Drawing.Size(57, 13);
            this.add_receipt.TabIndex = 8;
            this.add_receipt.Text = "Add Photo";
            // 
            // receipt_savings
            // 
            this.receipt_savings.AutoSize = true;
            this.receipt_savings.Location = new System.Drawing.Point(27, 197);
            this.receipt_savings.Name = "receipt_savings";
            this.receipt_savings.Size = new System.Drawing.Size(45, 13);
            this.receipt_savings.TabIndex = 7;
            this.receipt_savings.Text = "Savings";
            // 
            // receipt_place
            // 
            this.receipt_place.AutoSize = true;
            this.receipt_place.Location = new System.Drawing.Point(27, 160);
            this.receipt_place.Name = "receipt_place";
            this.receipt_place.Size = new System.Drawing.Size(34, 13);
            this.receipt_place.TabIndex = 6;
            this.receipt_place.Text = "Place";
            // 
            // receipt_number
            // 
            this.receipt_number.Location = new System.Drawing.Point(174, 44);
            this.receipt_number.Name = "receipt_number";
            this.receipt_number.Size = new System.Drawing.Size(238, 20);
            this.receipt_number.TabIndex = 9;
            this.receipt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReceiptNoKeyPressed);
            // 
            // txtbox_place
            // 
            this.txtbox_place.Location = new System.Drawing.Point(174, 153);
            this.txtbox_place.Name = "txtbox_place";
            this.txtbox_place.Size = new System.Drawing.Size(238, 20);
            this.txtbox_place.TabIndex = 12;
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.Location = new System.Drawing.Point(174, 113);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(238, 20);
            this.txtbox_amount.TabIndex = 11;
            this.txtbox_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReceiptNoKeyPressed);
            // 
            // txtbox_savings
            // 
            this.txtbox_savings.Location = new System.Drawing.Point(174, 190);
            this.txtbox_savings.Name = "txtbox_savings";
            this.txtbox_savings.Size = new System.Drawing.Size(238, 20);
            this.txtbox_savings.TabIndex = 13;
            this.txtbox_savings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReceiptNoKeyPressed);
            // 
            // add_receipt_button
            // 
            this.add_receipt_button.Location = new System.Drawing.Point(174, 234);
            this.add_receipt_button.Name = "add_receipt_button";
            this.add_receipt_button.Size = new System.Drawing.Size(238, 23);
            this.add_receipt_button.TabIndex = 14;
            this.add_receipt_button.Text = "Pick Image";
            this.add_receipt_button.UseVisualStyleBackColor = true;
            this.add_receipt_button.Click += new System.EventHandler(this.upload_Button);
            // 
            // button_cancel_receipt
            // 
            this.button_cancel_receipt.Location = new System.Drawing.Point(71, 501);
            this.button_cancel_receipt.Name = "button_cancel_receipt";
            this.button_cancel_receipt.Size = new System.Drawing.Size(75, 23);
            this.button_cancel_receipt.TabIndex = 16;
            this.button_cancel_receipt.Text = "Cancel";
            this.button_cancel_receipt.UseVisualStyleBackColor = true;
            this.button_cancel_receipt.Click += new System.EventHandler(this.cancel_clk);
            // 
            // button_add_receipt
            // 
            this.button_add_receipt.Location = new System.Drawing.Point(270, 501);
            this.button_add_receipt.Name = "button_add_receipt";
            this.button_add_receipt.Size = new System.Drawing.Size(75, 23);
            this.button_add_receipt.TabIndex = 17;
            this.button_add_receipt.Text = "Add Receipt";
            this.button_add_receipt.UseVisualStyleBackColor = true;
            this.button_add_receipt.Click += new System.EventHandler(this.add_receipt_func);
            // 
            // receipt_upload_image
            // 
            this.receipt_upload_image.Location = new System.Drawing.Point(30, 284);
            this.receipt_upload_image.Name = "receipt_upload_image";
            this.receipt_upload_image.Size = new System.Drawing.Size(390, 160);
            this.receipt_upload_image.TabIndex = 18;
            this.receipt_upload_image.TabStop = false;
            // 
            // txtbox_date1
            // 
            this.txtbox_date1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtbox_date1.Location = new System.Drawing.Point(174, 75);
            this.txtbox_date1.Name = "txtbox_date1";
            this.txtbox_date1.Size = new System.Drawing.Size(238, 20);
            this.txtbox_date1.TabIndex = 19;
            this.txtbox_date1.Value = new System.DateTime(2018, 1, 6, 8, 46, 3, 0);
            // 
            // addReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 539);
            this.Controls.Add(this.txtbox_date1);
            this.Controls.Add(this.receipt_upload_image);
            this.Controls.Add(this.button_add_receipt);
            this.Controls.Add(this.button_cancel_receipt);
            this.Controls.Add(this.add_receipt_button);
            this.Controls.Add(this.txtbox_savings);
            this.Controls.Add(this.txtbox_place);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.receipt_number);
            this.Controls.Add(this.add_receipt);
            this.Controls.Add(this.receipt_savings);
            this.Controls.Add(this.receipt_place);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receipt_amount);
            this.Controls.Add(this.receipt_date);
            this.Controls.Add(this.receipt_No);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addReceipt";
            this.Text = "Add Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.receipt_upload_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receipt_No;
        private System.Windows.Forms.Label receipt_date;
        private System.Windows.Forms.Label receipt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label add_receipt;
        private System.Windows.Forms.Label receipt_savings;
        private System.Windows.Forms.Label receipt_place;
        private System.Windows.Forms.TextBox receipt_number;
        private System.Windows.Forms.TextBox txtbox_place;
        private System.Windows.Forms.TextBox txtbox_amount;
        private System.Windows.Forms.TextBox txtbox_savings;
        private System.Windows.Forms.Button add_receipt_button;
        private System.Windows.Forms.Button button_cancel_receipt;
        private System.Windows.Forms.Button button_add_receipt;
        private System.Windows.Forms.PictureBox receipt_upload_image;
        private System.Windows.Forms.DateTimePicker txtbox_date1;
    }
}