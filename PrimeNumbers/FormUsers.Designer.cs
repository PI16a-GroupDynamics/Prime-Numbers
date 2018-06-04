namespace MetroFramework_test_at_a_new_project
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.TableUsers = new System.Windows.Forms.DataGridView();
            this.Usernames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSaveChanges = new System.Windows.Forms.Button();
            this.ButtonCancelChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableUsers
            // 
            this.TableUsers.AllowUserToAddRows = false;
            this.TableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usernames,
            this.IsAdmin,
            this.Passwords});
            this.TableUsers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TableUsers.Location = new System.Drawing.Point(12, 55);
            this.TableUsers.MinimumSize = new System.Drawing.Size(200, 50);
            this.TableUsers.MultiSelect = false;
            this.TableUsers.Name = "TableUsers";
            this.TableUsers.RowHeadersWidth = 25;
            this.TableUsers.Size = new System.Drawing.Size(330, 217);
            this.TableUsers.TabIndex = 0;
            this.TableUsers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TableUsers_CellValidating);
            this.TableUsers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TableUsers_UserDeletingRow);
            // 
            // Usernames
            // 
            this.Usernames.HeaderText = "Пользователь";
            this.Usernames.Name = "Usernames";
            this.Usernames.ReadOnly = true;
            this.Usernames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // IsAdmin
            // 
            this.IsAdmin.HeaderText = "Администратор";
            this.IsAdmin.Name = "IsAdmin";
            // 
            // Passwords
            // 
            this.Passwords.HeaderText = "Зашифрованный пароль";
            this.Passwords.Name = "Passwords";
            this.Passwords.ReadOnly = true;
            this.Passwords.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ButtonSaveChanges
            // 
            this.ButtonSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonSaveChanges.Location = new System.Drawing.Point(348, 55);
            this.ButtonSaveChanges.Name = "ButtonSaveChanges";
            this.ButtonSaveChanges.Size = new System.Drawing.Size(107, 33);
            this.ButtonSaveChanges.TabIndex = 1;
            this.ButtonSaveChanges.Text = "Сохранить изменения";
            this.ButtonSaveChanges.UseVisualStyleBackColor = true;
            this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // ButtonCancelChanges
            // 
            this.ButtonCancelChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancelChanges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonCancelChanges.Location = new System.Drawing.Point(348, 239);
            this.ButtonCancelChanges.Name = "ButtonCancelChanges";
            this.ButtonCancelChanges.Size = new System.Drawing.Size(107, 33);
            this.ButtonCancelChanges.TabIndex = 2;
            this.ButtonCancelChanges.Text = "Отменить изменения";
            this.ButtonCancelChanges.UseVisualStyleBackColor = true;
            this.ButtonCancelChanges.Click += new System.EventHandler(this.ButtonCancelChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MetroFramework_test_at_a_new_project.Properties.Resources.Arrow_Right_Green;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonCancelChanges);
            this.Controls.Add(this.ButtonSaveChanges);
            this.Controls.Add(this.TableUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsers";
            this.Text = "Пользователи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableUsers;
        private System.Windows.Forms.Button ButtonSaveChanges;
        private System.Windows.Forms.Button ButtonCancelChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usernames;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwords;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}