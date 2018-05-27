using System;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using JetBrains.Annotations;
using MetroFramework_test_at_a_new_project.Data;

namespace MetroFramework_test_at_a_new_project.Printing
{
    public class ResultSaver<T>
    {
        [NotNull] private T[] result = new T[0];

        public ResultSaver(T[] result, string itemResultSeparator = null)
        {
            this.itemResultSeparator = itemResultSeparator ?? Environment.NewLine;
            Result                   = result;
        }

        [NotNull]
        public T[] Result
        {
            get => result;
            set
            {
                result = value ?? throw new ArgumentNullException(nameof(ResultSaver<T>.Result));

                ResultBuilder = new StringBuilder(Result.Length);
                foreach (var t in Result)
                {
                    ResultBuilder.Append(t + itemResultSeparator);
                }
            }
        }

        [NotNull] private readonly string itemResultSeparator;

        public StringBuilder ResultBuilder { get; private set; }

        public string DirectoryForResult { get; set; } = "";

        /// <summary>
        /// Сохраняет результат в текстовый файл
        /// </summary>
        /// <param name="progress">куда отправлять прогресс выполнения</param>
        /// <param name="filePath">путь к файлу, куда сохранить</param>
        /// <param name="isFullPath">если false, то путь к файлу считается локальным</param>
        public void SaveTextResultTo(IProgress<int> progress, string filePath = null, bool isFullPath = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "result.txt";
            }

            var path = isFullPath is true ? filePath : DirectoryForResult + @"\" + filePath;

            var str              = ResultBuilder.ToString();
            var numberInsertions = str.Length / 5_000;
            var lastInsertion    = str.Length % 5_000;
            var nprogresses      = numberInsertions;
            if (lastInsertion > 0)
            {
                nprogresses++;
            }

            var progressValue = 0.0;
            var progressUnit  = 100d / nprogresses;


            // тут я создаю файл и записываю в него StringBuider.ToString();

            using (var stream = File.OpenWrite(path))
            {
                var writer = new StreamWriter(stream);

                for (var i = 0; i < numberInsertions; i++)
                {
                    writer.Write(str.Substring(i * 5_000, 5_000));
                    progress.Report((int) (progressValue += progressUnit));
                }

                if (lastInsertion > 0)
                {
                    writer.Write(str.Substring(str.Length - lastInsertion, lastInsertion));
                    progress.Report((int) (progressValue + progressUnit));
                }

                writer.Flush();
            }
        }

        /// <summary>
        /// Сохраняет результат в pdf файл
        /// </summary>
        /// <param name="progress">куда отправлять прогресс выполнения</param>
        /// <param name="filePath">путь к файлу, куда сохранить</param>
        /// <param name="isFullPath">если false, то путь к файлу считается локальным</param>
        public void SavePdfResultTo([CanBeNull] IProgress<int> progress, string filePath = null, bool isFullPath = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "result.pdf";
            }

            var path = isFullPath is true ? filePath : DirectoryForResult + @"\" + filePath;
            progress?.Report(0);


            var str = ResultBuilder.ToString();
            var numberInsertions = str.Length / 5_000;
            var lastInsertion    = str.Length % 5_000;
            var nprogresses = numberInsertions;
            if (lastInsertion > 0)
            {
                nprogresses++;
            }

            var progressValue = 0.0;
            var progressUnit = 100d / nprogresses;

            //создание и работа с pdf документом используя itextsharp
            using (var stream = File.OpenWrite(path))
            {
                var document = new Document(PageSize.LETTER, 20, 20, 40, 40);
                using (document)
                {
                    // ReSharper disable once UnusedVariable
                    var pdfWriter =
                        PdfWriter.GetInstance(document, stream); // не понимаю как, но зачем-то это нужно.
                    document.Open();                             // opens the document
                    document.AddCreator(Users.CurrentUserName);


                    for (var i = 0; i <numberInsertions ; i++)
                    {
                        var paragraph = new Paragraph(str.Substring(i*5_000, 5_000));
                        document.Add(paragraph);
                        progress.Report((int)(progressValue+=progressUnit));
                    }

                    if (lastInsertion > 0)
                    {
                        var paragraph = new Paragraph(str.Substring(str.Length-lastInsertion, lastInsertion));
                        document.Add(paragraph);
                        progress.Report((int) (progressValue + progressUnit));
                    }

                    document.Close();
                }
            }


            //throw new NotImplementedException();
        }

        /// <summary>
        /// "Установить путь, где будет сохраняться результат"
        /// </summary>
        /// <param name="directory">новый путь</param>
        public void SetDirectoryForResult(string directory)
        {
            DirectoryForResult = directory ?? throw new ArgumentNullException(nameof(directory));
            if (! Directory.Exists(directory))
            { // directory точно не null, иначе вышли бы уже по throw ArgumentNullException

                Directory.CreateDirectory(directory);
            }
        }
    }
}