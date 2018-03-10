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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPageWork = new MetroFramework.Controls.MetroTabPage();
            this.ButtonStart = new MetroFramework.Controls.MetroButton();
            this.PanelResult = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BoxResult = new MetroFramework.Controls.MetroTextBox();
            this.BoxNumerator = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BoxNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BoxDirectoryForResult = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btAbout = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CBoxTypeOfFile = new MetroFramework.Controls.MetroComboBox();
            this.TabPageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.ButtonViewLog = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.TabPageWork.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelSaveResultTo.SuspendLayout();
            this.TabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabPageWork);
            this.metroTabControl1.Controls.Add(this.TabPageSettings);
            this.metroTabControl1.Controls.Add(this.TabPageAdmin);
            this.metroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl1.Location = new System.Drawing.Point(50, 28);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(332, 332);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
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
            this.TabPageWork.HorizontalScrollbarSize = 10;
            this.TabPageWork.Location = new System.Drawing.Point(4, 38);
            this.TabPageWork.Name = "TabPageWork";
            this.TabPageWork.Size = new System.Drawing.Size(324, 290);
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
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(5, 30);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(58, 23);
            this.ButtonStart.TabIndex = 16;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseSelectable = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.Controls.Add(this.metroLabel3);
            this.PanelResult.Controls.Add(this.BoxResult);
            this.PanelResult.Controls.Add(this.BoxNumerator);
            this.PanelResult.Controls.Add(this.metroLabel1);
            this.PanelResult.HorizontalScrollbarBarColor = true;
            this.PanelResult.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelResult.HorizontalScrollbarSize = 10;
            this.PanelResult.Location = new System.Drawing.Point(106, 3);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(200, 277);
            this.PanelResult.TabIndex = 15;
            this.PanelResult.VerticalScrollbarBarColor = true;
            this.PanelResult.VerticalScrollbarHighlightOnWheel = false;
            this.PanelResult.VerticalScrollbarSize = 10;
            this.PanelResult.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(25, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "№";
            // 
            // BoxResult
            // 
            // 
            // 
            // 
            this.BoxResult.CustomButton.Image = null;
            this.BoxResult.CustomButton.Location = new System.Drawing.Point(-104, 1);
            this.BoxResult.CustomButton.Name = "";
            this.BoxResult.CustomButton.Size = new System.Drawing.Size(241, 241);
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
            this.BoxResult.Location = new System.Drawing.Point(62, 31);
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
            this.BoxResult.Size = new System.Drawing.Size(138, 243);
            this.BoxResult.TabIndex = 8;
            this.BoxResult.Text = "2\r\n3\r\n5\r\n7\r\n11\r\n13\r\n17";
            this.BoxResult.UseSelectable = true;
            this.BoxResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxNumerator
            // 
            // 
            // 
            // 
            this.BoxNumerator.CustomButton.Image = null;
            this.BoxNumerator.CustomButton.Location = new System.Drawing.Point(-208, 1);
            this.BoxNumerator.CustomButton.Name = "";
            this.BoxNumerator.CustomButton.Size = new System.Drawing.Size(241, 241);
            this.BoxNumerator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxNumerator.CustomButton.TabIndex = 1;
            this.BoxNumerator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxNumerator.CustomButton.UseSelectable = true;
            this.BoxNumerator.CustomButton.Visible = false;
            this.BoxNumerator.Lines = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7"};
            this.BoxNumerator.Location = new System.Drawing.Point(20, 31);
            this.BoxNumerator.MaxLength = 32767;
            this.BoxNumerator.Multiline = true;
            this.BoxNumerator.Name = "BoxNumerator";
            this.BoxNumerator.PasswordChar = '\0';
            this.BoxNumerator.ReadOnly = true;
            this.BoxNumerator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxNumerator.SelectedText = "";
            this.BoxNumerator.SelectionLength = 0;
            this.BoxNumerator.SelectionStart = 0;
            this.BoxNumerator.ShortcutsEnabled = true;
            this.BoxNumerator.Size = new System.Drawing.Size(34, 243);
            this.BoxNumerator.TabIndex = 9;
            this.BoxNumerator.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.BoxNumerator.UseSelectable = true;
            this.BoxNumerator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxNumerator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(60, 9);
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
            this.BoxNumber.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.BoxNumber.CustomButton.Name = "";
            this.BoxNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxNumber.CustomButton.TabIndex = 1;
            this.BoxNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxNumber.CustomButton.UseSelectable = true;
            this.BoxNumber.CustomButton.Visible = false;
            this.BoxNumber.Lines = new string[0];
            this.BoxNumber.Location = new System.Drawing.Point(24, 3);
            this.BoxNumber.MaxLength = 4;
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.PasswordChar = '\0';
            this.BoxNumber.PromptText = "0";
            this.BoxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxNumber.SelectedText = "";
            this.BoxNumber.SelectionLength = 0;
            this.BoxNumber.SelectionStart = 0;
            this.BoxNumber.ShortcutsEnabled = true;
            this.BoxNumber.Size = new System.Drawing.Size(39, 23);
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
            this.TabPageSettings.HorizontalScrollbarSize = 10;
            this.TabPageSettings.Location = new System.Drawing.Point(4, 38);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Size = new System.Drawing.Size(324, 290);
            this.TabPageSettings.TabIndex = 1;
            this.TabPageSettings.Text = "Настройки";
            this.TabPageSettings.VerticalScrollbarBarColor = true;
            this.TabPageSettings.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageSettings.VerticalScrollbarSize = 10;
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
            this.PanelUser.HorizontalScrollbarSize = 10;
            this.PanelUser.Location = new System.Drawing.Point(19, 119);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(273, 117);
            this.PanelUser.TabIndex = 22;
            this.PanelUser.VerticalScrollbarBarColor = true;
            this.PanelUser.VerticalScrollbarHighlightOnWheel = false;
            this.PanelUser.VerticalScrollbarSize = 10;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.ButtonChangePassword);
            this.PanelPassword.Controls.Add(this.BoxPassword);
            this.PanelPassword.HorizontalScrollbarBarColor = true;
            this.PanelPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelPassword.HorizontalScrollbarSize = 10;
            this.PanelPassword.Location = new System.Drawing.Point(4, 57);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(220, 23);
            this.PanelPassword.TabIndex = 23;
            this.PanelPassword.VerticalScrollbarBarColor = true;
            this.PanelPassword.VerticalScrollbarHighlightOnWheel = false;
            this.PanelPassword.VerticalScrollbarSize = 10;
            this.PanelPassword.Leave += new System.EventHandler(this.PanelPassword_Leave);
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangePassword.Location = new System.Drawing.Point(115, 0);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(88, 23);
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
            this.BoxPassword.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.BoxPassword.CustomButton.Name = "";
            this.BoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxPassword.CustomButton.TabIndex = 1;
            this.BoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxPassword.CustomButton.UseSelectable = true;
            this.BoxPassword.CustomButton.UseVisualStyleBackColor = false;
            this.BoxPassword.CustomButton.Visible = false;
            this.BoxPassword.Lines = new string[0];
            this.BoxPassword.Location = new System.Drawing.Point(0, 0);
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
            this.BoxPassword.Size = new System.Drawing.Size(109, 23);
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
            this.ButtonChangeUsername.Location = new System.Drawing.Point(119, 28);
            this.ButtonChangeUsername.Name = "ButtonChangeUsername";
            this.ButtonChangeUsername.Size = new System.Drawing.Size(88, 23);
            this.ButtonChangeUsername.TabIndex = 21;
            this.ButtonChangeUsername.Text = "Изменить";
            this.ButtonChangeUsername.UseSelectable = true;
            this.ButtonChangeUsername.Click += new System.EventHandler(this.ButtonChangeUsername_Click);
            // 
            // ButtonChangeUser
            // 
            this.ButtonChangeUser.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonChangeUser.Location = new System.Drawing.Point(38, 86);
            this.ButtonChangeUser.Name = "ButtonChangeUser";
            this.ButtonChangeUser.Size = new System.Drawing.Size(131, 23);
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
            this.BoxCurrentUser.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.BoxCurrentUser.CustomButton.Name = "";
            this.BoxCurrentUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxCurrentUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxCurrentUser.CustomButton.TabIndex = 1;
            this.BoxCurrentUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxCurrentUser.CustomButton.UseSelectable = true;
            this.BoxCurrentUser.CustomButton.UseVisualStyleBackColor = false;
            this.BoxCurrentUser.CustomButton.Visible = false;
            this.BoxCurrentUser.Lines = new string[0];
            this.BoxCurrentUser.Location = new System.Drawing.Point(4, 28);
            this.BoxCurrentUser.MaxLength = 4;
            this.BoxCurrentUser.Name = "BoxCurrentUser";
            this.BoxCurrentUser.PasswordChar = '\0';
            this.BoxCurrentUser.ReadOnly = true;
            this.BoxCurrentUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxCurrentUser.SelectedText = "";
            this.BoxCurrentUser.SelectionLength = 0;
            this.BoxCurrentUser.SelectionStart = 0;
            this.BoxCurrentUser.ShortcutsEnabled = true;
            this.BoxCurrentUser.Size = new System.Drawing.Size(109, 23);
            this.BoxCurrentUser.TabIndex = 3;
            this.BoxCurrentUser.UseSelectable = true;
            this.BoxCurrentUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxCurrentUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 6);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Пользователь";
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(19, 262);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(111, 23);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Справка";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // PanelSaveResultTo
            // 
            this.PanelSaveResultTo.Controls.Add(this.metroLabel7);
            this.PanelSaveResultTo.Controls.Add(this.metroButton1);
            this.PanelSaveResultTo.Controls.Add(this.BoxDirectoryForResult);
            this.PanelSaveResultTo.Controls.Add(this.metroLabel5);
            this.PanelSaveResultTo.HorizontalScrollbarBarColor = true;
            this.PanelSaveResultTo.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSaveResultTo.HorizontalScrollbarSize = 10;
            this.PanelSaveResultTo.Location = new System.Drawing.Point(19, 41);
            this.PanelSaveResultTo.Name = "PanelSaveResultTo";
            this.PanelSaveResultTo.Size = new System.Drawing.Size(273, 72);
            this.PanelSaveResultTo.TabIndex = 15;
            this.PanelSaveResultTo.VerticalScrollbarBarColor = true;
            this.PanelSaveResultTo.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSaveResultTo.VerticalScrollbarSize = 10;
            this.PanelSaveResultTo.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(0, 28);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(204, 15);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "(Если не существует, то будет создана)";
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(185, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 23);
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
            this.BoxDirectoryForResult.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.BoxDirectoryForResult.CustomButton.Name = "";
            this.BoxDirectoryForResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxDirectoryForResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxDirectoryForResult.CustomButton.TabIndex = 1;
            this.BoxDirectoryForResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxDirectoryForResult.CustomButton.UseSelectable = true;
            this.BoxDirectoryForResult.CustomButton.UseVisualStyleBackColor = false;
            this.BoxDirectoryForResult.CustomButton.Visible = false;
            this.BoxDirectoryForResult.Lines = new string[0];
            this.BoxDirectoryForResult.Location = new System.Drawing.Point(3, 46);
            this.BoxDirectoryForResult.MaxLength = 4;
            this.BoxDirectoryForResult.Name = "BoxDirectoryForResult";
            this.BoxDirectoryForResult.PasswordChar = '\0';
            this.BoxDirectoryForResult.PromptText = "<путь>";
            this.BoxDirectoryForResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxDirectoryForResult.SelectedText = "";
            this.BoxDirectoryForResult.SelectionLength = 0;
            this.BoxDirectoryForResult.SelectionStart = 0;
            this.BoxDirectoryForResult.ShortcutsEnabled = true;
            this.BoxDirectoryForResult.Size = new System.Drawing.Size(176, 23);
            this.BoxDirectoryForResult.TabIndex = 2;
            this.BoxDirectoryForResult.UseSelectable = true;
            this.BoxDirectoryForResult.WaterMark = "<путь>";
            this.BoxDirectoryForResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxDirectoryForResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BoxDirectoryForResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDirectoryForResult_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Папка для результата";
            // 
            // btAbout
            // 
            this.btAbout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btAbout.Location = new System.Drawing.Point(181, 262);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(111, 23);
            this.btAbout.TabIndex = 4;
            this.btAbout.Text = "О программе";
            this.btAbout.UseSelectable = true;
            this.btAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 19);
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
            this.CBoxTypeOfFile.Location = new System.Drawing.Point(168, 14);
            this.CBoxTypeOfFile.Name = "CBoxTypeOfFile";
            this.CBoxTypeOfFile.PromptText = "Тип файла";
            this.CBoxTypeOfFile.Size = new System.Drawing.Size(121, 25);
            this.CBoxTypeOfFile.TabIndex = 1;
            this.CBoxTypeOfFile.UseSelectable = true;
            this.CBoxTypeOfFile.SelectedIndexChanged += new System.EventHandler(this.CBoxTypeOfFile_SelectedIndexChanged);
            // 
            // TabPageAdmin
            // 
            this.TabPageAdmin.Controls.Add(this.ButtonUsers);
            this.TabPageAdmin.Controls.Add(this.ButtonViewLog);
            this.TabPageAdmin.HorizontalScrollbarBarColor = true;
            this.TabPageAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.HorizontalScrollbarSize = 10;
            this.TabPageAdmin.Location = new System.Drawing.Point(4, 38);
            this.TabPageAdmin.Name = "TabPageAdmin";
            this.TabPageAdmin.Size = new System.Drawing.Size(324, 290);
            this.TabPageAdmin.TabIndex = 2;
            this.TabPageAdmin.Text = "Админ";
            this.TabPageAdmin.VerticalScrollbarBarColor = true;
            this.TabPageAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageAdmin.VerticalScrollbarSize = 10;
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Location = new System.Drawing.Point(18, 55);
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
            this.ButtonViewLog.Location = new System.Drawing.Point(18, 164);
            this.ButtonViewLog.Name = "ButtonViewLog";
            this.ButtonViewLog.Size = new System.Drawing.Size(106, 23);
            this.ButtonViewLog.TabIndex = 7;
            this.ButtonViewLog.Text = "Логи";
            this.ButtonViewLog.UseVisualStyleBackColor = true;
            this.ButtonViewLog.Click += new System.EventHandler(this.ButtonViewLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 405);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabPageWork.ResumeLayout(false);
            this.TabPageWork.PerformLayout();
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            this.TabPageSettings.ResumeLayout(false);
            this.TabPageSettings.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelSaveResultTo.ResumeLayout(false);
            this.PanelSaveResultTo.PerformLayout();
            this.TabPageAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabPageWork;
        private MetroFramework.Controls.MetroTextBox BoxNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox BoxNumerator;
        private MetroFramework.Controls.MetroTextBox BoxResult;
        private MetroFramework.Controls.MetroTabPage TabPageSettings;
        private MetroFramework.Controls.MetroPanel PanelSaveResultTo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox BoxDirectoryForResult;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btAbout;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CBoxTypeOfFile;
        private MetroFramework.Controls.MetroPanel PanelResult;
        private MetroFramework.Controls.MetroButton ButtonStart;
        private MetroFramework.Controls.MetroTabPage TabPageAdmin;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonViewLog;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroPanel PanelUser;
        private MetroFramework.Controls.MetroButton ButtonChangeUser;
        private MetroFramework.Controls.MetroTextBox BoxCurrentUser;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton ButtonChangePassword;
        private MetroFramework.Controls.MetroTextBox BoxPassword;
        private MetroFramework.Controls.MetroButton ButtonChangeUsername;
        private MetroFramework.Controls.MetroPanel PanelPassword;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

