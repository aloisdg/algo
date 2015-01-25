﻿using System;
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
            //foreach (var letter in letters)
            //{
            //    char offset = Char.IsUpper(letter) ? 'A' : 'a';
            //    int i = letter + shift - offset;
            //    int m = i%26;
            //    int o = m + offset;
            //    char c = (char) o;
            //    char l = Char.IsLetter(letter) ? c : letter;
            //    yield return l;
            //}

            // check case by hand
            return from letter in letters
                   let l = (char)(letter + shift)
                   let diffCase = Char.IsLower(letter) ? 0 : 32
                   select Char.IsLetter(letter)
                       ? (char)(l > 'z' - diffCase ? l - 26 : l < 'a' - diffCase ? l + 26 : l)
                       : letter;
        }
    }
}
