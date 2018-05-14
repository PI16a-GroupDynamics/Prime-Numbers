using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project.Data
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public static class Users
    {
        

        private static List<User> users = new List<User>();

        // А что, если использовать этот список просто всегда? Делать запись на диск только при закрытии главной формы... Или по особой прихоти админа... Хммм...
        private static User currentUser;

        private static User defaultAdmin = new User("admin", "admin");

        static Users()
        {
            Users.DefaultFilePath = @"Records\users.bin";
            Users.users.Add(Users.DefaultAdmin);
            
        }

        [CanBeNull]
        public static User DefaultAdmin
        {
            get => Users.defaultAdmin;
            set
            {
                Users.Replace(Users.defaultAdmin, value);
                Users.defaultAdmin = value;
            }
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

        public static bool DeleteUser(string userName) => Users.users.Remove(Users.FindUserByName(userName));

        /// <summary>
        ///     Загружает данные из бинарного файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns />
        public static bool LoadFromFile([NotNull] string filePath)
        {
            var path = filePath;
            var bf   = new BinaryFormatter();
            if (! Directory.Exists(Path.GetDirectoryName(path)) ||
                ! File.Exists(path))
            {
                Users.users = new List<User>
                    {Users.DefaultAdmin};
                return false;
            }

            using (var fstream = File.OpenRead(path))
            {
                Users.users = bf.Deserialize(fstream) as List<User>;
            }

            return true;
        }

        /// <summary>
        ///     Записывает в бинарный файл данные
        /// </summary>
        /// <param name="filePath"></param>
        public static void SaveToFile(string filePath)
        {
            Users.CheckPathOrCreate(filePath);

            var bf = new BinaryFormatter();
            using (var fstream = File.OpenWrite(filePath))
            {
                bf.Serialize(fstream, Users.users);
            }
        }

        /// <summary>
        ///     Замена записи пользователя. Используется метод RemoveAll.
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        /// <returns />
        public static bool Replace(User oldUser, User newUser)
        {
            var success = Users.users.RemoveAll(user => user.Name == oldUser.Name);
            if (success == 0)
            {
                return false;
            }

            Users.users.Add(newUser);

            return true;
        }

        public static User FindUserByName([NotNull] string name) =>
            Users.users.Find(user => user.Name == name);

        /// <summary>
        ///     Загружает данные из бинарного файла
        /// </summary>
        public static bool LoadFromFile() => Users.LoadFromFile(Users.DefaultFilePath);

        /// <summary>
        ///     Записывает в бинарный файл данные
        /// </summary>
        public static void SaveToFile()
        {
            Users.SaveToFile(Users.DefaultFilePath);
        }

        public static bool Contains(string userName) => Users.users.Exists(x => x.Name == userName);

        public static bool Contains(string userName, string password) =>
            Users.users.Exists(x => x.Name == userName && x.PassWord == password);

        public static bool Add(string userName, string password)
        {
            if (Users.Contains(userName))
            {
                return false;
            }

            Users.users.Add(new User(userName, password));
            return true;
        }

        public static void CheckPathOrCreate(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (! Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static void SetPasswordUser(string username, [NotNull] string password)
        {
            Users.SetPasswordUser(Users.FindUserByName(username), password);
        }

        /// <summary>
        ///     Проверяет, можно ли изменить имя и изменяет его, если так.
        /// </summary>
        /// <param name="oldUsername"></param>
        /// <param name="newUsername"></param>
        /// <returns>flag Successful</returns>
        public static bool SetNameUser(string oldUsername, string newUsername)
        {
            if (Users.Contains(newUsername))
            {
                return false;
            }

            if (Users.FindUserByName(oldUsername) is var user == default)
            {
                return false;
            }

            user.Name = newUsername;
            return true;
        }

        private static void SetPasswordUser(User user, string password)
        {
            user.PassWord = password;
        }

        public static List<User> GetListUsers() => Users.users;

        /// <summary>
        ///     Единица списка пользователей
        /// </summary>
        [Serializable]
        public sealed class User
        {
            public User(string name, string passWord)
            {
                Name     = name;
                PassWord = passWord;
            }

            [NotNull]
            public string Name { get; set; }

            public string PassWord { get; set; }

            public bool Equals(User user) => Name == user.Name && PassWord == user.PassWord;
        }
    }
}