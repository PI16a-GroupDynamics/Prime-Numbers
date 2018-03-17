using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using MetroFramework_test_at_a_new_project.Data;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormSignIn: Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        void ShowHelp(object o, CancelEventArgs e)
        {
            MessageBox.Show(@"Просто закройте эту форму.");
            Cursor = DefaultCursor;
        }

        public string UserNameIfSuccess { get; private set; }

        [SuppressMessage("ReSharper", "ArrangeThisQualifier")]
        private void BtSignIn_Click(object sender, EventArgs e)
        {
            if (PnConfirmPassword.Visible)
            { // мы находимся в "регистрация"
                PnConfirmPassword.Visible = false;
                return;
            }

            PnConfirmPassword.Visible = false;
            var username = TbUserName.Text.Trim();
            var password = TbPassword.Text.Trim();

            if (UserNamePassWordCheckIsEmpty())
            {
                return;
            }

            // а теперь мы ищем имя пользователя в каком-то списке. В файле, наверное.
            if (Users.Contains(username, password))
            {
                UserNameIfSuccess = username;
                Close();
            }
            else
            {
                if (! Users.Contains(username))
                {
                    MessageBox.Show(@"Неверное имя пользователя", @"Ошибка");
                    TbUserName.Focus();
                    return;
                }

                MessageBox.Show(@"Неверный пароль.");
                TbPassword.Focus();
                TbPassword.Clear();
            }
        }

        private void BtSignUp_Click(object sender, EventArgs e)
        {
            if (! PnConfirmPassword.Visible)
            { // мы находимся в "Вход"
                PnConfirmPassword.Visible = true;
                return;
            }

            PnConfirmPassword.Visible = true;
            var username        = TbUserName.Text.Trim();
            var password        = TbPassword.Text.Trim();
            var confirmPassword = TbConfirmPassword.Text.Trim();

            UserNamePassWordCheckIsEmpty();
            if (password != confirmPassword)
            {
                MessageBox.Show(@"Подтверждение не совпадает с паролем", @"Ошибка");
                TbConfirmPassword.Focus();
                return;
            }

            // а теперь мы ищем имя пользователя в каком-то списке. В файле, наверное.
            if (Users.Contains(username))
            {
                MessageBox.Show(@"Это имя пользователя уже занято", @"Ошибка");
                TbUserName.Focus();
            }
            else
            {
                Users.Add(username, password);
                MessageBox.Show(@"Успешно!");
            }
        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsWhiteSpace((char) e.KeyValue) &&
                ! char.IsControl((char) e.KeyValue))
            {
                e.SuppressKeyPress = true;
            }
        }

        private bool UserNamePassWordCheckIsEmpty()
        {
            while (true)
            {
                if (TbUserName.Text == string.Empty)
                {
                    MessageBox.Show(@"Имя пользователя не может быть пустым", @"Ошибка!");
                    return true;
                }

                if (TbPassword.Text == string.Empty)
                {
                    MessageBox.Show(@"Пароль не может быть пустым", @"Ошибка!");
                    return true;
                }

                return false;
            }
        }

        private void FormSignIn_Load(object sender, EventArgs e) {}

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e) {}

        private void TbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (PnConfirmPassword.Visible)
                {
                    BtSignUp_Click(sender, e);
                }
            }
        }

        [SuppressMessage("ReSharper", "InvertIf")]
        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (! PnConfirmPassword.Visible)
                {
                    BtSignIn_Click(sender, e);
                }
            }
        }
    }
}