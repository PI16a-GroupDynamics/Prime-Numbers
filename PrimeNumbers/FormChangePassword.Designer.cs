namespace MetroFramework_test_at_a_new_project
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbConfirmPassword = new System.Windows.Forms.TextBox();
            this.TbOldPassword = new System.Windows.Forms.TextBox();
            this.BtChangePassword = new System.Windows.Forms.Button();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.BtClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.SuspendLayout();
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPassword.Location = new System.Drawing.Point(155, 76);
            this.TbPassword.MaxLength = 100;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(164, 29);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbOldPassword_KeyDown);
            // 
            // TbConfirmPassword
            // 
            this.TbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbConfirmPassword.Location = new System.Drawing.Point(155, 111);
            this.TbConfirmPassword.MaxLength = 100;
            this.TbConfirmPassword.Name = "TbConfirmPassword";
            this.TbConfirmPassword.PasswordChar = '*';
            this.TbConfirmPassword.Size = new System.Drawing.Size(164, 29);
            this.TbConfirmPassword.TabIndex = 3;
            this.TbConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbOldPassword_KeyDown);
            // 
            // TbOldPassword
            // 
            this.TbOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbOldPassword.Location = new System.Drawing.Point(155, 41);
            this.TbOldPassword.MaxLength = 100;
            this.TbOldPassword.Name = "TbOldPassword";
            this.TbOldPassword.PasswordChar = '*';
            this.TbOldPassword.Size = new System.Drawing.Size(164, 29);
            this.TbOldPassword.TabIndex = 1;
            this.TbOldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbOldPassword_KeyDown);
            this.TbOldPassword.Leave += new System.EventHandler(this.TbOldPassword_Leave);
            // 
            // BtChangePassword
            // 
            this.BtChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtChangePassword.Location = new System.Drawing.Point(155, 165);
            this.BtChangePassword.Name = "BtChangePassword";
            this.BtChangePassword.Size = new System.Drawing.Size(164, 32);
            this.BtChangePassword.TabIndex = 4;
            this.BtChangePassword.Text = "Сохранить";
            this.BtChangePassword.UseVisualStyleBackColor = true;
            this.BtChangePassword.Click += new System.EventHandler(this.BtChangePassword_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.Location = new System.Drawing.Point(20, 45);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(123, 25);
            this.radLabel1.TabIndex = 8;
            this.radLabel1.Text = "Старый пароль";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.Location = new System.Drawing.Point(52, 65);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 9;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel3.Location = new System.Drawing.Point(20, 115);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(106, 25);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "Подтвердите";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel4.Location = new System.Drawing.Point(20, 80);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(118, 25);
            this.radLabel4.TabIndex = 11;
            this.radLabel4.Text = "Новый пароль";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel5.Location = new System.Drawing.Point(20, 10);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(113, 25);
            this.radLabel5.TabIndex = 13;
            this.radLabel5.Text = "Пользователь";
            // 
            // TbUsername
            // 
            this.TbUsername.Enabled = false;
            this.TbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbUsername.Location = new System.Drawing.Point(155, 6);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(164, 29);
            this.TbUsername.TabIndex = 0;
            // 
            // BtClose
            // 
            this.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Location = new System.Drawing.Point(20, 165);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(118, 32);
            this.BtClose.TabIndex = 14;
            this.BtClose.Text = "Закрыть";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 209);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbConfirmPassword);
            this.Controls.Add(this.TbOldPassword);
            this.Controls.Add(this.BtChangePassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangePassword";
            this.Text = "Изменение пароля";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbConfirmPassword;
        private System.Windows.Forms.TextBox TbOldPassword;
        private System.Windows.Forms.Button BtChangePassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Button BtClose;
    }
}