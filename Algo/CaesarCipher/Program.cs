using System;
using System.Collections.Generic;
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
            string str = "je t'aime";
            str = CaesarCipher.Encrypt(str, 6);
            Console.WriteLine("Encrypted: {0}", str);
            str = CaesarCipher.Decrypt(str, 6);
            Console.WriteLine("Decrypted: {0}", str);

            int okCounter = 0;
            for (int i = 0; i < 50; i++)
            {
                str = RandomUtil.GetRandomString(); // error ?
                var e = CaesarCipher.Encrypt(str, i);
                var d = CaesarCipher.Decrypt(e, i);
                //Thread.Sleep(200);
                Console.WriteLine("{0:D4} {1} {2} {3} {4}", i, e, d, str, str == d ? "ok" : "ko");
                if (str == d)
                    okCounter++;
            }
            Console.WriteLine("ok " + okCounter);
            Console.WriteLine("ko " + (50 - okCounter));
            Console.ReadLine();
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
