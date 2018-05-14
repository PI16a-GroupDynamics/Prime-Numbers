using JetBrains.Annotations;
using MetroFramework_test_at_a_new_project.Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics.CodeAnalysis;

namespace MetroFramework_test_at_a_new_project.Data
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public static class Users
    {
        private static SQLiteConnection dbConnection;

        private static User currentUser;

        private static User defaultAdmin = new User("admin", "admin");

        static Users()
        {
            SetConnections();
        }

        private static void SetConnections()
        {
            string baseName = @"Databases\Users.db3";

            SQLiteFactory factory = DbProviderFactories.GetFactory("System.Data.SQLite") as SQLiteFactory;

            dbConnection = new SQLiteConnection(@"Data Source = " + baseName);
        }

        [CanBeNull]
        public static User DefaultAdmin
        {
            get => Users.defaultAdmin;
        }

        public static string DefaultFilePath { get; set; }

        public static string CurrentUserName => Users.CurrentUser.Name;

        [CanBeNull]
        public static User CurrentUser => Users.currentUser;

        public static void SetCurrentUser([NotNull] string userName)
        {
            //var user = Users.FindUserByName(userName);
            if (Users.FindUserByName(userName) is var user != default)
            {
                Users.currentUser = user;
            }
            else
            {
                throw new ArgumentException("User " + userName + " not found");
            }
        }

        public static bool DeleteUser(string username)
        {
            ResetConnections();
            Users.dbConnection.Open();
            int number;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText = $@"delete from Users where username = '{username}'";
                command.CommandType = CommandType.Text;
                number = command.ExecuteNonQuery();  
            }

            Users.dbConnection.Close();
            if (number > 1)
            {
                throw new Exception("В базе данных пользователей не уникальные значения имени.");
            }

            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} удалил пользователя {username}");
            }

            return number is 1;
            
        } 

        /// <summary>
        ///     Замена записи пользователя. Используется метод RemoveAll.
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        /// <returns />
        public static bool Replace(User oldUser, User newUser)
        {
            ResetConnections();
            Users.dbConnection.Open();
            int number;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText = $@"update Users set Username = '{newUser.Name}' set Password = '{newUser.PassWord}' where Username = '{oldUser.Name}'";
                command.CommandType = CommandType.Text;
                number              = command.ExecuteNonQuery();
            }

            Users.dbConnection.Close();
            if (number > 1)
            {
                throw new Exception("В базе данных пользователей не уникальные значения имени.");
            }
            return number is 1;

        }



        [CanBeNull]
        public static User FindUserByName([NotNull] string name)
        {
            ResetConnections();
            Users.dbConnection.Open();
            var user = new User("","");
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"select * from Users where Username = '{name}'";
                command.CommandType = CommandType.Text;
                var reader = command.ExecuteReader();

                // Если user не найден
                if (! reader.HasRows)
                {
                    user = null;
                    goto endFunction;
                }

                reader.Read();
                user.Name = reader.GetString(0);
                user.PassWord = reader.GetString(1);
            }

            endFunction:
            Users.dbConnection.Close();
            return user;
        }

        public static bool Contains(string userName)
        {
            ResetConnections();
            Users.dbConnection.Open();
            
            bool result = true;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"select * from Users where Username = '{userName}'";
                command.CommandType = CommandType.Text;
                var reader = command.ExecuteReader();

                // Если user не найден
                if (! reader.HasRows)
                {
                    result = false;
                    goto endFunction;
                }

            }

            endFunction:
            Users.dbConnection.Close();
            return result;
        }

        public static bool Contains(string userName, string password)
        {
            ResetConnections();
            Users.dbConnection.Open();
            bool result = true;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"select * from Users where Username = '{userName}' and Password = '{password.EncryptToBase64String()}'";
                command.CommandType = CommandType.Text;
                var reader = command.ExecuteReader();

                // Если user не найден
                if (! reader.HasRows)
                {
                    result = false;
                    goto endFunction;
                }

            }

            endFunction:
            Users.dbConnection.Close();
            return result;
        }

        public static bool Add([NotNull] string userName, [NotNull] string password, bool isAdmin = false)
        {
            if (Users.Contains(userName))
            {
                return false;
            }
            ResetConnections();
            Users.dbConnection.Open();
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"Insert into Users (Username, Password, IsAdmin) values ('{userName}','{password.EncryptToBase64String()}', '{isAdmin}')";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }

            if(isAdmin is false)
            {
                Log.Add($@"Зарегистрирован новый простой пользователь {userName}");
            }
            else
            {
                Log.Add($@"Зарегистрирован новый администратор {userName}");
            }
            
            

            Users.dbConnection.Close();
            return true;
        }

        public static bool SetAdminPriveledgeUser(string username, bool isAdmin = true)
        {
            ResetConnections();
            Users.dbConnection.Open();
            int number;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"Update Users set IsAdmin = '{isAdmin}' 
                        where Username = '{username}'
                        ";
                command.CommandType = CommandType.Text;
                number              = command.ExecuteNonQuery();
            }

            Users.dbConnection.Close();
            if (number > 1)
            {
                throw new
                    Exception("База данных пользователей повреждена. Имеется неуникальное имя пользователя (" +
                              username                                                                        +
                              ")");
            }

            if(number is 1)
            {
                if(isAdmin)
                {
                    Log.Add($@"Пользователь {CurrentUserName} сделал администратором {username}");
                }
                else
                {
                    Log.Add($@"Пользователь {CurrentUserName} сделал обычным пользователем {username}");
                }
            }

            return number is 1;
        }

        public static bool SetPasswordUser([NotNull]string username, [NotNull] string password)
        {
            ResetConnections();
            Users.dbConnection.Open();
            int number;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"Update Users set Password = '{password.EncryptToBase64String()}' where Username = '{username}'";
                command.CommandType = CommandType.Text;
                number = command.ExecuteNonQuery();
            }

            Users.dbConnection.Close();
            if (number > 1)
            {
                throw new Exception("База данных пользователей повреждена. Имеется неуникальное имя пользователя ("+username+")");
            }
            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} изменил пароль {username}");
            }
            return number is 1;
        }

        public static void ResetConnections()
        {
            DisposeConnections();
            SetConnections();
        }

        /// <summary>
        ///     Проверяет, можно ли изменить имя и изменяет его, если так.
        /// </summary>
        /// <param name="oldUsername"></param>
        /// <param name="newUsername"></param>
        /// <returns>flag Successful</returns>
        public static bool SetNameUser(string oldUsername, string newUsername)
        {

            ResetConnections();
            DisposeConnections();
            int number;
            using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        $@"Update Users set Username = '{newUsername}' 
                            where Username = '{oldUsername
                            }'";
                    command.CommandType = CommandType.Text;
                    number              = command.ExecuteNonQuery();
                }
            }

            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} изменил имя пользователя {oldUsername} на {newUsername}");
            }
            return number is 1;
            
        }

        private static bool SetUserPassword(string username, string newPassword)
        {
            ResetConnections();
            Users.dbConnection.Open();
            int number;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"Update Users set Password = '{newPassword}' 
                        where Username = '{username}'";
                command.CommandType = CommandType.Text;
                number = command.ExecuteNonQuery();
            }

            Users.dbConnection.Close();
            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} изменил пароль {username}");
            }
            return number is 1;
        }

        public static List<User> GetListUsers()
        {
            var users = new List<User>();
            ResetConnections();
            Users.dbConnection.Open();
            
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
                command.CommandText =
                    $@"select * from Users";
                command.CommandType = CommandType.Text;
                var reader             = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new User(reader.GetString(0), reader.GetString(1), Convert.ToBoolean(reader.GetString(2)));
                    users.Add(user);
                }
            }

            Users.dbConnection.Close();
            return users;
        }

        public static void DisposeConnections()
        {
            Users.dbConnection.Dispose();
        }

        /// <summary>
        ///     Единица списка пользователей
        /// </summary>
        [Serializable]
        public sealed class User
        {
            public User(string name, string passWord, bool isAdmin = false)
            {
                Name     = name;
                PassWord = passWord;
                IsAdmin = isAdmin;
            }

            [NotNull]
            public string Name { get; set; }

            public string PassWord { get; set; }

            public bool IsAdmin { get; set; }

            public bool Equals(User user) => Name == user.Name && PassWord == user.PassWord && IsAdmin == user.IsAdmin;
        }

        public static bool CheckAdminPriveledge(string username)
        {
            ResetConnections();
            Users.dbConnection.Open();

            bool result = true;
            using (var command = new SQLiteCommand(Users.dbConnection))
            {
        //WTF is here??? no, no and NO! Why?
                command.CommandText =
                    $@"select * from Users where Username = '{username}' and IsAdmin = 'True'";
                command.CommandType = CommandType.Text;
                var reader = command.ExecuteReader();

                // Если user не найден
                if (! reader.HasRows)
                {
                    result = false;
                    goto endFunction;
                }

            }


            endFunction:
            Users.dbConnection.Close();
            return result;
        }

        public static class Log
        {
            public static void Add(string message, DateTime? dateTime = null)
            {
                if (!dateTime.HasValue)
                {
                    dateTime = DateTime.Now;
                }
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"Insert into UsersLog (Message, DateTime)
                                values ('{message}','{dateTime}');";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }

            internal static List<LogRecord> GetLogRecords()
            {
                var records = new List<LogRecord>();    

                using(var connection = new SQLiteConnection($@"Data Source = Databases\Log.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"select * from UsersLog";
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            records.Add(new LogRecord(reader.GetString(0), Convert.ToDateTime(reader.GetString(1)) ));
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
                            @"delete from UsersLog where Message like '%'";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public class LogRecord
        {
            public string Message{get;set;}
            public DateTime DateTime{get;set;}
            public LogRecord(string message, DateTime dateTime)
            {
                Message = message;
                DateTime = dateTime;
            }
        }

    }
}