namespace MetroFramework_test_at_a_new_project
{
    partial class FormChangeUsername
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
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TbNewUsername = new System.Windows.Forms.TextBox();
            this.TbOldUsername = new System.Windows.Forms.TextBox();
            this.BtChangeUsername = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel4.Location = new System.Drawing.Point(8, 51);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(107, 25);
            this.radLabel4.TabIndex = 16;
            this.radLabel4.Text = "Новый логин";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.Location = new System.Drawing.Point(31, 63);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 15;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.Location = new System.Drawing.Point(8, 16);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(112, 25);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Старый логин";
            // 
            // TbNewUsername
            // 
            this.TbNewUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbNewUsername.Location = new System.Drawing.Point(143, 47);
            this.TbNewUsername.MaxLength = 100;
            this.TbNewUsername.Name = "TbNewUsername";
            this.TbNewUsername.Size = new System.Drawing.Size(164, 29);
            this.TbNewUsername.TabIndex = 13;
            // 
            // TbOldUsername
            // 
            this.TbOldUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbOldUsername.Location = new System.Drawing.Point(143, 12);
            this.TbOldUsername.MaxLength = 100;
            this.TbOldUsername.Name = "TbOldUsername";
            this.TbOldUsername.ReadOnly = true;
            this.TbOldUsername.Size = new System.Drawing.Size(164, 29);
            this.TbOldUsername.TabIndex = 12;
            // 
            // BtChangeUsername
            // 
            this.BtChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtChangeUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtChangeUsername.Location = new System.Drawing.Point(143, 82);
            this.BtChangeUsername.Name = "BtChangeUsername";
            this.BtChangeUsername.Size = new System.Drawing.Size(164, 32);
            this.BtChangeUsername.TabIndex = 17;
            this.BtChangeUsername.Text = "Сохранить";
            this.BtChangeUsername.UseVisualStyleBackColor = true;
            this.BtChangeUsername.Click += new System.EventHandler(this.BtChangeUsername_Click);
            // 
            // BtClose
            // 
            this.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Location = new System.Drawing.Point(8, 82);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(123, 32);
            this.BtClose.TabIndex = 18;
            this.BtClose.Text = "Закрыть";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // FormChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 117);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtChangeUsername);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TbNewUsername);
            this.Controls.Add(this.TbOldUsername);
            this.Name = "FormChangeUsername";
            this.Text = "FormChangeUsername";
            this.Load += new System.EventHandler(this.FormChangeUsername_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.TextBox TbNewUsername;
        private System.Windows.Forms.TextBox TbOldUsername;
        private System.Windows.Forms.Button BtChangeUsername;
        private System.Windows.Forms.Button BtClose;
    }
}