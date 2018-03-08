using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project.Data
{
    public static class Log
    {
        private static List<LogRecord> log;

        public static string DefaultFilePath { get; set; } = @"Records\log.bin";

        public static void Add(LogRecord record) => Log.log.Add(record);

        public static void AddToFile(LogRecord record, string filePath)
        {
            Log.CheckPathOrCreate(filePath);

            using (var stream = File.Open(filePath, FileMode.Append))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, record);
            }
        }

        public static void AddToFile(LogRecord record) => Log.AddToFile(record, Log.DefaultFilePath);

        public static void LoadDefault() => Log.LoadFrom(Log.DefaultFilePath);

        public static void LoadFrom([NotNull] string filePath)
        {
            Log.CheckPathOrCreate(filePath);

            if (! File.Exists(filePath))
            { // Если файла нет, то мы инициализируем лог как пустой лог (не null, это важно) и выходим. Создавать файл будем при записи.
                Log.log = new List<LogRecord>();
                return;
            }
            

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                var formatter = new BinaryFormatter();
                Log.log = formatter.Deserialize(stream) as List<LogRecord>;
            }

        }

        public static void SaveDefault() => Log.SaveTo(Log.DefaultFilePath);

        private static void CheckPathOrCreate(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (! Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static void SaveTo(string filePath)
        {
            Log.CheckPathOrCreate(filePath);

            using (var stream = File.Open(filePath, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Log.log);
            }
        }
    }

    [Serializable]
    public struct LogRecord
    {
        public string UserName { get; }

        public int N { get; }

        public DateTime DateTime { get; }

        public LogRecord(string userName, int n, DateTime? dateAndTime = null)
        {
            UserName = userName;
            N        = n;
            DateTime = dateAndTime ?? DateTime.Now;

            // это крутой сахар для ??. Если не null, то возвращает value, а не саму переменную, которая типа Nullable<T>.
        }
    }
}