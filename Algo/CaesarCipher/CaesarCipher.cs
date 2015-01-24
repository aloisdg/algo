using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        /*
         * http://en.wikipedia.org/wiki/Caesar_cipher
         */

        public static string Encrypt(string input, int code)
        {
            return RunCipher(input, code);
        }

        public static string Decrypt(string input, int code)
        {
            return RunCipher(input, -code);
        }

        private static string RunCipher(string letters, int shift)
        {
            return new String(MoveLetters(letters, shift).ToArray());
        }

        public static IEnumerable<char> MoveLetters(string letters, int shift)
        {
            return from letter in letters
                   let offset = Char.IsUpper(letter) ? 'A' : 'a'
                   select Char.IsLetter(letter) ? (char)(((letter + shift - offset) % 26) + offset) : letter;
        }
    }
}
