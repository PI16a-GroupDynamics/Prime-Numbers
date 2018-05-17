using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MetroFramework_test_at_a_new_project.Encryption
{
    /// <summary>
    /// Класс со стандартной реализацией хэширования строки.
    /// </summary>
    class HashEncryptor
    {
        public HashAlgorithm Algorithm = HashAlgorithm.Create("SHA512"); // реализация паттерна Стратегия
        
        public byte[] Encrypt(string dataToHash)
        {
            var bytesToHash = Encoding.UTF8.GetBytes(dataToHash);
            return Encrypt(bytesToHash);
        }

        public byte[] Encrypt(byte[] bytesToHash) => Algorithm.ComputeHash(bytesToHash);
    }
}
