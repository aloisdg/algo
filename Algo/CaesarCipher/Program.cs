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

            str = "je t'aime";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(str == CaesarCipher.Decrypt(CaesarCipher.Encrypt(str, i), i)
                    ? "{0} ok" : "{0} ko", i);
            }
            Console.ReadLine();
        }
    }
}
