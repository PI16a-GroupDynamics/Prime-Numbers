﻿namespace MetroFramework_test_at_a_new_project
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.PnConfirmPassword = new System.Windows.Forms.Panel();
            this.TbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSignIn = new System.Windows.Forms.Button();
            this.BtSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnConfirmPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnConfirmPassword
            // 
            this.PnConfirmPassword.Controls.Add(this.TbConfirmPassword);
            this.PnConfirmPassword.Controls.Add(this.label3);
            this.PnConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PnConfirmPassword.Location = new System.Drawing.Point(12, 126);
            this.PnConfirmPassword.Name = "PnConfirmPassword";
            this.PnConfirmPassword.Size = new System.Drawing.Size(203, 67);
            this.PnConfirmPassword.TabIndex = 2;
            this.PnConfirmPassword.Visible = false;
            // 
            // TbConfirmPassword
            // 
            this.TbConfirmPassword.Location = new System.Drawing.Point(11, 34);
            this.TbConfirmPassword.MaxLength = 100;
            this.TbConfirmPassword.Name = "TbConfirmPassword";
            this.TbConfirmPassword.PasswordChar = '*';
            this.TbConfirmPassword.Size = new System.Drawing.Size(164, 29);
            this.TbConfirmPassword.TabIndex = 2;
            this.TbConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            this.TbConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbConfirmPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подтвердите пароль";
            // 
            // TbUserName
            // 
            this.TbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbUserName.Location = new System.Drawing.Point(23, 36);
            this.TbUserName.MaxLength = 50;
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(164, 29);
            this.TbUserName.TabIndex = 0;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPassword.Location = new System.Drawing.Point(23, 91);
            this.TbPassword.MaxLength = 100;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(164, 29);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            this.TbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль";
            // 
            // BtSignIn
            // 
            this.BtSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtSignIn.Location = new System.Drawing.Point(258, 36);
            this.BtSignIn.Name = "BtSignIn";
            this.BtSignIn.Size = new System.Drawing.Size(111, 31);
            this.BtSignIn.TabIndex = 3;
            this.BtSignIn.Text = "Вход";
            this.BtSignIn.UseVisualStyleBackColor = true;
            this.BtSignIn.Click += new System.EventHandler(this.BtSignIn_Click);
            // 
            // BtSignUp
            // 
            this.BtSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtSignUp.Location = new System.Drawing.Point(258, 73);
            this.BtSignUp.Name = "BtSignUp";
            this.BtSignUp.Size = new System.Drawing.Size(111, 31);
            this.BtSignUp.TabIndex = 4;
            this.BtSignUp.Text = "Регистрация";
            this.BtSignUp.UseVisualStyleBackColor = true;
            this.BtSignUp.Click += new System.EventHandler(this.BtSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя пользователя";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 205);
            this.Controls.Add(this.PnConfirmPassword);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSignIn);
            this.Controls.Add(this.BtSignUp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignIn";
            this.Text = "Вход/регистрация";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignIn_FormClosed);
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            this.PnConfirmPassword.ResumeLayout(false);
            this.PnConfirmPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnConfirmPassword;
        private System.Windows.Forms.TextBox TbConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtSignIn;
        private System.Windows.Forms.Button BtSignUp;
        private System.Windows.Forms.Label label1;
    }
}