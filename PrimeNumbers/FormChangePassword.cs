using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetroFramework_test_at_a_new_project.Encryption.Extensions;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            HelpButton = true;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            TbUsername.Text = Data.Users.CurrentUserName;
        }

        private void TbOldPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void BtChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbPassword.Text) || string.IsNullOrWhiteSpace(TbConfirmPassword.Text))
            {
                MessageBox.Show("Пароль не может быть пустым!","Ошибка");
                return;
            }

            if (! (Data.Users.CurrentUser.PassWord == TbOldPassword.Text.Trim().EncryptToBase64String()))
            {
                MessageBox.Show(@"Пароль неверен", "Ошибка");
                TbOldPassword.Focus();
                return;
            }

            if (TbPassword.Text != TbConfirmPassword.Text)
            {
                MessageBox.Show("Подтвеждение не совпадает с паролем.","Ошибка");
                TbConfirmPassword.Focus();
                return;
            }

            if(Data.Users.SetPasswordUser(TbUsername.Text, TbPassword.Text)){
                Data.Users.CurrentUser.PassWord = TbPassword.Text.EncryptToBase64String();
                MessageBox.Show("Пароль сменен успешно.");
            }
            else
            {
                MessageBox.Show("Не удалось сменить пароль. Пользователя с таким именем не существует.", "Что-то пошло не так");
            }
        }

        private void TbOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue is 32)
            {
                e.SuppressKeyPress = true;     
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowHelp(object sender, CancelEventArgs e)
        {
            MessageBox.Show($@"Введите в поле 'Старый пароль' тот пароль, который стоит сейчас.{Environment.NewLine}Введите в поле 'Новый пароль' тот пароль, который вы хотите поставить.{Environment.NewLine}Введите новый пароль еще раз в поле 'Подтвердите пароль'");
        }
    }
}
