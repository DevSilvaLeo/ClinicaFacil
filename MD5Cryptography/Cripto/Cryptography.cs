using MD5Cryptography.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5Cryptography.Cripto
{
    public class Cryptography : IMD5Criptography
    {
        public string Ecrypt(string value)
        {
            var md5 = new MD5CryptoServiceProvider();

            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value));

            var result = string.Empty;
            foreach(var item in hash)
            {
                result += item.ToString("X2");
            }

            return result;
        }
    }
}
