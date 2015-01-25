using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iter = 42;
            var okCounter = 0;
            for (var i = 0; i < iter; i++)
            {
                var str = RandomUtil.GetRandomString();
                var e = CaesarCipher.Encrypt(str, i);
                var d = CaesarCipher.Decrypt(e, i);
                Debug.WriteLine("{0:D4} {1} {2} {3} {4}", i, e, d, str, str == d ? "ok" : "ko");
                if (str == d)
                    okCounter++;
            }
            Debug.WriteLine("ok " + okCounter);
            Debug.WriteLine("ko " + (iter - okCounter));
        }
    }

    /// <summary>
    /// Random string generators.
    /// </summary>
    static class RandomUtil
    {
        /// <summary>
        /// Get random string of 11 characters.
        /// </summary>
        /// <returns>Random string.</returns>
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }
    }
}
