﻿namespace Csharp_Login_And_Register
{
    partial class LoginForm
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
            this.labelGoToSignUp = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(213)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.labelGoToSignUp);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 1013);
            this.panel1.TabIndex = 0;
            // 
            // labelGoToSignUp
            // 
            this.labelGoToSignUp.AutoSize = true;
            this.labelGoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoToSignUp.ForeColor = System.Drawing.Color.Black;
            this.labelGoToSignUp.Location = new System.Drawing.Point(390, 928);
            this.labelGoToSignUp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelGoToSignUp.Name = "labelGoToSignUp";
            this.labelGoToSignUp.Size = new System.Drawing.Size(419, 32);
            this.labelGoToSignUp.TabIndex = 6;
            this.labelGoToSignUp.Text = "Don\'t Have an Account? SignUp";
            this.labelGoToSignUp.Click += new System.EventHandler(this.labelGoToSignUp_Click);
            this.labelGoToSignUp.MouseEnter += new System.EventHandler(this.labelGoToSignUp_MouseEnter);
            this.labelGoToSignUp.MouseLeave += new System.EventHandler(this.labelGoToSignUp_MouseLeave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Navy;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(90, 736);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(8);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(1082, 143);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(240, 535);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(926, 98);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csharp_Login_And_Register.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(90, 535);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 120);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(240, 345);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(926, 114);
            this.textBoxEmail.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csharp_Login_And_Register.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(90, 345);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-16, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 221);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Red;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1208, 8);
            this.labelClose.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(55, 55);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(149)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 221);
            this.label1.TabIndex = 0;
            this.label1.Text = "Park Hunt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 1013);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelGoToSignUp;
    }
}