using System;
using System.Data.SQLite;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace MetroFramework_test_at_a_new_project.Data
{
    public static class ActionsLog
        {
            /// <summary>
            /// Добавляет запись в базу данных
            /// </summary>
            /// <param name="record"></param>
            public static void Add(ActionsLogRecord record)
            {
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"Insert into ActionsLog (Datetime, Message)
                                values ('{record.DateTime}','{record.Message}');";
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            /// <summary>
            /// Получает все записи из таблицы в БД
            /// </summary>
            /// <returns>список записей из таблицы</returns>
            public static List<ActionsLogRecord> GetLogRecords()
            {
                var records = new List<ActionsLogRecord>();    

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
                            records.Add(new ActionsLogRecord(reader.GetString(1), Convert.ToDateTime(reader.GetString(0))));
                        }
                        
                    } 
                }

                return records;
            }
            
            /// <summary>
            /// Очищает таблицу
            /// </summary>
            public static void Clear()
            {
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            @"delete from ActionsLog";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    /// <summary>
    /// Класс, который представляет запись о действии над пользователем
    /// </summary>
    [Serializable]
    public class ActionsLogRecord:LogRecord
    {
        public ActionsLogRecord(string message, DateTime? dateTimeStart):base(message, dateTimeStart){ }
        public ActionsLogRecord(string currentUserName, int n, bool isCanceled, DateTime dateTimeStart):base(CreateMessageFromValues(currentUserName, n, isCanceled),dateTimeStart)
        {
        }

        // "Создать сообщение из значений"
        public static string CreateMessageFromValues(string currentUserName, int n, bool isCanceled)
        {
            return $@"Пользователь {currentUserName} генерировал {n} чисел; {(isCanceled?"Отменил операцию":"Успешно")}";
        }

    }
}