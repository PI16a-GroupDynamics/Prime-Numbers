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
        [NotNull] private T[] result;

        public ResultSaver(T[] result)
        {
            Result = result ?? throw new ArgumentNullException(nameof(result));

            ResultBuilder = new StringBuilder(Result.Length);
            foreach (var t in Result)
            {
                ResultBuilder.AppendLine(t.ToString());
            }
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
                    ResultBuilder.AppendLine(t.ToString());
                }
            }
        }

        public StringBuilder ResultBuilder { get; private set; }

        public string DirectoryForResult { get; set; } = "";

        public void SaveTextResultTo(string filePath = null, bool isFullPath = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "result.txt";
            }

            var path = isFullPath is true ? filePath : DirectoryForResult + @"\" + filePath;

            // тут я создаю файл и записываю в него StringBuider.ToString();

            using (var stream = File.OpenWrite(path))
            {
                var writer = new StreamWriter(stream);
                writer.Write(ResultBuilder.ToString());
                writer.Flush();
            }
        }

        public void SavePdfResultTo(string filePath = null, bool isFullPath = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "result.pdf";
            }

            var path = isFullPath is true ? filePath : DirectoryForResult + @"\" + filePath;

            //создание и работа с pdf документом используя itextsharp
            using (var stream = File.OpenWrite(path))
            {
                var document = new Document(PageSize.LETTER, 20, 20, 40, 40);
                using (document)
                {
                    // ReSharper disable once UnusedVariable
                    var pdfWriter = PdfWriter.GetInstance(document, stream); // не понимаю как, но зачем-то это нужно.
                    document.Open(); // opens the document
                    document.AddCreator(Users.CurrentUserName);
                    var paragraph = new Paragraph(ResultBuilder.ToString());
                    document.Add(paragraph);

                    document.Close();
                }
            }


            //throw new NotImplementedException();
        }

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