using JetBrains.Annotations;
using MetroFramework_test_at_a_new_project.Algorythms;
using MetroFramework_test_at_a_new_project.Data;
using MetroFramework_test_at_a_new_project.Printing;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

// ReSharper disable PossibleNullReferenceException

namespace MetroFramework_test_at_a_new_project
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
            BoxDirectoryForResult.Text   = Environment.CurrentDirectory;
            CBoxTypeOfFile.SelectedIndex = 0;
            TabPageAdmin.Parent          = null;
            //MaximizeBox                  = false;
            //MinimizeBox                  = false;
        }


        private void ShowHelp(object o, CancelEventArgs e)
        {
            MessageBox.Show($@"Зайдите на вкладку 'Настройки' и вызовите справку нажатием на кнопку 'Справка'.");
            Cursor = DefaultCursor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            var fabout = new FormAboutProgram();
            fabout.ShowDialog();

            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess == null)
            {
                Close();
            }
            else
            {
                Users.SetCurrentUser(signInForm.UserNameIfSuccess);
                LabelUsername.Text = Users.CurrentUserName;
                IfAdmin();
            }
            TabControlMenu.SelectedIndex = 0;
        }

        private void ButtonChangeUser_Click(object sender, EventArgs e)
        {
            var signInForm = new FormSignIn();
            signInForm.ShowDialog();
            if (signInForm.UserNameIfSuccess != null)
            {
                Users.SetCurrentUser(signInForm.UserNameIfSuccess);
                LabelUsername.Text = Users.CurrentUserName;
                IfAdmin();
            }
        }

        private void IfAdmin()
        {
            // Про админа
            if (Users.CheckAdminPriveledge(Users.CurrentUser.Name))
            {
                TabPageAdmin.Parent = TabControlMenu;
            }
            else
            {
                TabPageAdmin.Parent = null;
            }
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
        private async void ButtonStart_Click(object sender, EventArgs e)
        { // Отмена задачи - исключительная ситуация. Наверное, нормально.
            // Проверка на 0
            if (BoxNumber.Text == string.Empty ||
                BoxNumber.Text == @"0")
            {
                MessageBox.Show(@"Введите N > 0, чтобы начать вычисления");
                return;
            }


            var N = int.Parse(BoxNumber.Text);


            #region StartActions

            BoxResult.Clear();
            PanelResult.Visible  = true;
            ButtonCancel.Visible = true;
            ButtonStart.Enabled  = false;
            ButtonCancel.Enabled = true;


            #endregion


            #region Job

            var dateTimeStart      = DateTime.Now;

            var cts                = new CancellationTokenSource();
            ButtonCancel.Click += (sender1, e1) => cts.Cancel();
            // анонимный метод, не лямбда. Лямбда - другой объект, который, тем не менее, может конвертироваться.
            Closing += (o, args) => cts.Cancel();

            IProgress<int> progress =
                new Progress<int>(percentage =>
                                      progressBar1.Value =
                                          percentage); // Handler - это Invoke, короче. Если быть точным, то SynchronizationContext.Post. Который посылает асинхронное сообщение в нужный синхр. контекст. Invoke, короче.

            var result = new long[N];
            //var    sbResultForTextBox = new StringBuilder(N * 5);
            var stringResult = string.Empty;

            var task = new Task(WorkWithResult, cts.Token);
            task.Start();
            label1.Text = @"Генерация...";

            try
            {
                await task.ConfigureAwait(true);
            }
            catch (OperationCanceledException)
            {
                // не знаю, что тут еще делать. Можно бы установить какой-то bool в true, но это и так есть в task.IsCanceled.
            }

            label1.Text = @"Вывод результата...";
            ButtonCancel.Enabled = false;
            if (! task.IsCanceled)
            {
                progress.Report(0);

                var numberInsertions = stringResult.Length / 10_000;
                var lastInsertion    = stringResult.Length % 10_1000;
                var progressValue = 0.0;
                var progressUnit = 100d / (numberInsertions + (lastInsertion > 0 ? 1 : 0));


                for (var i = 0; i < numberInsertions; i++)
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    BoxResult.AppendText(stringResult.Substring(i * 10_000,
                                                                10_000));
                    progress.Report((int)(progressValue += progressUnit));
                }

                if (lastInsertion != 0)
                {
                    await Task.Delay(1).ConfigureAwait(true);
                    BoxResult.AppendText(stringResult.Substring(stringResult.Length - lastInsertion,
                                                                lastInsertion));
                    progress.Report((int) (progressValue + progressUnit));
                }
            }

            ActionsLog.Add(new ActionsLogRecord(Users.CurrentUserName, N, task.IsCanceled, dateTimeStart));

            var typeOfFile = CBoxTypeOfFile.SelectedIndex;
            string directoryForResult;
            if (typeOfFile > 0)
            {
                directoryForResult = BoxDirectoryForResult.Text;
                label1.Text = @"Сохранение...";
                // ReSharper disable once MethodSupportsCancellation
                ButtonCancel.Enabled = false;
                await SaveToFile().ConfigureAwait(true); // отмены в этом методе нет.
                ButtonCancel.Enabled = true;
            }

            #endregion

            #region FinalActions

            progress.Report(0);

            PanelResultSettings.Enabled = true;
            ButtonChangeUser.Enabled  = true;

            ButtonCancel.Visible = false;
            ButtonStart.Enabled  = true;

            label1.Text = task.IsCanceled ? "Отменено" : "Готово";

            #endregion


            void WorkWithResult()
            {
                {
                    var sbResult      = new StringBuilder(N * 5);
                    var progressValue = 0.0;
                    var progressStep  = 100d / N / 2;

                    result[0] = PrimeNumbers.Next_prime(0);
                    progress.Report((int) (progressValue += progressStep * 2));

                    for (var i = 0; i < result.Length - 1; i++)
                    {
                        result[i + 1] = PrimeNumbers.Next_prime(result[i]);
                        cts.Token
                           .ThrowIfCancellationRequested();
                        progressValue += progressStep * 2;
                        if (i % 1000 == 0)
                        {
                            progress.Report((int) progressValue);
                        }
                    }

// ReSharper disable once ForCanBeConvertedToForeach
                    for (var i = 0; i < result.Length; i++)
                    {
                        var number = result[i];

                        sbResult.AppendLine(number.ToString());
                        cts.Token
                           .ThrowIfCancellationRequested();
                    }

                    stringResult = sbResult.ToString();
                }
            }

            Task SaveToFile()
            {
                var localTask = new Task(() =>
                {
                    var resultSaver =
                        new ResultSaver<long>(result, SettingsForResult.ItemResultSeparator);

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

                    var actionsSaveResult = new Dictionary<int, Action<IProgress<int>, string, bool>>
                    {
                        [1] = resultSaver.SaveTextResultTo,
                        [2] = resultSaver.SavePdfResultTo
                    };
                    actionsSaveResult[typeOfFile]
                        .Invoke(progress, string.Empty, false); //Invoke - потому что делегат.
                    if (typeOfFile > 0)
                    {
                        MessageBox.Show($@"Результат сохранен в указанную папку ""{directoryForResult}""",
                                        @"Уведомление");
                    }
                });
                localTask.Start();
                return localTask;
            }
        }

        private void CBoxTypeOfFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSaveResult.Enabled =
                CBoxTypeOfFile.SelectedIndex != 0;
        }

        private void BtAbout_Click(object sender, EventArgs e)
        {
            var form = new FormAboutProgram();
            form.Show();
        }

        private void ButtonPassword_Click(object sender, EventArgs e)
        {
            var form = new FormChangePassword();
            form.ShowDialog();
        }

        private void BoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsWhiteSpace((char) e.KeyValue) &&
                ! char.IsControl((char) e.KeyValue))
            {
                e.SuppressKeyPress = true;
            }
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
            
        }

        private void ButtonUsers_Click([NotNull] object sender, [NotNull] EventArgs e)
        { // Т.к. юзеров, скорее всего, будет немного(50 - это уже много), то можно вывести все это в tableGrid. И еще сделать автоматический обработчик, что ячейка не может быть пустой. И первая ячейка(0,0) не изменяется, т.к. это admin.
            
                var userForm = new FormUsers();
                userForm.Show();
             // "Запустить и забыть"
        }

        private void ButtonChangeUsername_Click(object sender, EventArgs e)
        {
            (new FormChangeUsername()).ShowDialog();
            LabelUsername.Text = Users.CurrentUserName;
            
           
        }

        /// <summary>
        /// Выводит в Excel записи обоих журналов (логов)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonViewLog_Click(object sender, EventArgs e)
        {

            var logs = Users.Log.GetLogRecords(); // list<LogRecord>
            logs.AddRange(ActionsLog.GetLogRecords());
            logs.Sort((record1,record2)
                =>
                record1.DateTime.CompareTo(record2.DateTime));


            if (logs.Count == 0)
            {
                MessageBox.Show(@"Журнал пуст. Показывать нечего.");
                return;
            }

            ButtonViewLog.Enabled = false;
            ButtonViewLog.Text    = @"Открытие Excel...";

            await Task.Run(() => ShowLog())
                      .ConfigureAwait(true); // и так по умолчанию вызовется в текущем контексте, т.е. UI, но чисто для понимания
            ButtonViewLog.Enabled = true;
            ButtonViewLog.Text    = @"Журнал";

            void ShowLog()
            {
                Parallel.Invoke(() =>
                {
                    var       excelApp  = new Application();
                    var       workbook  = excelApp.Workbooks.Add();
                    Worksheet worksheet = workbook.Worksheets[1];
                    //делаю заголовки

                    worksheet.Cells[1, 1] = "Время операции";
                    worksheet.Cells[1, 2] = "Действие";

                    var range1 = (Range) worksheet.Columns["A"];
                    var range2 = (Range) worksheet.Columns["B"];

                    for (var i = 1; i <= logs.Count; i++)
                    {
                        var record = logs[i - 1];
                        range1.Cells[i] = record.DateTime;
                        range2.Cells[i] = record.Message;
                    }
                    range1.Columns.AutoFit();
                    range2.Columns.AutoFit();

                    excelApp.Visible = true;
                    excelApp.UserControl =
                        true; // т.е. освобождение ресурсов объекта происходит при удалении его программно.
                });
            }
        }

        private void BoxDirectoryForResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PanelUserSettings.Focus(); // просто убираю фокус с текстбокса
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

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Очистить журнал?", @"Подтвердите удаление", MessageBoxButtons.YesNo) is
                DialogResult.Yes)
            {
                ActionsLog.Clear();
                Users.Log.Clear();
                MessageBox.Show("Журнал очищен");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            #region FinalActions

            //progressBar1.Invoke(new Action(() => { progressBar1.Value = 0; }));
            ///*Хоть и находится в том же потоке, где был создан, но:
            //     1) Другой поток все еще работает с ним, делает свои действия (возможно, by Invoke, как надо.)
            //     2) Из-за того, что другой поток использует Invoke, он ставит свои действия в очередь.
            //     3) Если я тут просто присвою значения через = , то сразу после этого выполнятся действия в очереди... И будет похоже на странное поведение.*/
            ////PanelUser.Invoke(new Action(() => { PanelUser.Enabled                 = true; }));
            //PanelSaveResultTo.Invoke(new Action(() => { PanelSaveResultTo.Enabled = true; }));
            //ButtonChangeUser.Invoke(new Action(() => { ButtonChangeUser.Enabled   = true; }));

            //ButtonInterrupt.Invoke(new Action(() => { ButtonInterrupt.Visible = false; }));
            //ButtonStart.Invoke(new Action(() => { ButtonStart.Enabled         = true; }));

            #endregion
        }

        private void BoxCurrentUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private  void metroButton4_Click(object sender, EventArgs e)
        {
            var path = Environment.CurrentDirectory;

            var str = "Screenshot_1.png";
            var image = Image.FromFile(str);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var helpPath = @"Help\Help.chm";
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

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}