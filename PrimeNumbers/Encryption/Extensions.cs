using System;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project.Encryption
{
    public static class Extensions
    {
        static Extensions()
        {
        }

        /// <summary>
        /// Шифрует строку
        /// </summary>
        /// <param name="s">Строка для шифрования</param>
        /// <returns>зашифрованная строка в виде массива байтов</returns>
        [NotNull]
        public static byte[] Encrypt([NotNull] this string s)
        {
            var encryptor = new HashEncryptor();
            return encryptor.Encrypt(s);
        }

        /// <summary>
        /// Шифрует строку
        /// </summary>
        /// <param name="s">Строка для шифрования</param>
        /// <returns>зашифрованная строка</returns>
        public static string EncryptToBase64String([NotNull] this string s)
        {
            return s.Encrypt().ToBase64String();
        }

        public static string ToBase64String(this byte[] arrayBytes) => Convert.ToBase64String(arrayBytes);
        
    }

    public delegate byte[] StringEncryptor([NotNull] string s);

    public delegate byte[] StringDecryptor([NotNull] string s);
}