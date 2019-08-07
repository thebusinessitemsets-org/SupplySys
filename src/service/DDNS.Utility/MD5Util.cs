using System;
using System.Security.Cryptography;
using System.Text;

namespace DDNS.Utility
{
    public class MD5Util
    {
        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string TextToMD5(string text)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
                string str = BitConverter.ToString(bytes).Replace("-", "");
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }
    }
}