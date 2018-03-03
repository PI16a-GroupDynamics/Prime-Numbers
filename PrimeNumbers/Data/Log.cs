using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MetroFramework_test_at_a_new_project.Data
{
    public static class Log
    {
        private static List <LogRecord> log;
        public static string DefaultFilePath { get; set; } = @"Records\log.bin";

        public static void LoadFrom(string filePath)
        {
            var path = filePath;
            if (!File.Exists(path))
            {
                Log.log = default;
                File.Create(path);
                return;
            }
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                var formatter = new BinaryFormatter();
                Log.log = formatter.Deserialize(stream) as List <LogRecord>;
            }
        }

        public static void LoadDefault() => Log.LoadFrom(Log.DefaultFilePath);

        public static void SaveTo(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Log.log);
            }
        }

        public static void SaveDefault() => Log.SaveTo(Log.DefaultFilePath);

        public static void Add(LogRecord record) => Log.log.Add(record);

        public static void AddToFile(LogRecord record, string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Append))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, record);
            }

        }

        public static void AddToFile(LogRecord record) => Log.AddToFile(record, Log.DefaultFilePath);

    }

    [Serializable]
    public struct LogRecord
    {
        public string UserName { get; }
        public int N { get; }

        public DateTime DateTime{
            get;
        }

        public LogRecord(string userName, int n, DateTime? dateAndTime = null )
        {
            UserName = userName;
            N = n;
            DateTime = dateAndTime ?? DateTime.Now; 
// это крутой сахар для ??. Если не null, то возвращает value, а не саму переменную.


        }
    }
}
