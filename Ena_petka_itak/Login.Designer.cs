namespace Ena_petka_itak
{
    partial class Login
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
            this.userloginbox = new System.Windows.Forms.TextBox();
            this.userpasswordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userloginbox
            // 
            this.userloginbox.Location = new System.Drawing.Point(119, 35);
            this.userloginbox.Name = "userloginbox";
            this.userloginbox.Size = new System.Drawing.Size(100, 20);
            this.userloginbox.TabIndex = 0;
            // 
            // userpasswordbox
            // 
            this.userpasswordbox.Location = new System.Drawing.Point(119, 75);
            this.userpasswordbox.Name = "userpasswordbox";
            this.userpasswordbox.Size = new System.Drawing.Size(100, 20);
            this.userpasswordbox.TabIndex = 1;
            this.userpasswordbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSUMER DATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(27, 143);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "login";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(144, 143);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(75, 23);
            this.registerbutton.TabIndex = 4;
            this.registerbutton.Text = "register";
            this.registerbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(234, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userpasswordbox);
            this.Controls.Add(this.userloginbox);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userloginbox;
        private System.Windows.Forms.TextBox userpasswordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

