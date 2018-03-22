#pragma warning disable 618
namespace MetroFramework_test_at_a_new_project
{
    partial class Form1
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
            this.TabPageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.LabelForExcel = new MetroFramework.Controls.MetroLabel();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.ButtonViewLog = new System.Windows.Forms.Button();
            this.TabPageSettings = new MetroFramework.Controls.MetroTabPage();
            this.PanelUser = new MetroFramework.Controls.MetroPanel();
            this.PanelPassword = new MetroFramework.Controls.MetroPanel();
            this.ButtonChangePassword = new MetroFramework.Controls.MetroButton();
            this.BoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.ButtonChangeUsername = new MetroFramework.Controls.MetroButton();
            this.ButtonChangeUser = new MetroFramework.Controls.MetroButton();
            this.BoxCurrentUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.PanelSaveResultTo = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BoxDirectoryForResult = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btAbout = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CBoxTypeOfFile = new MetroFramework.Controls.MetroComboBox();
            this.TabPageWork = new MetroFramework.Controls.MetroTabPage();
            this.ButtonStart = new MetroFramework.Controls.MetroButton();
            this.PanelResult = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BoxResult = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BoxNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabPageAdmin.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelSaveResultTo.SuspendLayout();
            this.TabPageWork.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageAdmin
            // 
            this.TabPageAdmin.Controls.Add(this.LabelForExcel);
            this.TabPageAdmin.Controls.Add(this.ButtonUsers);
            this.TabPageAdmin.Controls.Add(this.ButtonViewLog);
            this.TabPageAdmin.HorizontalScrollbarBarColor = true;
            this.TabPageAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.HorizontalScrollbarSize = 12;
            this.TabPageAdmin.Location = new System.Drawing.Point(4, 38);
            this.TabPageAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageAdmin.Name = "TabPageAdmin";
            this.TabPageAdmin.Size = new System.Drawing.Size(569, 437);
            this.TabPageAdmin.TabIndex = 2;
            this.TabPageAdmin.Text = "Админ";
            this.TabPageAdmin.VerticalScrollbarBarColor = true;
            this.TabPageAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.VerticalScrollbarSize = 13;
            // 
            // LabelForExcel
            // 
            this.LabelForExcel.AutoSize = true;
            this.LabelForExcel.Location = new System.Drawing.Point(309, 116);
            this.LabelForExcel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelForExcel.Name = "LabelForExcel";
            this.LabelForExcel.Size = new System.Drawing.Size(0, 0);
            this.LabelForExcel.TabIndex = 11;
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Location = new System.Drawing.Point(24, 68);
            this.ButtonUsers.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(141, 44);
            this.ButtonUsers.TabIndex = 8;
            this.ButtonUsers.Text = "Учетные записи пользователей";
            this.ButtonUsers.UseVisualStyleBackColor = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonViewLog
            // 
            this.ButtonViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewLog.Location = new System.Drawing.Point(309, 84);
            this.ButtonViewLog.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonViewLog.Name = "ButtonViewLog";
            this.ButtonViewLog.Size = new System.Drawing.Size(141, 28);
            this.ButtonViewLog.TabIndex = 7;
            this.ButtonViewLog.Text = "Логи";
            this.ButtonViewLog.UseVisualStyleBackColor = true;
            this.ButtonViewLog.Click += new System.EventHandler(this.ButtonViewLog_Click);
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageSettings.Controls.Add(this.PanelUser);
            this.TabPageSettings.Controls.Add(this.metroButton2);
            this.TabPageSettings.Controls.Add(this.PanelSaveResultTo);
            this.TabPageSettings.Controls.Add(this.btAbout);
            this.TabPageSettings.Controls.Add(this.metroLabel2);
            this.TabPageSettings.Controls.Add(this.CBoxTypeOfFile);
            this.TabPageSettings.HorizontalScrollbarBarColor = true;
            this.TabPageSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageSettings.HorizontalScrollbarSize = 12;
            this.TabPageSettings.Location = new System.Drawing.Point(4, 38);
            this.TabPageSettings.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Size = new System.Drawing.Size(569, 437);
            this.TabPageSettings.TabIndex = 1;
            this.TabPageSettings.Text = "Настройки";
            this.TabPageSettings.VerticalScrollbarBarColor = true;
            this.TabPageSettings.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageSettings.VerticalScrollbarSize = 13;
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.PanelPassword);
            this.PanelUser.Controls.Add(this.ButtonChangeUsername);
            this.PanelUser.Controls.Add(this.ButtonChangeUser);
            this.PanelUser.Controls.Add(this.BoxCurrentUser);
            this.PanelUser.Controls.Add(this.metroLabel6);
            this.PanelUser.HorizontalScrollbarBarColor = true;
            this.PanelUser.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelUser.HorizontalScrollbarSize = 12;
            this.PanelUser.Location = new System.Drawing.Point(17, 208);
            this.PanelUser.Margin = new System.Windows.Forms.Padding(4);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(480, 144);
            this.PanelUser.TabIndex = 22;
            this.PanelUser.VerticalScrollbarBarColor = true;
            this.PanelUser.VerticalScrollbarHighlightOnWheel = false;
            this.PanelUser.VerticalScrollbarSize = 13;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.ButtonChangePassword);
            this.PanelPassword.Controls.Add(this.BoxPassword);
            this.PanelPassword.HorizontalScrollbarBarColor = true;
            this.PanelPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelPassword.HorizontalScrollbarSize = 12;
            this.PanelPassword.Location = new System.Drawing.Point(5, 70);
            this.PanelPassword.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(359, 28);
            this.PanelPassword.TabIndex = 23;
            this.PanelPassword.VerticalScrollbarBarColor = true;
            this.PanelPassword.VerticalScrollbarHighlightOnWheel = false;
            this.PanelPassword.VerticalScrollbarSize = 13;
            this.PanelPassword.Leave += new System.EventHandler(this.PanelPassword_Leave);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangePassword.Location = new System.Drawing.Point(224, 0);
            this.ButtonChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(117, 28);
            this.ButtonChangePassword.TabIndex = 20;
            this.ButtonChangePassword.Text = "Изменить";
            this.ButtonChangePassword.UseSelectable = true;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonPassword_Click);
            // 
            // BoxPassword
            // 
            // 
            // 
            // 
            this.BoxPassword.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.BoxPassword.CustomButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BoxPassword.CustomButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoxPassword.CustomButton.Image = null;
            this.BoxPassword.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.BoxPassword.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxPassword.CustomButton.Name = "";
            this.BoxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.BoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxPassword.CustomButton.TabIndex = 1;
            this.BoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxPassword.CustomButton.UseSelectable = true;
            this.BoxPassword.CustomButton.UseVisualStyleBackColor = false;
            this.BoxPassword.CustomButton.Visible = false;
            this.BoxPassword.Lines = new string[0];
            this.BoxPassword.Location = new System.Drawing.Point(0, 0);
            this.BoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BoxPassword.MaxLength = 0;
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.PasswordChar = '\0';
            this.BoxPassword.PromptText = "<пароль>";
            this.BoxPassword.ReadOnly = true;
            this.BoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxPassword.SelectedText = "";
            this.BoxPassword.SelectionLength = 0;
            this.BoxPassword.SelectionStart = 0;
            this.BoxPassword.ShortcutsEnabled = true;
            this.BoxPassword.Size = new System.Drawing.Size(216, 28);
            this.BoxPassword.TabIndex = 19;
            this.BoxPassword.UseSelectable = true;
            this.BoxPassword.WaterMark = "<пароль>";
            this.BoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxPassword_KeyDown);
            // 
            // ButtonChangeUsername
            // 
            this.ButtonChangeUsername.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeUsername.Location = new System.Drawing.Point(229, 34);
            this.ButtonChangeUsername.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonChangeUsername.Name = "ButtonChangeUsername";
            this.ButtonChangeUsername.Size = new System.Drawing.Size(117, 28);
            this.ButtonChangeUsername.TabIndex = 21;
            this.ButtonChangeUsername.Text = "Изменить";
            this.ButtonChangeUsername.UseSelectable = true;
            this.ButtonChangeUsername.Click += new System.EventHandler(this.ButtonChangeUsername_Click);
            // 
            // ButtonChangeUser
            // 
            this.ButtonChangeUser.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeUser.Location = new System.Drawing.Point(172, 106);
            this.ButtonChangeUser.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonChangeUser.Name = "ButtonChangeUser";
            this.ButtonChangeUser.Size = new System.Drawing.Size(175, 28);
            this.ButtonChangeUser.TabIndex = 3;
            this.ButtonChangeUser.Text = "Сменить пользователя";
            this.ButtonChangeUser.UseSelectable = true;
            this.ButtonChangeUser.Click += new System.EventHandler(this.ButtonChangeUser_Click);
            // 
            // BoxCurrentUser
            // 
            // 
            // 
            // 
            this.BoxCurrentUser.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.BoxCurrentUser.CustomButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BoxCurrentUser.CustomButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoxCurrentUser.CustomButton.Image = null;
            this.BoxCurrentUser.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.BoxCurrentUser.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxCurrentUser.CustomButton.Name = "";
            this.BoxCurrentUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.BoxCurrentUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxCurrentUser.CustomButton.TabIndex = 1;
            this.BoxCurrentUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxCurrentUser.CustomButton.UseSelectable = true;
            this.BoxCurrentUser.CustomButton.UseVisualStyleBackColor = false;
            this.BoxCurrentUser.CustomButton.Visible = false;
            this.BoxCurrentUser.Lines = new string[0];
            this.BoxCurrentUser.Location = new System.Drawing.Point(5, 34);
            this.BoxCurrentUser.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCurrentUser.MaxLength = 4;
            this.BoxCurrentUser.Name = "BoxCurrentUser";
            this.BoxCurrentUser.PasswordChar = '\0';
            this.BoxCurrentUser.ReadOnly = true;
            this.BoxCurrentUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxCurrentUser.SelectedText = "";
            this.BoxCurrentUser.SelectionLength = 0;
            this.BoxCurrentUser.SelectionStart = 0;
            this.BoxCurrentUser.ShortcutsEnabled = true;
            this.BoxCurrentUser.Size = new System.Drawing.Size(216, 28);
            this.BoxCurrentUser.TabIndex = 3;
            this.BoxCurrentUser.UseSelectable = true;
            this.BoxCurrentUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxCurrentUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(5, 7);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 20);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Пользователь";
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(17, 359);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(148, 28);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Справка";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // PanelSaveResultTo
            // 
            this.PanelSaveResultTo.Controls.Add(this.metroButton3);
            this.PanelSaveResultTo.Controls.Add(this.metroLabel7);
            this.PanelSaveResultTo.Controls.Add(this.metroButton1);
            this.PanelSaveResultTo.Controls.Add(this.BoxDirectoryForResult);
            this.PanelSaveResultTo.Controls.Add(this.metroLabel5);
            this.PanelSaveResultTo.HorizontalScrollbarBarColor = true;
            this.PanelSaveResultTo.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSaveResultTo.HorizontalScrollbarSize = 12;
            this.PanelSaveResultTo.Location = new System.Drawing.Point(17, 48);
            this.PanelSaveResultTo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSaveResultTo.Name = "PanelSaveResultTo";
            this.PanelSaveResultTo.Size = new System.Drawing.Size(484, 121);
            this.PanelSaveResultTo.TabIndex = 15;
            this.PanelSaveResultTo.VerticalScrollbarBarColor = true;
            this.PanelSaveResultTo.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSaveResultTo.VerticalScrollbarSize = 13;
            this.PanelSaveResultTo.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.Location = new System.Drawing.Point(83, 89);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(316, 28);
            this.metroButton3.TabIndex = 18;
            this.metroButton3.Text = "Как должен выглядеть результат?";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(0, 34);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(231, 17);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "(Если не существует, то будет создана)";
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(367, 57);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 28);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Изменить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // BoxDirectoryForResult
            // 
            // 
            // 
            // 
            this.BoxDirectoryForResult.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.BoxDirectoryForResult.CustomButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BoxDirectoryForResult.CustomButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoxDirectoryForResult.CustomButton.Image = null;
            this.BoxDirectoryForResult.CustomButton.Location = new System.Drawing.Point(329, 2);
            this.BoxDirectoryForResult.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxDirectoryForResult.CustomButton.Name = "";
            this.BoxDirectoryForResult.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.BoxDirectoryForResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxDirectoryForResult.CustomButton.TabIndex = 1;
            this.BoxDirectoryForResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxDirectoryForResult.CustomButton.UseSelectable = true;
            this.BoxDirectoryForResult.CustomButton.UseVisualStyleBackColor = false;
            this.BoxDirectoryForResult.CustomButton.Visible = false;
            this.BoxDirectoryForResult.Lines = new string[0];
            this.BoxDirectoryForResult.Location = new System.Drawing.Point(4, 57);
            this.BoxDirectoryForResult.Margin = new System.Windows.Forms.Padding(4);
            this.BoxDirectoryForResult.MaxLength = 0;
            this.BoxDirectoryForResult.Name = "BoxDirectoryForResult";
            this.BoxDirectoryForResult.PasswordChar = '\0';
            this.BoxDirectoryForResult.PromptText = "<путь>";
            this.BoxDirectoryForResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxDirectoryForResult.SelectedText = "";
            this.BoxDirectoryForResult.SelectionLength = 0;
            this.BoxDirectoryForResult.SelectionStart = 0;
            this.BoxDirectoryForResult.ShortcutsEnabled = true;
            this.BoxDirectoryForResult.Size = new System.Drawing.Size(355, 28);
            this.BoxDirectoryForResult.TabIndex = 2;
            this.BoxDirectoryForResult.UseSelectable = true;
            this.BoxDirectoryForResult.WaterMark = "<путь>";
            this.BoxDirectoryForResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxDirectoryForResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxDirectoryForResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDirectoryForResult_KeyPress);
            this.BoxDirectoryForResult.Leave += new System.EventHandler(this.BoxDirectoryForResult_Leave);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 11);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(148, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Папка для результата";
            // 
            // btAbout
            // 
            this.btAbout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btAbout.Location = new System.Drawing.Point(349, 359);
            this.btAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(148, 28);
            this.btAbout.TabIndex = 4;
            this.btAbout.Text = "О программе";
            this.btAbout.UseSelectable = true;
            this.btAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 21);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(153, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Тип файла результата:";
            // 
            // CBoxTypeOfFile
            // 
            this.CBoxTypeOfFile.AccessibleDescription = "TypeOfFileSelect";
            this.CBoxTypeOfFile.DisplayFocus = true;
            this.CBoxTypeOfFile.DropDownWidth = 150;
            this.CBoxTypeOfFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxTypeOfFile.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CBoxTypeOfFile.FormattingEnabled = true;
            this.CBoxTypeOfFile.ItemHeight = 21;
            this.CBoxTypeOfFile.Items.AddRange(new object[] {
            "Не сохранять результат",
            "Текстовый (.txt)",
            "Документ PDF (.pdf)"});
            this.CBoxTypeOfFile.Location = new System.Drawing.Point(340, 14);
            this.CBoxTypeOfFile.Margin = new System.Windows.Forms.Padding(4);
            this.CBoxTypeOfFile.Name = "CBoxTypeOfFile";
            this.CBoxTypeOfFile.PromptText = "Тип файла";
            this.CBoxTypeOfFile.Size = new System.Drawing.Size(160, 27);
            this.CBoxTypeOfFile.TabIndex = 1;
            this.CBoxTypeOfFile.UseSelectable = true;
            this.CBoxTypeOfFile.SelectedIndexChanged += new System.EventHandler(this.CBoxTypeOfFile_SelectedIndexChanged);
            // 
            // TabPageWork
            // 
            this.TabPageWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageWork.Controls.Add(this.ButtonStart);
            this.TabPageWork.Controls.Add(this.PanelResult);
            this.TabPageWork.Controls.Add(this.BoxNumber);
            this.TabPageWork.Controls.Add(this.metroLabel4);
            this.TabPageWork.HorizontalScrollbarBarColor = true;
            this.TabPageWork.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageWork.HorizontalScrollbarSize = 12;
            this.TabPageWork.Location = new System.Drawing.Point(4, 38);
            this.TabPageWork.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageWork.Name = "TabPageWork";
            this.TabPageWork.Size = new System.Drawing.Size(569, 437);
            this.TabPageWork.Style = MetroFramework.MetroColorStyle.Brown;
            this.TabPageWork.TabIndex = 0;
            this.TabPageWork.Tag = "";
            this.TabPageWork.Text = "Работа";
            this.TabPageWork.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabPageWork.VerticalScrollbarBarColor = true;
            this.TabPageWork.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageWork.VerticalScrollbarSize = 13;
            this.TabPageWork.Click += new System.EventHandler(this.MetroTabPage1_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(7, 37);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(77, 28);
            this.ButtonStart.TabIndex = 16;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseSelectable = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.Controls.Add(this.panel1);
            this.PanelResult.Controls.Add(this.metroLabel3);
            this.PanelResult.Controls.Add(this.BoxResult);
            this.PanelResult.Controls.Add(this.metroLabel1);
            this.PanelResult.HorizontalScrollbarBarColor = true;
            this.PanelResult.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelResult.HorizontalScrollbarSize = 12;
            this.PanelResult.Location = new System.Drawing.Point(147, 4);
            this.PanelResult.Margin = new System.Windows.Forms.Padding(4);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(363, 398);
            this.PanelResult.TabIndex = 15;
            this.PanelResult.VerticalScrollbarBarColor = true;
            this.PanelResult.VerticalScrollbarHighlightOnWheel = false;
            this.PanelResult.VerticalScrollbarSize = 13;
            this.PanelResult.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 11);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(26, 20);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "№";
            // 
            // BoxResult
            // 
            // 
            // 
            // 
            this.BoxResult.CustomButton.Image = null;
            this.BoxResult.CustomButton.Location = new System.Drawing.Point(-162, 2);
            this.BoxResult.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxResult.CustomButton.Name = "";
            this.BoxResult.CustomButton.Size = new System.Drawing.Size(341, 341);
            this.BoxResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxResult.CustomButton.TabIndex = 1;
            this.BoxResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxResult.CustomButton.UseSelectable = true;
            this.BoxResult.CustomButton.Visible = false;
            this.BoxResult.Lines = new string[] {
        "2",
        "3",
        "5",
        "7",
        "11",
        "13",
        "17"};
            this.BoxResult.Location = new System.Drawing.Point(39, 38);
            this.BoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.BoxResult.MaxLength = 32767;
            this.BoxResult.Multiline = true;
            this.BoxResult.Name = "BoxResult";
            this.BoxResult.PasswordChar = '\0';
            this.BoxResult.ReadOnly = true;
            this.BoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxResult.SelectedText = "";
            this.BoxResult.SelectionLength = 0;
            this.BoxResult.SelectionStart = 0;
            this.BoxResult.ShortcutsEnabled = true;
            this.BoxResult.Size = new System.Drawing.Size(247, 346);
            this.BoxResult.TabIndex = 8;
            this.BoxResult.Text = "2\r\n3\r\n5\r\n7\r\n11\r\n13\r\n17";
            this.BoxResult.UseSelectable = true;
            this.BoxResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(121, 11);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Результат";
            // 
            // BoxNumber
            // 
            // 
            // 
            // 
            this.BoxNumber.CustomButton.Image = null;
            this.BoxNumber.CustomButton.Location = new System.Drawing.Point(26, 2);
            this.BoxNumber.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxNumber.CustomButton.Name = "";
            this.BoxNumber.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.BoxNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxNumber.CustomButton.TabIndex = 1;
            this.BoxNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxNumber.CustomButton.UseSelectable = true;
            this.BoxNumber.CustomButton.Visible = false;
            this.BoxNumber.Lines = new string[0];
            this.BoxNumber.Location = new System.Drawing.Point(32, 4);
            this.BoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BoxNumber.MaxLength = 4;
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.PasswordChar = '\0';
            this.BoxNumber.PromptText = "0";
            this.BoxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxNumber.SelectedText = "";
            this.BoxNumber.SelectionLength = 0;
            this.BoxNumber.SelectionStart = 0;
            this.BoxNumber.ShortcutsEnabled = true;
            this.BoxNumber.Size = new System.Drawing.Size(52, 28);
            this.BoxNumber.TabIndex = 14;
            this.BoxNumber.UseSelectable = true;
            this.BoxNumber.WaterMark = "0";
            this.BoxNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxNumber_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 10);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(23, 20);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "N:";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabPageWork);
            this.metroTabControl1.Controls.Add(this.TabPageSettings);
            this.metroTabControl1.Controls.Add(this.TabPageAdmin);
            this.metroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl1.Location = new System.Drawing.Point(16, 15);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(577, 479);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(100, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 346);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 498);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPageAdmin.ResumeLayout(false);
            this.TabPageAdmin.PerformLayout();
            this.TabPageSettings.ResumeLayout(false);
            this.TabPageSettings.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelSaveResultTo.ResumeLayout(false);
            this.PanelSaveResultTo.PerformLayout();
            this.TabPageWork.ResumeLayout(false);
            this.TabPageWork.PerformLayout();
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage TabPageAdmin;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonViewLog;
        private MetroFramework.Controls.MetroTabPage TabPageSettings;
        private MetroFramework.Controls.MetroPanel PanelUser;
        private MetroFramework.Controls.MetroPanel PanelPassword;
        private MetroFramework.Controls.MetroButton ButtonChangePassword;
        private MetroFramework.Controls.MetroTextBox BoxPassword;
        private MetroFramework.Controls.MetroButton ButtonChangeUsername;
        private MetroFramework.Controls.MetroButton ButtonChangeUser;
        private MetroFramework.Controls.MetroTextBox BoxCurrentUser;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroPanel PanelSaveResultTo;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox BoxDirectoryForResult;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btAbout;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CBoxTypeOfFile;
        private MetroFramework.Controls.MetroTabPage TabPageWork;
        private MetroFramework.Controls.MetroPanel PanelResult;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox BoxResult;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox BoxNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroButton ButtonStart;
        private MetroFramework.Controls.MetroLabel LabelForExcel;
        private System.Windows.Forms.Panel panel1;
    }
}

