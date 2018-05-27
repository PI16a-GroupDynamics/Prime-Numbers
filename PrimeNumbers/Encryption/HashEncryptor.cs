using System.Security.Cryptography;
using System.Text;

namespace MetroFramework_test_at_a_new_project.Encryption
{
    /// <summary>
    /// Класс со стандартной реализацией хэширования строки.
    /// </summary>
    class HashEncryptor
    {
        public HashAlgorithm Algorithm = HashAlgorithm.Create("SHA512"); // реализация паттерна Стратегия
        
        /// <summary>
        /// Шифрует строку в массив байтов
        /// </summary>
        /// <param name="dataToHash"></param>
        /// <returns></returns>
        public byte[] Encrypt(string dataToHash)
        {
            var bytesToHash = Encoding.UTF8.GetBytes(dataToHash);
            return Encrypt(bytesToHash);
        }

        /// <summary>
        /// Возвращает массив байтов в зашифрованном виде
        /// </summary>
        /// <param name="bytesToHash"></param>
        /// <returns></returns>
        public byte[] Encrypt(byte[] bytesToHash) => Algorithm.ComputeHash(bytesToHash);
    }
}
