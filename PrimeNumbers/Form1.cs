using System;
using System.CodeDom;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using MetroFramework_test_at_a_new_project.Data;

namespace MetroFramework_test_at_a_new_project
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            BoxDirectoryForResult.Text   = Environment.CurrentDirectory;
            CBoxTypeOfFile.SelectedIndex = 0;
            TabPageAdmin.Parent = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fabout = new FormAboutProgram();
            fabout.ShowDialog();

            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess == null)
                Close();
            else
            {
                Users.CurrentUser = Users.FindUserByName(signInForm.UserNameIfSuccess);
                BoxCurrentUser.Text   = Users.CurrentUserName;
            }
        }

        private void ButtonChangeUser_Click(object sender, EventArgs e)
        {
            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess != null)
            {
                Users.CurrentUser = Users.FindUserByName(signInForm.UserNameIfSuccess);
                BoxCurrentUser.Text   = Users.CurrentUserName;
            }
        }

        private void MetroTabPage1_Click(object sender, EventArgs e) {}

        private void BoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsDigit((char) e.KeyValue))
            {
                if (e.KeyValue == 13) // Enter
                {
                    ButtonStart_Click(sender, e);
                    return;
                }

                e.SuppressKeyPress = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
// Проверка на 0
            if (BoxNumber.Text == string.Empty ||
                BoxNumber.Text == @"0")
            {
                MessageBox.Show(@"Введите N > 0, чтобы начать вычисления");
                return;
            }

            PanelResult.Visible = true;
            var N = int.Parse(BoxNumber.Text);
            //Здесь будет вызов функции
            //Кроме этого, надо сделать сохранение в файл "Кто и что делал" (Файл log.cs.)
            //Еще сделать типа админскую часть "Просмотеть лог", 
            //а также "Удалить пользователя" (Ну мало ли, попросили)
            //Как - отдельная вкладка с этими функциями. 
            //Видна только если пользователь зашел под записью 
            //Админа (Админ также может просмотреть и изменить свою запись)
        }

        private void CBoxTypeOfFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSaveResultTo.Visible =
                (CBoxTypeOfFile.SelectedIndex == 0);
        }

        private void BtAbout_Click(object sender, EventArgs e)
        {
            var form = new FormAboutProgram();
            form.Show();
        }

        private void ButtonPassword_Click(object sender, EventArgs e)
        {
            if(BoxPassword.ReadOnly)
            {
                BoxPassword.ReadOnly = false;
                BoxPassword.Text     = Users.CurrentUser.PassWord;
                ButtonPassword.Text  = @"Сохранить";
            }
            else
            {
                if (BoxPassword.Text == "")
                {
                    MessageBox.Show("Пароль не может быть пустым", "Ошибка");
                    return;
                }

                Users.CurrentUser = new Users.User(Users.CurrentUserName, BoxPassword.Text);
                BoxPassword.ReadOnly = true;

                ButtonPassword.Text  = @"Изменить";
                BoxPassword.Text = "";
                BoxPassword.WaterMark = "Пароль изменен";
                Users.SaveToFile();

            }
        }

        private void BoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsWhiteSpace((char) e.KeyValue) &&
                !char.IsControl((char) e.KeyValue))
                e.SuppressKeyPress = true;
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            dialog.ShowDialog();
            BoxDirectoryForResult.Text = dialog.SelectedPath;
        }
    }
}