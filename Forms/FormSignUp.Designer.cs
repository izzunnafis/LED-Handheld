
namespace LED_Handheld_Project.Forms
{
    partial class FormSignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSignup = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 37);
            this.panel1.TabIndex = 0;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbClose.Location = new System.Drawing.Point(516, 7);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 24);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 115);
            this.panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(236, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(72, 72);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbShowPassword);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.tbConfirmPass);
            this.panel3.Controls.Add(this.iconPictureBox5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.tbPassword);
            this.panel3.Controls.Add(this.iconPictureBox4);
            this.panel3.Controls.Add(this.btnSignup);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.tbEmail);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.iconPictureBox3);
            this.panel3.Controls.Add(this.tbUsername);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Location = new System.Drawing.Point(28, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 416);
            this.panel3.TabIndex = 4;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbShowPassword.Location = new System.Drawing.Point(53, 276);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(129, 21);
            this.cbShowPassword.TabIndex = 13;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(53, 258);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(432, 1);
            this.panel7.TabIndex = 12;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.tbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbConfirmPass.Location = new System.Drawing.Point(53, 227);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(432, 23);
            this.tbConfirmPass.TabIndex = 11;
            this.tbConfirmPass.Text = "Confirm Password";
            this.tbConfirmPass.Click += new System.EventHandler(this.tbConfirmPass_Click);
            this.tbConfirmPass.TextChanged += new System.EventHandler(this.tbConfirmPass_TextChanged_1);
            this.tbConfirmPass.Enter += new System.EventHandler(this.tbConfirmPass_Enter);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.Location = new System.Drawing.Point(15, 227);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 10;
            this.iconPictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(53, 183);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 1);
            this.panel6.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.Location = new System.Drawing.Point(53, 152);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(432, 23);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.Text = "Password";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(15, 152);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 7;
            this.iconPictureBox4.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignup.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSignup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignup.Location = new System.Drawing.Point(0, 358);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(488, 58);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "&Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(53, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 1);
            this.panel5.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbEmail.Location = new System.Drawing.Point(53, 80);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(432, 23);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.Text = "Email";
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(53, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 1);
            this.panel4.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(15, 80);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 3;
            this.iconPictureBox3.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbUsername.Location = new System.Drawing.Point(53, 14);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(432, 23);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Username";
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(15, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(545, 678);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSignup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox tbUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}