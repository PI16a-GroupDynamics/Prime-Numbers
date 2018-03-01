namespace ГДК
{
    partial class PanelRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.PnConfirmPassword.Location = new System.Drawing.Point(13, 90);
            this.PnConfirmPassword.Name = "PnConfirmPassword";
            this.PnConfirmPassword.Size = new System.Drawing.Size(200, 47);
            this.PnConfirmPassword.TabIndex = 15;
            this.PnConfirmPassword.Visible = false;
            // 
            // TbConfirmPassword
            // 
            this.TbConfirmPassword.Location = new System.Drawing.Point(3, 22);
            this.TbConfirmPassword.Name = "TbConfirmPassword";
            this.TbConfirmPassword.PasswordChar = '*';
            this.TbConfirmPassword.Size = new System.Drawing.Size(164, 20);
            this.TbConfirmPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подтвердите пароль";
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(13, 20);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(164, 20);
            this.TbUserName.TabIndex = 9;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(13, 64);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(164, 20);
            this.TbPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // BtSignIn
            // 
            this.BtSignIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSignIn.Location = new System.Drawing.Point(217, 17);
            this.BtSignIn.Name = "BtSignIn";
            this.BtSignIn.Size = new System.Drawing.Size(83, 23);
            this.BtSignIn.TabIndex = 11;
            this.BtSignIn.Text = "Войти";
            this.BtSignIn.UseVisualStyleBackColor = true;
            // 
            // BtSignUp
            // 
            this.BtSignUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSignUp.Location = new System.Drawing.Point(217, 43);
            this.BtSignUp.Name = "BtSignUp";
            this.BtSignUp.Size = new System.Drawing.Size(83, 23);
            this.BtSignUp.TabIndex = 12;
            this.BtSignUp.Text = "Регистрация";
            this.BtSignUp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя пользователя";
            // 
            // PanelRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnConfirmPassword);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSignIn);
            this.Controls.Add(this.BtSignUp);
            this.Controls.Add(this.label1);
            this.Name = "PanelRegistration";
            this.Size = new System.Drawing.Size(316, 229);
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
