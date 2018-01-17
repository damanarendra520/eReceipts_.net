namespace eReceipts
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lgn_username = new System.Windows.Forms.Label();
            this.lgn_password = new System.Windows.Forms.Label();
            this.lgn_captcha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_email = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.Label();
            this.reg_password = new System.Windows.Forms.Label();
            this.reg_user_name_value = new System.Windows.Forms.TextBox();
            this.reg_password_value = new System.Windows.Forms.TextBox();
            this.reg_email_value = new System.Windows.Forms.TextBox();
            this.lgn_captcha_value = new System.Windows.Forms.TextBox();
            this.lgn_password_value = new System.Windows.Forms.TextBox();
            this.lgn_user_name_value = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.captcha_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.regester_captcha = new System.Windows.Forms.PictureBox();
            this.reg_captcha_refresh = new System.Windows.Forms.Button();
            this.reg_captcha_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captcha_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regester_captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(758, 41);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Welcome to eReceipts application where you can manage your receipts";
            this.richTextBox1.ZoomFactor = 2F;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 90);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.captcha_image);
            this.splitContainer1.Panel1.Controls.Add(this.login_btn);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_captcha_value);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_password_value);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_user_name_value);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_captcha);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_password);
            this.splitContainer1.Panel1.Controls.Add(this.lgn_username);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.reg_captcha_value);
            this.splitContainer1.Panel2.Controls.Add(this.reg_captcha_refresh);
            this.splitContainer1.Panel2.Controls.Add(this.regester_captcha);
            this.splitContainer1.Panel2.Controls.Add(this.reg_btn);
            this.splitContainer1.Panel2.Controls.Add(this.reg_email_value);
            this.splitContainer1.Panel2.Controls.Add(this.reg_password_value);
            this.splitContainer1.Panel2.Controls.Add(this.reg_user_name_value);
            this.splitContainer1.Panel2.Controls.Add(this.reg_password);
            this.splitContainer1.Panel2.Controls.Add(this.reg_username);
            this.splitContainer1.Panel2.Controls.Add(this.reg_email);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(758, 303);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing User?";
            // 
            // lgn_username
            // 
            this.lgn_username.AutoSize = true;
            this.lgn_username.Location = new System.Drawing.Point(3, 51);
            this.lgn_username.Name = "lgn_username";
            this.lgn_username.Size = new System.Drawing.Size(61, 13);
            this.lgn_username.TabIndex = 1;
            this.lgn_username.Text = "Username :";
            // 
            // lgn_password
            // 
            this.lgn_password.AutoSize = true;
            this.lgn_password.Location = new System.Drawing.Point(3, 79);
            this.lgn_password.Name = "lgn_password";
            this.lgn_password.Size = new System.Drawing.Size(59, 13);
            this.lgn_password.TabIndex = 2;
            this.lgn_password.Text = "Password :";
            // 
            // lgn_captcha
            // 
            this.lgn_captcha.AutoSize = true;
            this.lgn_captcha.Location = new System.Drawing.Point(3, 191);
            this.lgn_captcha.Name = "lgn_captcha";
            this.lgn_captcha.Size = new System.Drawing.Size(56, 13);
            this.lgn_captcha.TabIndex = 3;
            this.lgn_captcha.Text = "Captcha : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New User?";
            // 
            // reg_email
            // 
            this.reg_email.AutoSize = true;
            this.reg_email.Location = new System.Drawing.Point(3, 111);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(35, 13);
            this.reg_email.TabIndex = 1;
            this.reg_email.Text = "Email:";
            // 
            // reg_username
            // 
            this.reg_username.AutoSize = true;
            this.reg_username.Location = new System.Drawing.Point(3, 51);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(58, 13);
            this.reg_username.TabIndex = 2;
            this.reg_username.Text = "Username:";
            // 
            // reg_password
            // 
            this.reg_password.AutoSize = true;
            this.reg_password.Location = new System.Drawing.Point(3, 79);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(56, 13);
            this.reg_password.TabIndex = 3;
            this.reg_password.Text = "Password:";
            // 
            // reg_user_name_value
            // 
            this.reg_user_name_value.Location = new System.Drawing.Point(105, 48);
            this.reg_user_name_value.Name = "reg_user_name_value";
            this.reg_user_name_value.Size = new System.Drawing.Size(184, 20);
            this.reg_user_name_value.TabIndex = 4;
            // 
            // reg_password_value
            // 
            this.reg_password_value.Location = new System.Drawing.Point(105, 79);
            this.reg_password_value.Name = "reg_password_value";
            this.reg_password_value.PasswordChar = '*';
            this.reg_password_value.Size = new System.Drawing.Size(184, 20);
            this.reg_password_value.TabIndex = 5;
            // 
            // reg_email_value
            // 
            this.reg_email_value.Location = new System.Drawing.Point(105, 111);
            this.reg_email_value.Name = "reg_email_value";
            this.reg_email_value.Size = new System.Drawing.Size(184, 20);
            this.reg_email_value.TabIndex = 6;
            // 
            // lgn_captcha_value
            // 
            this.lgn_captcha_value.Location = new System.Drawing.Point(70, 184);
            this.lgn_captcha_value.Name = "lgn_captcha_value";
            this.lgn_captcha_value.Size = new System.Drawing.Size(184, 20);
            this.lgn_captcha_value.TabIndex = 9;
            // 
            // lgn_password_value
            // 
            this.lgn_password_value.Location = new System.Drawing.Point(70, 82);
            this.lgn_password_value.Name = "lgn_password_value";
            this.lgn_password_value.PasswordChar = '*';
            this.lgn_password_value.Size = new System.Drawing.Size(184, 20);
            this.lgn_password_value.TabIndex = 8;
            // 
            // lgn_user_name_value
            // 
            this.lgn_user_name_value.Location = new System.Drawing.Point(70, 51);
            this.lgn_user_name_value.Name = "lgn_user_name_value";
            this.lgn_user_name_value.Size = new System.Drawing.Size(184, 20);
            this.lgn_user_name_value.TabIndex = 7;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(160, 253);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.register_new_user);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(101, 253);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_click);
            // 
            // captcha_image
            // 
            this.captcha_image.Location = new System.Drawing.Point(70, 111);
            this.captcha_image.Name = "captcha_image";
            this.captcha_image.Size = new System.Drawing.Size(140, 52);
            this.captcha_image.TabIndex = 11;
            this.captcha_image.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regester_captcha
            // 
            this.regester_captcha.Location = new System.Drawing.Point(105, 152);
            this.regester_captcha.Name = "regester_captcha";
            this.regester_captcha.Size = new System.Drawing.Size(163, 52);
            this.regester_captcha.TabIndex = 8;
            this.regester_captcha.TabStop = false;
            // 
            // reg_captcha_refresh
            // 
            this.reg_captcha_refresh.Location = new System.Drawing.Point(274, 165);
            this.reg_captcha_refresh.Name = "reg_captcha_refresh";
            this.reg_captcha_refresh.Size = new System.Drawing.Size(75, 23);
            this.reg_captcha_refresh.TabIndex = 9;
            this.reg_captcha_refresh.Text = "Refresh";
            this.reg_captcha_refresh.UseVisualStyleBackColor = true;
            this.reg_captcha_refresh.Click += new System.EventHandler(this.reg_captcha_refresh_Click);
            // 
            // reg_captcha_value
            // 
            this.reg_captcha_value.Location = new System.Drawing.Point(105, 210);
            this.reg_captcha_value.Name = "reg_captcha_value";
            this.reg_captcha_value.Size = new System.Drawing.Size(184, 20);
            this.reg_captcha_value.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Captcha";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 405);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "eReceipts Application";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.captcha_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regester_captcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox lgn_captcha_value;
        private System.Windows.Forms.TextBox lgn_password_value;
        private System.Windows.Forms.TextBox lgn_user_name_value;
        private System.Windows.Forms.Label lgn_captcha;
        private System.Windows.Forms.Label lgn_password;
        private System.Windows.Forms.Label lgn_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox reg_email_value;
        private System.Windows.Forms.TextBox reg_password_value;
        private System.Windows.Forms.TextBox reg_user_name_value;
        private System.Windows.Forms.Label reg_password;
        private System.Windows.Forms.Label reg_username;
        private System.Windows.Forms.Label reg_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox captcha_image;
        private System.Windows.Forms.Button reg_captcha_refresh;
        private System.Windows.Forms.PictureBox regester_captcha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_captcha_value;
    }
}