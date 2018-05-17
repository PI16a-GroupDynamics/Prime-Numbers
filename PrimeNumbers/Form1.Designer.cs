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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabPageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.ButtonClearLog = new System.Windows.Forms.Button();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.ButtonViewLog = new System.Windows.Forms.Button();
            this.TabPageSettings = new MetroFramework.Controls.MetroTabPage();
            this.PanelUserSettings = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.PanelPassword = new MetroFramework.Controls.MetroPanel();
            this.ButtonChangePassword = new MetroFramework.Controls.MetroButton();
            this.ButtonChangeUser = new MetroFramework.Controls.MetroButton();
            this.ButtonChangeUsername = new MetroFramework.Controls.MetroButton();
            this.BoxCurrentUser = new MetroFramework.Controls.MetroTextBox();
            this.LabelCurrentUser = new MetroFramework.Controls.MetroLabel();
            this.PanelResultSettings = new MetroFramework.Controls.MetroPanel();
            this.PanelSaveResult = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ButtonResultLooksLike = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BoxDirectoryForResult = new MetroFramework.Controls.MetroTextBox();
            this.ButtonChangeResultDir = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CBoxTypeOfFile = new MetroFramework.Controls.MetroComboBox();
            this.btAbout = new MetroFramework.Controls.MetroButton();
            this.TabPageWork = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ButtonCancel = new MetroFramework.Controls.MetroButton();
            this.ButtonStart = new MetroFramework.Controls.MetroButton();
            this.PanelResult = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoxResult = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BoxNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TabControlMenu = new MetroFramework.Controls.MetroTabControl();
            this.TabPageNeedHelp = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabPageAdmin.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            this.PanelUserSettings.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelResultSettings.SuspendLayout();
            this.PanelSaveResult.SuspendLayout();
            this.TabPageWork.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.TabControlMenu.SuspendLayout();
            this.TabPageNeedHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPageAdmin
            // 
            this.TabPageAdmin.Controls.Add(this.ButtonClearLog);
            this.TabPageAdmin.Controls.Add(this.ButtonUsers);
            this.TabPageAdmin.Controls.Add(this.ButtonViewLog);
            this.TabPageAdmin.HorizontalScrollbarBarColor = true;
            this.TabPageAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.HorizontalScrollbarSize = 10;
            this.TabPageAdmin.Location = new System.Drawing.Point(4, 38);
            this.TabPageAdmin.Name = "TabPageAdmin";
            this.TabPageAdmin.Size = new System.Drawing.Size(426, 362);
            this.TabPageAdmin.TabIndex = 2;
            this.TabPageAdmin.Text = "Админ";
            this.TabPageAdmin.VerticalScrollbarBarColor = true;
            this.TabPageAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.VerticalScrollbarSize = 10;
            // 
            // ButtonClearLog
            // 
            this.ButtonClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearLog.Location = new System.Drawing.Point(186, 125);
            this.ButtonClearLog.Name = "ButtonClearLog";
            this.ButtonClearLog.Size = new System.Drawing.Size(106, 23);
            this.ButtonClearLog.TabIndex = 12;
            this.ButtonClearLog.Text = "Очистить журнал";
            this.ButtonClearLog.UseVisualStyleBackColor = true;
            this.ButtonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Location = new System.Drawing.Point(15, 67);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(106, 36);
            this.ButtonUsers.TabIndex = 8;
            this.ButtonUsers.Text = "Учетные записи пользователей";
            this.ButtonUsers.UseVisualStyleBackColor = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonViewLog
            // 
            this.ButtonViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewLog.Location = new System.Drawing.Point(186, 67);
            this.ButtonViewLog.Name = "ButtonViewLog";
            this.ButtonViewLog.Size = new System.Drawing.Size(106, 52);
            this.ButtonViewLog.TabIndex = 7;
            this.ButtonViewLog.Text = "Журнал";
            this.ButtonViewLog.UseVisualStyleBackColor = true;
            this.ButtonViewLog.Click += new System.EventHandler(this.ButtonViewLog_Click);
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageSettings.Controls.Add(this.PanelUserSettings);
            this.TabPageSettings.Controls.Add(this.PanelResultSettings);
            this.TabPageSettings.Controls.Add(this.btAbout);
            this.TabPageSettings.HorizontalScrollbarBarColor = true;
            this.TabPageSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageSettings.HorizontalScrollbarSize = 10;
            this.TabPageSettings.Location = new System.Drawing.Point(4, 38);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Size = new System.Drawing.Size(426, 362);
            this.TabPageSettings.TabIndex = 1;
            this.TabPageSettings.Text = "Настройки";
            this.TabPageSettings.VerticalScrollbarBarColor = true;
            this.TabPageSettings.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageSettings.VerticalScrollbarSize = 10;
            // 
            // PanelUserSettings
            // 
            this.PanelUserSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUserSettings.Controls.Add(this.metroLabel6);
            this.PanelUserSettings.Controls.Add(this.PanelPassword);
            this.PanelUserSettings.Controls.Add(this.ButtonChangeUsername);
            this.PanelUserSettings.Controls.Add(this.BoxCurrentUser);
            this.PanelUserSettings.Controls.Add(this.LabelCurrentUser);
            this.PanelUserSettings.HorizontalScrollbarBarColor = true;
            this.PanelUserSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelUserSettings.HorizontalScrollbarSize = 10;
            this.PanelUserSettings.Location = new System.Drawing.Point(13, 191);
            this.PanelUserSettings.Name = "PanelUserSettings";
            this.PanelUserSettings.Size = new System.Drawing.Size(363, 118);
            this.PanelUserSettings.TabIndex = 22;
            this.PanelUserSettings.VerticalScrollbarBarColor = true;
            this.PanelUserSettings.VerticalScrollbarHighlightOnWheel = false;
            this.PanelUserSettings.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(-1, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(180, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Настройки учетной записи";
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.ButtonChangePassword);
            this.PanelPassword.Controls.Add(this.ButtonChangeUser);
            this.PanelPassword.HorizontalScrollbarBarColor = true;
            this.PanelPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelPassword.HorizontalScrollbarSize = 10;
            this.PanelPassword.Location = new System.Drawing.Point(3, 84);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(318, 23);
            this.PanelPassword.TabIndex = 23;
            this.PanelPassword.VerticalScrollbarBarColor = true;
            this.PanelPassword.VerticalScrollbarHighlightOnWheel = false;
            this.PanelPassword.VerticalScrollbarSize = 10;
            this.PanelPassword.Leave += new System.EventHandler(this.PanelPassword_Leave);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangePassword.Location = new System.Drawing.Point(0, 0);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(119, 23);
            this.ButtonChangePassword.TabIndex = 20;
            this.ButtonChangePassword.Text = "Сменить пароль";
            this.ButtonChangePassword.UseSelectable = true;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonPassword_Click);
            // 
            // ButtonChangeUser
            // 
            this.ButtonChangeUser.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeUser.Location = new System.Drawing.Point(184, 0);
            this.ButtonChangeUser.Name = "ButtonChangeUser";
            this.ButtonChangeUser.Size = new System.Drawing.Size(131, 23);
            this.ButtonChangeUser.TabIndex = 3;
            this.ButtonChangeUser.Text = "Выйти из системы";
            this.ButtonChangeUser.UseSelectable = true;
            this.ButtonChangeUser.Click += new System.EventHandler(this.ButtonChangeUser_Click);
            // 
            // ButtonChangeUsername
            // 
            this.ButtonChangeUsername.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeUsername.Location = new System.Drawing.Point(230, 55);
            this.ButtonChangeUsername.Name = "ButtonChangeUsername";
            this.ButtonChangeUsername.Size = new System.Drawing.Size(88, 23);
            this.ButtonChangeUsername.TabIndex = 21;
            this.ButtonChangeUsername.Text = "Изменить имя";
            this.ButtonChangeUsername.UseSelectable = true;
            this.ButtonChangeUsername.Click += new System.EventHandler(this.ButtonChangeUsername_Click);
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
            this.BoxCurrentUser.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.BoxCurrentUser.CustomButton.Name = "";
            this.BoxCurrentUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxCurrentUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxCurrentUser.CustomButton.TabIndex = 1;
            this.BoxCurrentUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxCurrentUser.CustomButton.UseSelectable = true;
            this.BoxCurrentUser.CustomButton.UseVisualStyleBackColor = false;
            this.BoxCurrentUser.CustomButton.Visible = false;
            this.BoxCurrentUser.Lines = new string[0];
            this.BoxCurrentUser.Location = new System.Drawing.Point(3, 55);
            this.BoxCurrentUser.MaxLength = 50;
            this.BoxCurrentUser.Name = "BoxCurrentUser";
            this.BoxCurrentUser.PasswordChar = '\0';
            this.BoxCurrentUser.ReadOnly = true;
            this.BoxCurrentUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxCurrentUser.SelectedText = "";
            this.BoxCurrentUser.SelectionLength = 0;
            this.BoxCurrentUser.SelectionStart = 0;
            this.BoxCurrentUser.ShortcutsEnabled = true;
            this.BoxCurrentUser.Size = new System.Drawing.Size(221, 23);
            this.BoxCurrentUser.TabIndex = 3;
            this.BoxCurrentUser.UseSelectable = true;
            this.BoxCurrentUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxCurrentUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxCurrentUser.TextChanged += new System.EventHandler(this.BoxCurrentUser_TextChanged);
            // 
            // LabelCurrentUser
            // 
            this.LabelCurrentUser.AutoSize = true;
            this.LabelCurrentUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelCurrentUser.Location = new System.Drawing.Point(3, 33);
            this.LabelCurrentUser.Name = "LabelCurrentUser";
            this.LabelCurrentUser.Size = new System.Drawing.Size(96, 19);
            this.LabelCurrentUser.TabIndex = 18;
            this.LabelCurrentUser.Text = "Пользователь";
            // 
            // PanelResultSettings
            // 
            this.PanelResultSettings.BackColor = System.Drawing.SystemColors.Control;
            this.PanelResultSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelResultSettings.Controls.Add(this.PanelSaveResult);
            this.PanelResultSettings.Controls.Add(this.metroLabel3);
            this.PanelResultSettings.Controls.Add(this.metroLabel2);
            this.PanelResultSettings.Controls.Add(this.CBoxTypeOfFile);
            this.PanelResultSettings.HorizontalScrollbarBarColor = true;
            this.PanelResultSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelResultSettings.HorizontalScrollbarSize = 10;
            this.PanelResultSettings.Location = new System.Drawing.Point(13, 3);
            this.PanelResultSettings.Name = "PanelResultSettings";
            this.PanelResultSettings.Size = new System.Drawing.Size(363, 164);
            this.PanelResultSettings.TabIndex = 15;
            this.PanelResultSettings.VerticalScrollbarBarColor = true;
            this.PanelResultSettings.VerticalScrollbarHighlightOnWheel = false;
            this.PanelResultSettings.VerticalScrollbarSize = 10;
            // 
            // PanelSaveResult
            // 
            this.PanelSaveResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSaveResult.Controls.Add(this.metroLabel7);
            this.PanelSaveResult.Controls.Add(this.ButtonResultLooksLike);
            this.PanelSaveResult.Controls.Add(this.metroLabel5);
            this.PanelSaveResult.Controls.Add(this.BoxDirectoryForResult);
            this.PanelSaveResult.Controls.Add(this.ButtonChangeResultDir);
            this.PanelSaveResult.Enabled = false;
            this.PanelSaveResult.HorizontalScrollbarBarColor = true;
            this.PanelSaveResult.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSaveResult.HorizontalScrollbarSize = 10;
            this.PanelSaveResult.Location = new System.Drawing.Point(0, 60);
            this.PanelSaveResult.Name = "PanelSaveResult";
            this.PanelSaveResult.Size = new System.Drawing.Size(363, 105);
            this.PanelSaveResult.TabIndex = 25;
            this.PanelSaveResult.VerticalScrollbarBarColor = true;
            this.PanelSaveResult.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSaveResult.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(3, 24);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(204, 15);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "(Если не существует, то будет создана)";
            // 
            // ButtonResultLooksLike
            // 
            this.ButtonResultLooksLike.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonResultLooksLike.Location = new System.Drawing.Point(25, 71);
            this.ButtonResultLooksLike.Name = "ButtonResultLooksLike";
            this.ButtonResultLooksLike.Size = new System.Drawing.Size(237, 23);
            this.ButtonResultLooksLike.TabIndex = 18;
            this.ButtonResultLooksLike.Text = "Как должен выглядеть результат?";
            this.ButtonResultLooksLike.UseSelectable = true;
            this.ButtonResultLooksLike.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, -1);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(181, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Папка для файла результата";
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
            this.BoxDirectoryForResult.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.BoxDirectoryForResult.CustomButton.Name = "";
            this.BoxDirectoryForResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxDirectoryForResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxDirectoryForResult.CustomButton.TabIndex = 1;
            this.BoxDirectoryForResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxDirectoryForResult.CustomButton.UseSelectable = true;
            this.BoxDirectoryForResult.CustomButton.UseVisualStyleBackColor = false;
            this.BoxDirectoryForResult.CustomButton.Visible = false;
            this.BoxDirectoryForResult.Lines = new string[0];
            this.BoxDirectoryForResult.Location = new System.Drawing.Point(6, 42);
            this.BoxDirectoryForResult.MaxLength = 0;
            this.BoxDirectoryForResult.Name = "BoxDirectoryForResult";
            this.BoxDirectoryForResult.PasswordChar = '\0';
            this.BoxDirectoryForResult.PromptText = "<путь>";
            this.BoxDirectoryForResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxDirectoryForResult.SelectedText = "";
            this.BoxDirectoryForResult.SelectionLength = 0;
            this.BoxDirectoryForResult.SelectionStart = 0;
            this.BoxDirectoryForResult.ShortcutsEnabled = true;
            this.BoxDirectoryForResult.Size = new System.Drawing.Size(256, 23);
            this.BoxDirectoryForResult.TabIndex = 2;
            this.BoxDirectoryForResult.UseSelectable = true;
            this.BoxDirectoryForResult.WaterMark = "<путь>";
            this.BoxDirectoryForResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxDirectoryForResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxDirectoryForResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDirectoryForResult_KeyPress);
            this.BoxDirectoryForResult.Leave += new System.EventHandler(this.BoxDirectoryForResult_Leave);
            // 
            // ButtonChangeResultDir
            // 
            this.ButtonChangeResultDir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeResultDir.Location = new System.Drawing.Point(269, 42);
            this.ButtonChangeResultDir.Name = "ButtonChangeResultDir";
            this.ButtonChangeResultDir.Size = new System.Drawing.Size(85, 23);
            this.ButtonChangeResultDir.TabIndex = 2;
            this.ButtonChangeResultDir.Text = "Изменить";
            this.ButtonChangeResultDir.UseSelectable = true;
            this.ButtonChangeResultDir.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(192, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Настройки файла результата";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 19);
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
            this.CBoxTypeOfFile.ItemHeight = 19;
            this.CBoxTypeOfFile.Items.AddRange(new object[] {
            "Не сохранять результат",
            "Текстовый (.txt)",
            "Документ PDF (.pdf)"});
            this.CBoxTypeOfFile.Location = new System.Drawing.Point(215, 29);
            this.CBoxTypeOfFile.Name = "CBoxTypeOfFile";
            this.CBoxTypeOfFile.PromptText = "Тип файла";
            this.CBoxTypeOfFile.Size = new System.Drawing.Size(136, 25);
            this.CBoxTypeOfFile.TabIndex = 1;
            this.CBoxTypeOfFile.UseSelectable = true;
            this.CBoxTypeOfFile.SelectedIndexChanged += new System.EventHandler(this.CBoxTypeOfFile_SelectedIndexChanged);
            // 
            // btAbout
            // 
            this.btAbout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btAbout.Location = new System.Drawing.Point(265, 333);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(111, 23);
            this.btAbout.TabIndex = 4;
            this.btAbout.Text = "О программе";
            this.btAbout.UseSelectable = true;
            this.btAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // TabPageWork
            // 
            this.TabPageWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPageWork.Controls.Add(this.metroButton1);
            this.TabPageWork.Controls.Add(this.ButtonCancel);
            this.TabPageWork.Controls.Add(this.ButtonStart);
            this.TabPageWork.Controls.Add(this.PanelResult);
            this.TabPageWork.Controls.Add(this.BoxNumber);
            this.TabPageWork.Controls.Add(this.metroLabel4);
            this.TabPageWork.HorizontalScrollbarBarColor = true;
            this.TabPageWork.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageWork.HorizontalScrollbarSize = 10;
            this.TabPageWork.Location = new System.Drawing.Point(4, 38);
            this.TabPageWork.Name = "TabPageWork";
            this.TabPageWork.Size = new System.Drawing.Size(426, 362);
            this.TabPageWork.Style = MetroFramework.MetroColorStyle.Brown;
            this.TabPageWork.TabIndex = 0;
            this.TabPageWork.Tag = "";
            this.TabPageWork.Text = "Работа";
            this.TabPageWork.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabPageWork.VerticalScrollbarBarColor = true;
            this.TabPageWork.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageWork.VerticalScrollbarSize = 10;
            this.TabPageWork.Click += new System.EventHandler(this.MetroTabPage1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(5, 319);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 23);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Сохранить результат";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(5, 59);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(81, 23);
            this.ButtonCancel.TabIndex = 17;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.UseSelectable = true;
            this.ButtonCancel.Visible = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(5, 30);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(81, 23);
            this.ButtonStart.TabIndex = 16;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseSelectable = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.Controls.Add(this.label1);
            this.PanelResult.Controls.Add(this.progressBar1);
            this.PanelResult.Controls.Add(this.BoxResult);
            this.PanelResult.Controls.Add(this.metroLabel1);
            this.PanelResult.HorizontalScrollbarBarColor = true;
            this.PanelResult.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelResult.HorizontalScrollbarSize = 10;
            this.PanelResult.Location = new System.Drawing.Point(150, 8);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(210, 334);
            this.PanelResult.TabIndex = 15;
            this.PanelResult.VerticalScrollbarBarColor = true;
            this.PanelResult.VerticalScrollbarHighlightOnWheel = false;
            this.PanelResult.VerticalScrollbarSize = 10;
            this.PanelResult.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 312);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // BoxResult
            // 
            this.BoxResult.Location = new System.Drawing.Point(41, 24);
            this.BoxResult.Multiline = true;
            this.BoxResult.Name = "BoxResult";
            this.BoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxResult.Size = new System.Drawing.Size(155, 279);
            this.BoxResult.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Результат";
            // 
            // BoxNumber
            // 
            // 
            // 
            // 
            this.BoxNumber.CustomButton.Image = null;
            this.BoxNumber.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.BoxNumber.CustomButton.Name = "";
            this.BoxNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxNumber.CustomButton.TabIndex = 1;
            this.BoxNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxNumber.CustomButton.UseSelectable = true;
            this.BoxNumber.CustomButton.Visible = false;
            this.BoxNumber.Lines = new string[0];
            this.BoxNumber.Location = new System.Drawing.Point(24, 3);
            this.BoxNumber.MaxLength = 7;
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.PasswordChar = '\0';
            this.BoxNumber.PromptText = "0";
            this.BoxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxNumber.SelectedText = "";
            this.BoxNumber.SelectionLength = 0;
            this.BoxNumber.SelectionStart = 0;
            this.BoxNumber.ShortcutsEnabled = true;
            this.BoxNumber.Size = new System.Drawing.Size(62, 23);
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
            this.metroLabel4.Location = new System.Drawing.Point(5, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(22, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "N:";
            // 
            // TabControlMenu
            // 
            this.TabControlMenu.Controls.Add(this.TabPageWork);
            this.TabControlMenu.Controls.Add(this.TabPageSettings);
            this.TabControlMenu.Controls.Add(this.TabPageAdmin);
            this.TabControlMenu.Controls.Add(this.TabPageNeedHelp);
            this.TabControlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControlMenu.Location = new System.Drawing.Point(12, 12);
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 1;
            this.TabControlMenu.Size = new System.Drawing.Size(434, 404);
            this.TabControlMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.TabControlMenu.TabIndex = 12;
            this.TabControlMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TabControlMenu.UseSelectable = true;
            // 
            // TabPageNeedHelp
            // 
            this.TabPageNeedHelp.Controls.Add(this.pictureBox1);
            this.TabPageNeedHelp.HorizontalScrollbarBarColor = true;
            this.TabPageNeedHelp.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageNeedHelp.HorizontalScrollbarSize = 10;
            this.TabPageNeedHelp.Location = new System.Drawing.Point(4, 38);
            this.TabPageNeedHelp.Name = "TabPageNeedHelp";
            this.TabPageNeedHelp.Size = new System.Drawing.Size(426, 362);
            this.TabPageNeedHelp.TabIndex = 3;
            this.TabPageNeedHelp.Text = "Мне нужна помощь";
            this.TabPageNeedHelp.VerticalScrollbarBarColor = true;
            this.TabPageNeedHelp.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageNeedHelp.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MetroFramework_test_at_a_new_project.Properties.Resources.question_mark;
            this.pictureBox1.Location = new System.Drawing.Point(51, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.TabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShowHelp);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPageAdmin.ResumeLayout(false);
            this.TabPageSettings.ResumeLayout(false);
            this.PanelUserSettings.ResumeLayout(false);
            this.PanelUserSettings.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelResultSettings.ResumeLayout(false);
            this.PanelResultSettings.PerformLayout();
            this.PanelSaveResult.ResumeLayout(false);
            this.PanelSaveResult.PerformLayout();
            this.TabPageWork.ResumeLayout(false);
            this.TabPageWork.PerformLayout();
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            this.TabControlMenu.ResumeLayout(false);
            this.TabPageNeedHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage TabPageAdmin;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonViewLog;
        private MetroFramework.Controls.MetroTabPage TabPageSettings;
        private MetroFramework.Controls.MetroPanel PanelUserSettings;
        private MetroFramework.Controls.MetroPanel PanelPassword;
        private MetroFramework.Controls.MetroButton ButtonChangePassword;
        private MetroFramework.Controls.MetroButton ButtonChangeUsername;
        private MetroFramework.Controls.MetroButton ButtonChangeUser;
        private MetroFramework.Controls.MetroTextBox BoxCurrentUser;
        private MetroFramework.Controls.MetroLabel LabelCurrentUser;
        private MetroFramework.Controls.MetroPanel PanelResultSettings;
        private MetroFramework.Controls.MetroButton ButtonResultLooksLike;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton ButtonChangeResultDir;
        private MetroFramework.Controls.MetroTextBox BoxDirectoryForResult;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btAbout;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CBoxTypeOfFile;
        private MetroFramework.Controls.MetroTabPage TabPageWork;
        private MetroFramework.Controls.MetroPanel PanelResult;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox BoxNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabControl TabControlMenu;
        private MetroFramework.Controls.MetroButton ButtonStart;
        private System.Windows.Forms.Button ButtonClearLog;
        private System.Windows.Forms.TextBox BoxResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton ButtonCancel;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel PanelSaveResult;
        private MetroFramework.Controls.MetroTabPage TabPageNeedHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

