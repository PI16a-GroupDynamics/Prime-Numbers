using System;
using System.Runtime.Serialization;
using System.Data.SQLite;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace MetroFramework_test_at_a_new_project.Data
{
    public static class Log
        {
            public static void Add(LogRecord record)
            {
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"Insert into ActionsLog (Username, Number, Datetime, IsCancelled)
                                values ('{record.UserName}','{record.N}','{record.DateTimeStart}','{record.IsCancelled}');";
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            public static List<LogRecord> GetLogRecords()
            {
                var records = new List<LogRecord>();    

                using(var connection = new SQLiteConnection($@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"select * from ActionsLog";
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            records.Add(new LogRecord(reader.GetString(0), reader.GetInt32(1), Convert.ToBoolean(reader.GetString(3)), Convert.ToDateTime(reader.GetString(2)) ));
                        }
                        
                    } 
                }

                return records;
            }

            public static void Clear()
            {
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            @"delete from ActionsLog where Username like '%'";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

    [Serializable]
    public class LogRecord: ISerializable
    {
        public LogRecord([NotNull] string userName, int n, bool isCancelled,
            DateTime dateAndTimeStart)
        {
            UserName    = userName;
            N           = n;
            IsCancelled = isCancelled;
            DateTimeStart    = dateAndTimeStart;

            // это крутой сахар для ??. Если не null, то возвращает value, а не саму переменную, которая типа Nullable<T>.
        }

        private LogRecord(SerializationInfo info, StreamingContext context)
        { // этот конструктор используется при десериализации
            UserName = info.GetString(nameof(LogRecord.UserName));
            N = info.GetInt32(nameof(LogRecord.N));
            IsCancelled = info.GetBoolean(nameof(LogRecord.IsCancelled));
            DateTimeStart = info.GetDateTime(nameof(LogRecord.DateTimeStart));
        }

        [NotNull]
        public string UserName { get; }

        public int N { get; }

        public DateTime DateTimeStart { get; }

        public bool IsCancelled { get; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        { // используется при сериализации
            info.AddValue(nameof(LogRecord.UserName),    UserName);
            info.AddValue(nameof(LogRecord.N),           N);
            info.AddValue(nameof(LogRecord.IsCancelled), IsCancelled);
            info.AddValue(nameof(LogRecord.DateTimeStart),    DateTimeStart); 
            
        }
    }
}