using System;
using System.Windows.Forms;
using MetroFramework_test_at_a_new_project.Data;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormChangeUsername : Form
    {
        public FormChangeUsername()
        {
            InitializeComponent();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtChangeUsername_Click(object sender, EventArgs e)
        {
            if (TbOldUsername.Text == TbNewUsername.Text)
                { // передумал изменять
                MessageBox.Show("Старый логин совпадает с новым, ничего не произошло");
                return;
                }
                
                if (Users.SetNameUser(Users.CurrentUserName, TbNewUsername.Text))
                {
                    Users.CurrentUser.Name = TbNewUsername.Text;

                    //BoxCurrentUser.Text = Users.CurrentUserName;
                    MessageBox.Show(@"Успешно");
                }
                else
                {
                    MessageBox.Show(@"Это имя пользователя уже занято, повторите ввод", @"Ошибка");
                }
        }

        private void FormChangeUsername_Load(object sender, EventArgs e)
        {
            TbOldUsername.Text = Users.CurrentUserName;
            TbNewUsername.Text = TbOldUsername.Text;
        }
    }
}
