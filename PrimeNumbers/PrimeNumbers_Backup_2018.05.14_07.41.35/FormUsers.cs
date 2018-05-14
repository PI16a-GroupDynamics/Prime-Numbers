﻿using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework_test_at_a_new_project.Data;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormUsers: Form
    {
        private bool[] rowsToDelete;

        public FormUsers()
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

        private void FormUsers_Load(object sender, EventArgs e)
        {
            foreach (var user in Users.GetListUsers())
            {
                TableUsers.Rows.Add(user.Name, user.IsAdmin, user.PassWord );
            }

            rowsToDelete                                  = new bool[TableUsers.RowCount];
            TableUsers.Rows[0].DefaultCellStyle.BackColor = Color.BurlyWood;
        }

        [SuppressMessage("ReSharper", "InvertIf")]
        private void TableUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index == 0)
            {
                MessageBox.Show(@"Администратора нельзя удалить.", @"Ошибка");
                e.Cancel = true;
            }
            else
            {
                if (rowsToDelete[e.Row.Index] is false) // если нет в массиве удаляемых
                {
                    e.Row.DefaultCellStyle.Font      = new Font(Control.DefaultFont, FontStyle.Strikeout);
                    e.Row.DefaultCellStyle.ForeColor = Color.Firebrick;
                    rowsToDelete[e.Row.Index]        = true;
                }
                else
                {
                    e.Row.DefaultCellStyle.Font      = Control.DefaultFont;
                    e.Row.DefaultCellStyle.ForeColor = Control.DefaultForeColor;
                    rowsToDelete[e.Row.Index]        = false;
                }

                e.Cancel = true;
            }
        }

        private void TableUsers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var currentCell = TableUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (currentCell.ColumnIndex is 0 || currentCell.ColumnIndex is 2)
            {
                return;
            }

            var str     = e.FormattedValue.ToString();
            var trimStr = str.Trim();
            if (string.IsNullOrEmpty(trimStr))
            {
                MessageBox.Show(@"Поле не может быть пустым", @"Error");
                e.Cancel = true;
                return;
            }

            if (!bool.TryParse(str,out var _))
            {
                MessageBox.Show(@"Значение не может быть преобразовано в логическое.", @"Error");
                e.Cancel = true;
            }
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e) {}

        private void ButtonCancelChanges_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            TableUsers.Rows.Clear();
            foreach (var user in Users.GetListUsers())
            {
                TableUsers.Rows.Add(user.Name, user.IsAdmin, user.PassWord );
            }

            rowsToDelete                                  = new bool[TableUsers.RowCount];
            TableUsers.Rows[0].DefaultCellStyle.BackColor = Color.BurlyWood;
        }

        private void UpdateListFromTable()
        {
            if (TableUsers.RowCount is 0)
            {
                throw new ArgumentException("Нет строк в таблице. Количество строк должно быть минимум 1.");
            }

            for (var i = 0; i < rowsToDelete.Length; i++)
            {
                if (rowsToDelete[i] is true)
                {
                    Users.DeleteUser(TableUsers.Rows[i].Cells[0].Value.ToString());
                } 
            }

            var users = Users.GetListUsers();
            for (var i = 0; i < TableUsers.Rows.Count; i++)
            {
                var controlUser =
                    users.Find(user => user.Name == TableUsers.Rows[i].Cells[0].Value.ToString());
                if (TableUsers.Rows[i].Cells["IsAdmin"].Value.ToString() != controlUser.IsAdmin.ToString())
                {
                    Users.SetAdminPriveledgeUser(controlUser.Name,
                                                 Convert.ToBoolean(TableUsers.Rows[i].Cells["IsAdmin"].Value.ToString()));
                }
            }
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            UpdateListFromTable();
            UpdateTable();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}