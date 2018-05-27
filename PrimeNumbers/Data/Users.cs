using JetBrains.Annotations;
using MetroFramework_test_at_a_new_project.Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics.CodeAnalysis;

namespace MetroFramework_test_at_a_new_project.Data
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public static partial class Users
    {
        private static User currentUser;

        private static User defaultAdmin = new User("admin", "admin");

        static Users()
        {
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
            if (Users.FindUserByName(userName) is var user != default)
            {
                Users.currentUser = user;
            }
            else
            {
                throw new ArgumentException("User " + userName + " not found");
            }
        }

        /// <summary>
        /// Удаляет пользователя с указанным именем
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <returns>flag ContainsUser</returns>
        public static bool DeleteUser(string username)
        {
            int number;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = $@"delete from Users where username = '{username}'";
                        command.CommandType = CommandType.Text;
                        number = command.ExecuteNonQuery(); 
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            
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
        /// Замена одной записи пользователя на другую.
        /// </summary>
        /// <param name="oldUser">Запись для замены</param>
        /// <param name="newUser">Запись, которой заменить</param>
        /// <returns>flag Success</returns>
        public static bool Replace(User oldUser, User newUser)
        {
            int number;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = $@"update Users set Username = '{newUser.Name}' set Password = '{newUser.PassWord}' where Username = '{oldUser.Name}'";
                    command.CommandType = CommandType.Text;
                    number              = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }
            if (number > 1)
            {
                throw new Exception("В базе данных пользователей не уникальные значения имени.");
            }
            return number is 1;

        }


        /// <summary>
        /// Находит пользователя по имени
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <returns>User record if it found; null otherwise</returns>
        [CanBeNull]
        public static User FindUserByName([NotNull] string username)
        {
            var user = new User("","");
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                        $@"select * from Users where Username = '{username}'";
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
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            endFunction:
            return user;
        }

        /// <summary>
        /// Проверяет, есть ли в базе данных пользователь с указанным именем.
        /// </summary>
        /// <param name="userName">имя пользователя</param>
        /// <returns>flag Contains</returns>
        public static bool Contains(string userName)
        {   
            bool result = true;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
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
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            endFunction:
            return result;
        }

        /// <summary>
        /// Проверяет, есть ли в базе данных пользователь с указанным именем и паролем.
        /// </summary>
        /// <param name="userName">имя пользователя</param>
        /// <param name="password">пароль пользователя</param>
        /// <returns>flag Contains</returns>
        public static bool Contains(string userName, string password)
        {
            bool result = true;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
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
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            endFunction:
            return result;
        }

        /// <summary>
        /// Добавляет пользователя в базу данных.
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <param name="password">пароль пользователя</param>
        /// /// <param name="isAdmin">есть ли привелегия администратора</param>
        /// <returns>flag Successful</returns>
        public static bool Add([NotNull] string userName, [NotNull] string password, bool isAdmin = false)
        {
            if (Users.Contains(userName))
            {
                return false;
            }
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                        $@"Insert into Users (Username, Password, IsAdmin) values ('{userName}','{password.EncryptToBase64String()}', '{isAdmin}')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            if(isAdmin is false)
            {
                Log.Add($@"Зарегистрирован новый простой пользователь {userName}");
            }
            else
            {
                Log.Add($@"Зарегистрирован новый администратор {userName}");
            }

            return true;
        }

        /// <summary>
        /// изменяет флаг администратора для пользователя с указанным именем.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="isAdmin"></param>
        /// <returns>flag Successful</returns>
        public static bool SetAdminPriveledgeUser(string username, bool isAdmin = true)
        {
            int number =0;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                        $@"Update Users set IsAdmin = '{isAdmin}' 
                            where Username = '{username}'
                            ";
                        command.CommandType = CommandType.Text;
                        number              = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

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

        /// <summary>
        /// изменяет пароль учетной записи пользователя с указанным именем.
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <param name="newPassword">новый пароль(заменяет старый)</param>
        /// <returns>flag Successful</returns>
        public static bool SetPasswordUser([NotNull]string username, [NotNull] string password)
        {
            int number =0;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                        $@"Update Users set Password = '{password.EncryptToBase64String()}' where Username = '{username}'";
                    command.CommandType = CommandType.Text;
                    number = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

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

        /// <summary>
        ///     Проверяет, можно ли изменить имя и изменяет его, если так.
        /// </summary>
        /// <param name="oldUsername">имя пользователя</param>
        /// <param name="newUsername">желаемое имя пользователя</param>
        /// <returns>flag Successful</returns>
        public static bool SetNameUser(string oldUsername, string newUsername)
        {
            int number = 0;
            try{
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
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} изменил имя пользователя {oldUsername} на {newUsername}");
            }
            return number is 1;
            
        }

        /// <summary>
        /// изменяет пароль учетной записи пользователя с указанным именем.
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <param name="newPassword">желаемый пароль</param>
        /// <returns>flag Successful</returns>
        private static bool SetUserPassword(string username, string newPassword)
        {
            int number =0;
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText =
                            $@"Update Users set Password = '{newPassword}' 
                                where Username = '{username}'";
                        command.CommandType = CommandType.Text;
                        number = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            if(number is 1)
            {
                Log.Add($@"Пользователь {CurrentUserName} изменил пароль {username}");
            }
            return number is 1;
        }
        /// <summary>
        /// Получает список пользователей из соответствующей базы данных.
        /// </summary>
        /// <returns>список пользователей</returns>
        public static List<User> GetListUsers()
        {
            var users = new List<User>();
            try{
                using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(connection))
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
                }
            }
            catch (SQLiteException e)
            {

                var mboxresult = MessageBox.Show($@"Что-то не так с базой данных пользователей."+ 
                "Возможно, база данных удалена или повреждена. " +
                "Если продолжить работу с программой, возможно ее непредсказуемое поведение."+
                "Если вы не изменяли файлы в папке приложения, обратитесь к своему системному администратору."+
                $"{Environment.NewLine}" +
                $"Текст ошибки: " +
                Environment.NewLine +
                $"{e.Message}{Environment.NewLine}" +
                $"Выйти из приложения?","Ошибка",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(mboxresult is DialogResult.Yes)
                {
                    Application.Exit();
                }
                return default;
            }

            return users;
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

        /// <summary>
        /// Проверяет, есть ли у пользователя с указанным именем привелегия администратора.
        /// </summary>
        /// <param name="username">имя пользователя</param>
        /// <returns>flag Contains</returns>
        public static bool CheckAdminPriveledge(string username)
        {

            bool result = true;
            using(var connection = new SQLiteConnection(@"Data Source = Databases\Users.db3"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
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
            }


            endFunction:
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
                            records.Add(new LogRecord(reader.GetString(1), Convert.ToDateTime(reader.GetString(0)) ));
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

    }
}