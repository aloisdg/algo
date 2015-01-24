using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            str = "js";
            for (int i = 0; i < 20; i++)
            {
                var e = CaesarCipher.Encrypt(str, i);
                var d = CaesarCipher.Decrypt(e, i);
                Console.WriteLine("{0:D4} {1} {2} {3}", i, str == d ? "ok" : "ko", e, d);
            }
            Console.ReadLine();
        }
    }
}
