using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project.Data
{
    public static class Log
    {
        private static List<LogRecord> log = new List<LogRecord>();

        public static string DefaultFilePath { get; set; } = @"Records\log.bin";

        public static List<LogRecord> GetLogRecords => Log.log;

        public static void Add(LogRecord record) => Log.log.Add(record);

        public static void AddToFile(LogRecord record, string filePath)
        {
            Log.CheckPathOrCreate(filePath);

            using (Stream stream = File.Open(filePath, FileMode.Append))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(stream, record);
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

            Log.log = new List<LogRecord>();
            // считывание в список по одной записи.
            using (Stream stream = File.OpenRead(filePath))
            {
                var bf = new BinaryFormatter();

                while (stream.Position < stream.Length)
                {
                    Log.log.Add(bf.Deserialize(stream) as LogRecord);
                }
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

            using (Stream stream = File.OpenWrite(filePath))
            {
                var bf = new BinaryFormatter();

                foreach (var record in Log.log)
                {
                    bf.Serialize(stream, record);
                }
            }
        }
    }

    [Serializable]
    public class LogRecord: ISerializable
    {
        public LogRecord([NotNull] string userName, int n, DateTime? dateAndTime = null)
        {
            UserName = userName;
            N        = n;
            DateTime = dateAndTime ?? DateTime.Now;

            // это крутой сахар для ??. Если не null, то возвращает value, а не саму переменную, которая типа Nullable<T>.
        }

        private LogRecord(SerializationInfo info, StreamingContext context)
        { // этот конструктор используется при десериализации
            UserName = info.GetString("UserName");
            N        = info.GetInt32("N");
            DateTime = info.GetDateTime("DateTime");
        }

        [NotNull]
        public string UserName { get; }

        public int N { get; }

        public DateTime DateTime { get; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        { // используется при сериализации
            info.AddValue("UserName", UserName);
            info.AddValue("N",        N);
            info.AddValue("DateTime", DateTime);
        }
    }
}