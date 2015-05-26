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

        //http://stackoverflow.com/questions/8501444/caesar-cipher-in-c-sharp?rq=1
        public static IEnumerable<char> MoveLetters(string letters, int shift)
        {
            return from letter in letters
                   let diffCase = Char.IsLower(letter) ? 0 : 32
                   let max = 'z' - diffCase
                   let min = 'a' - diffCase
                   let isAsciiLetter = letter >= min && letter <= max
                   let l = (char)(letter + shift % 26)
                   select isAsciiLetter
                       ? (char)(l > max ? l - 26 : l < min ? l + 26 : l)
                       : letter;
        }
    }
}
