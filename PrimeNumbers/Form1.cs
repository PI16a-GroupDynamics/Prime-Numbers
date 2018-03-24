using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetBrains.Annotations;
using MetroFramework_test_at_a_new_project.Algorythms;
using MetroFramework_test_at_a_new_project.Data;
using MetroFramework_test_at_a_new_project.Printing;
using Microsoft.Office.Interop.Excel;
using Action = System.Action;
using Application = Microsoft.Office.Interop.Excel.Application;

// ReSharper disable PossibleNullReferenceException

namespace MetroFramework_test_at_a_new_project
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public partial class Form1: Form
    {
        private Thread excelThread;
        private Thread resultThread;

        public Form1()
        {
            InitializeComponent();
            BoxDirectoryForResult.Text   = Environment.CurrentDirectory;
            CBoxTypeOfFile.SelectedIndex = 0;
            TabPageAdmin.Parent          = null;
            MaximizeBox                  = false;
            MinimizeBox                  = false;
        }


        private void ShowHelp(object o, CancelEventArgs e)
        {
            MessageBox.Show(@"Просто закройте эту форму.");
            Cursor = DefaultCursor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Users.CheckPathOrCreate(Users.DefaultFilePath);
            Users.CheckPathOrCreate(Log.DefaultFilePath);

            var fabout = new FormAboutProgram();
            fabout.ShowDialog();

            Users.LoadFromFile();

            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess == null)
            {
                Close();
            }
            else
            {
                Users.SetCurrentUser(signInForm.UserNameIfSuccess);
                BoxCurrentUser.Text = Users.CurrentUserName;
                IfAdmin();
            }
        }

        private void ButtonChangeUser_Click(object sender, EventArgs e)
        {
            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess != null)
            {
                Users.SetCurrentUser(signInForm.UserNameIfSuccess);
                BoxCurrentUser.Text = Users.CurrentUserName;
                IfAdmin();
            }
        }

        private void IfAdmin()
        {
            // Про админа
            TabPageAdmin.Parent =
                Users.CurrentUser.Name.Equals(Users.DefaultAdmin.Name) ? metroTabControl1 : null;
        }

        private void MetroTabPage1_Click(object sender, EventArgs e) {}

        private void BoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (! char.IsDigit((char) e.KeyValue) &&
                ! char.IsControl((char) e.KeyValue))
            {
                if (e.KeyValue == 13)
                {
                    // Enter
                    ButtonStart_Click(sender, e);
                    return;
                }

                e.SuppressKeyPress = true;
            }
        }


        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Проверка на 0
            if (BoxNumber.Text == string.Empty ||
                BoxNumber.Text == @"0")
            {
                MessageBox.Show(@"Введите N > 0, чтобы начать вычисления");
                return;
            }

            PanelResult.Visible     = true;
            ButtonInterrupt.Visible = true;
            ButtonStart.Enabled     = false;
            var N = int.Parse(BoxNumber.Text);
            if (N <= 0)
            {
                return;
            }

            var directoryForResult = BoxDirectoryForResult.Text;

            resultThread = new Thread(() => { Parallel.Invoke(WorkWithResult); });
            resultThread.Start();
            Log.AddToFile(new LogRecord(Users.CurrentUserName, N));


            void WorkWithResult()
            {
                BoxResult.Invoke(new Action(() => { BoxResult.Clear(); }));
                //PanelUser.Invoke(new Action(() => { PanelUser.Enabled = false; }));
                PanelSaveResultTo.Invoke(new Action(() => { PanelSaveResultTo.Enabled = false; }));
                ButtonChangeUser.Invoke(new Action(() => { ButtonChangeUser.Enabled   = false; }));


                var sbResultForTextBox = new StringBuilder(N * 5);
                var progress           = 0.0;
                var typeOfFile         = 0;
                CBoxTypeOfFile.Invoke(new Action(() => { typeOfFile = CBoxTypeOfFile.SelectedIndex; }));

                var progressStep = 100d / N / 2;
                var progressAction = new Action(() =>
                {
                    progressBar1.Value = (int) (progress += progressStep);
                });
                var result = new int[N];
                result[0] = PrimeNumbers.Next_prime(0);
                progressBar1.Invoke(progressAction);
                for (var i = 0; i < result.Length - 1; i++)
                {
                    result[i + 1] = PrimeNumbers.Next_prime(result[i]);
                    progressBar1.Invoke(progressAction);
                }

                foreach (var number in result)
                {
                    sbResultForTextBox.AppendLine(number.ToString());
                    progressBar1.Invoke(progressAction);
                }

                BoxResult.Invoke(new Action(() => { BoxResult.Text = sbResultForTextBox.ToString(); }));

                if (typeOfFile <= 0)
                {
                    goto FinalActions;
                }

                #region SaveToFile

                var resultSaver =
                    new ResultSaver<int>(result, SettingsForResult.ItemResultSeparator);

                try
                {
                    resultSaver.SetDirectoryForResult(directoryForResult);
                }
                catch (Exception)
                {
                    MessageBox.Show($@"Не удается создать указанный путь ""{
                                            directoryForResult
                                        }"" для сохранения результата. Возможно, вы назначили сохранение на флешку, а затем вытащили ее.");
                    return;
                }

                var actionsSaveResult = new Dictionary<int, Action<string, bool>>
                {
                    [1] = resultSaver.SaveTextResultTo,
                    [2] = resultSaver.SavePdfResultTo
                };
                actionsSaveResult[CBoxTypeOfFile.SelectedIndex].Invoke(string.Empty, false);
                if (CBoxTypeOfFile.SelectedIndex > 0)
                {
                    MessageBox.Show($@"Результат сохранен в указанную папку ""{directoryForResult}""",
                                    @"Уведомление");
                }
                

                #endregion

                FinalActions:

                #region FinalActions

                progressBar1.Invoke(new Action(() => { progressBar1.Value = 0; }));
                //PanelUser.Invoke(new Action(() => { PanelUser.Enabled                 = true; }));
                PanelSaveResultTo.Invoke(new Action(() => { PanelSaveResultTo.Enabled = true; }));
                ButtonChangeUser.Invoke(new Action(() => { ButtonChangeUser.Enabled   = true; }));

                ButtonInterrupt.Invoke(new Action(() => { ButtonInterrupt.Visible = false; }));
                ButtonStart.Invoke(new Action(() => { ButtonStart.Enabled         = true; }));

                #endregion
            }
        }

        private void CBoxTypeOfFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSaveResultTo.Visible =
                CBoxTypeOfFile.SelectedIndex != 0;
        }

        private void BtAbout_Click(object sender, EventArgs e)
        {
            var form = new FormAboutProgram();
            form.Show();
        }

        private void ButtonPassword_Click(object sender, EventArgs e)
        {
            if (BoxPassword.ReadOnly)
            {
                BoxPassword.ReadOnly      = false;
                BoxPassword.Text          = Users.CurrentUser.PassWord;
                ButtonChangePassword.Text = @"Сохранить";
            }
            else
            {
                if (BoxPassword.Text == string.Empty)
                {
                    MessageBox.Show(@"Пароль не может быть пустым", @"Ошибка");
                    return;
                }

                Users.CurrentUser.PassWord = BoxPassword.Text;
                BoxPassword.ReadOnly       = true;

                ButtonChangePassword.Text = @"Изменить";
                BoxPassword.Text          = string.Empty;
                BoxPassword.WaterMark     = "Пароль изменен";
            }
        }

        private void BoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsWhiteSpace((char) e.KeyValue) &&
                ! char.IsControl((char) e.KeyValue))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            var helpPath = "..\\Help\\programHelp.chm";
            while (! File.Exists(helpPath))
            {
                MessageBox.Show(@"Не удается открыть файл помощи. Выберите файл.");
                //диалог
                var dialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.CurrentDirectory,
                    Filter           = @"Файлы справки (*.chm)|*.chm|Все файлы (*.*)|*.*",
                    Multiselect      = false
                };

                var dialogResult = dialog.ShowDialog();
                if (dialogResult is DialogResult.Yes ||
                    dialogResult is DialogResult.OK)
                {
                    helpPath = dialog.FileName;
                }
                else
                {
                    return;
                }
            }

            Help.ShowHelp(this, helpPath);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
                {RootFolder = Environment.SpecialFolder.MyComputer};
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BoxDirectoryForResult.Text = dialog.SelectedPath;
            }
        }

        private void PanelPassword_Leave(object sender, EventArgs e)
        {
            BoxPassword.Text          = string.Empty;
            BoxPassword.WaterMark     = "<пароль>";
            BoxPassword.ReadOnly      = true;
            ButtonChangePassword.Text = @"Изменить";
        }

        private void ButtonUsers_Click([NotNull] object sender, [NotNull] EventArgs e)
        { // Т.к. юзеров, скорее всего, будет немного(50 - это уже много), то можно вывести все это в tableGrid. И еще сделать автоматический обработчик, что ячейка не может быть пустой. И первая ячейка(0,0) не изменяется, т.к. это admin.
            var userForm = new FormUsers();
            userForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resultThread != null &&
                resultThread.IsAlive)
            {
                if (MessageBox.Show(@"Генерация еще не закончена. Уверены, что хотите выйти?",
                                    @"Подтверждение", MessageBoxButtons.YesNo) !=
                    DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (resultThread != null &&
                resultThread.IsAlive)
            {
                resultThread.Abort();
            }

            Users.SaveToFile();
        }

        private void ButtonChangeUsername_Click(object sender, EventArgs e)
        {
            BoxCurrentUser.Text = BoxCurrentUser.Text.Trim();

            if (Users.CurrentUser.Equals(Users.DefaultAdmin))
            {
                MessageBox.Show(@"Имя администратора нельзя изменять", @"Ошибка");
                return;
            }

            if (BoxCurrentUser.ReadOnly)
            {
                BoxCurrentUser.ReadOnly   = false;
                BoxCurrentUser.Text       = Users.CurrentUser.Name;
                ButtonChangeUsername.Text = @"Сохранить";
            }
            else
            {
                if (BoxCurrentUser.Text == string.Empty)
                {
                    MessageBox.Show(@"Имя пользователя не может быть пустым", @"Ошибка");
                    return;
                }

                if (Users.CurrentUserName == BoxCurrentUser.Text)
                { // передумал изменять
                    return;
                }

                if (Users.SetNameUser(Users.CurrentUserName, BoxCurrentUser.Text))
                {
                    //Users.CurrentUser.Name = BoxCurrentUser.Text;
                    BoxCurrentUser.ReadOnly = true;

                    ButtonChangeUsername.Text = @"Изменить";
                    BoxCurrentUser.Text       = Users.CurrentUserName;
                    MessageBox.Show(@"Успешно");
                }
                else
                {
                    MessageBox.Show(@"Это имя пользователя уже занято, повторите ввод", @"Ошибка");
                }
            }
        }

        private void ButtonViewLog_Click(object sender, EventArgs e)
        {
            Log.LoadDefault();

            var logs = Log.GetLogRecords;
            if (logs.Count == 0)
            {
                MessageBox.Show(@"Список логов пуст. Показывать нечего.");
                return;
            }

            excelThread = new Thread(ShowLog);
            excelThread.Start();


            void ShowLog()
            {
                Parallel.Invoke(() =>
                {
                    LabelForExcel.Text = @"Открытие Excel...";
                    var       excelApp  = new Application();
                    var       workbook  = excelApp.Workbooks.Add();
                    Worksheet worksheet = workbook.Worksheets[1];

                    //делаю заголовки

                    worksheet.Cells[1, 1] = "Имя пользователя";
                    worksheet.Cells[1, 2] = "N";
                    worksheet.Cells[1, 3] = "дата и время операции";

                    var range1 = (Range) worksheet.Columns["A"];
                    var range2 = (Range) worksheet.Columns["B"];
                    var range3 = (Range) worksheet.Columns["C"];
                    range3.Columns.AutoFit();

                    for (var i = 1; i <= logs.Count; i++)
                    {
                        var record = logs[i - 1];
                        range1.Cells[i] = record.UserName;
                        range2.Cells[i] = record.N;
                        range3.Cells[i] = record.DateTime;
                    }


                    excelApp.Visible = true;
                    excelApp.UserControl =
                        true; // т.е. освобождение ресурсов объекта происходит при удалении его программно.
                    LabelForExcel.Text = string.Empty;
                });
            }
        }

        private void BoxDirectoryForResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PanelUser.Focus(); // просто убираю фокус с текстбокса
            }
        }

        private void BoxDirectoryForResult_Leave(object sender, EventArgs e)
        {
            BoxDirectoryForResult.Text = BoxDirectoryForResult.Text.Trim(' ', '.');
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var form = new FormResultLooksLike();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Очистить журнал?", @"Подтвердите удаление", MessageBoxButtons.YesNo) is
                DialogResult.Yes)
            {
                File.Delete(Log.DefaultFilePath);
            }
        }

        private void ButtonInterrupt_Click(object sender, EventArgs e)
        {
            if (! resultThread.IsAlive)
            {
                return;
            }

            resultThread
                .Abort(); // как я понял, безопасное прерывание. Да, это "Просит поток завершить работу"

            #region FinalActions

            progressBar1.Invoke(new Action(() => { progressBar1.Value = 0; }));
            /*Хоть и находится в том же потоке, где был создан, но:
                 1) Другой поток все еще работает с ним, делает свои действия (возможно, by Invoke, как надо.)
                 2) Из-за того, что другой поток использует Invoke, он ставит свои действия в очередь.
                 3) Если я тут просто присвою значения через = , то сразу после этого выполнятся действия в очереди... И будет похоже на странное поведение.*/
            //PanelUser.Invoke(new Action(() => { PanelUser.Enabled                 = true; }));
            PanelSaveResultTo.Invoke(new Action(() => { PanelSaveResultTo.Enabled = true; }));
            ButtonChangeUser.Invoke(new Action(() => { ButtonChangeUser.Enabled   = true; }));

            ButtonInterrupt.Invoke(new Action(() => { ButtonInterrupt.Visible = false; }));
            ButtonStart.Invoke(new Action(() => { ButtonStart.Enabled         = true; }));

            #endregion
        }
    }
}