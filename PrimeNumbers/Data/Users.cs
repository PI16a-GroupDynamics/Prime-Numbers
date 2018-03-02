using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MetroFramework_test_at_a_new_project.Data
{
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    public static class Users
    {
        public static User Admin = new User("admin", "ThisAdminIsCool");
        public static string DefaultFilePath { get; set; }
        public static string CurrentUserName => Users.CurrentUser.Name;

        public static User CurrentUser
        {
            get => Users.currentUser;
            set
            {
                if (Users.currentUser == null)
                {
                    Users.currentUser = value;
                    return;
                }
                if (!Replace(Users.currentUser, value))
                {
                    MessageBox.Show("Хьюстон, у нас проблемы. Он не находит.");
                }
                Users.currentUser = value;
                
            }
        }

        private static List <User> users = new List <User>();
        private static User currentUser;


        static Users()
        {
            Users.DefaultFilePath = "users.bin";
            Users.users.Add(new User("admin", "ThisAdminIsCool"));
        }

        /// <summary>
        /// Загружает данные из бинарного файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool LoadFromFile(string filePath)
        {
            string path = filePath;
            var bf = new BinaryFormatter();
            if (!File.Exists(path))
            {
                Users.users = new List <User>()
                {
                    [0] = Users.Admin
                };
                return false;
            }

            using(var fstream = File.OpenRead(path))
            {
                Users.users = bf.Deserialize(fstream) as List <User>;
            }

            return true;
        }

        /// <summary>
        /// Записывает в бинарный файл данные
        /// </summary>
        /// <param name="filePath"></param>
        public static void SaveToFile(string filePath)
        {
            string path = filePath;
            var bf = new BinaryFormatter();
            using(var fstream = File.OpenWrite(path))
            {
                bf.Serialize(fstream, Users.users);
            }
        }
        /// <summary>
        /// Замена записи пользователя. Используется метод RemoveAll.
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static bool Replace(User oldUser, User newUser)
        {
            int success = Users.users.RemoveAll(user => user.Name==oldUser.Name && user.PassWord==oldUser.PassWord);
            if (success == 0)
            {
                return false;
            }
            Users.users.Add(newUser);

            return true;
        }

        public static User FindUserByName(string name) => Users.users.Find(user => user.Name == name);

        /// <summary>
        /// Загружает данные из бинарного файла
        /// </summary>
        public static bool LoadFromFile()
        {
            return Users.LoadFromFile(Users.DefaultFilePath);
        }

        /// <summary>
        /// Записывает в бинарный файл данные
        /// </summary>
        public static void SaveToFile()
        {
            Users.SaveToFile(Users.DefaultFilePath);
        }

        public static bool Contains(string userName) => Users.users.Exists(x => x.Name == userName);

        public static bool Contains
            (string userName, string password) =>
            Users.users.Exists(x => x.Name == userName && x.PassWord == password);

        public static bool Add(string userName, string password)
        {
            if (Users.Contains(userName)) return false;
            Users.users.Add(new User(userName, password));
            return true;
        }

        [Serializable]
        public class User
        {
            public User(string name, string passWord)
            {
                Name     = name;
                PassWord = passWord;
            }

            public string Name { get; }
            public string PassWord { get; set; }
        }
    }
}