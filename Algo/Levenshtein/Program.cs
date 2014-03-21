using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levenshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Levenshtein.FindDistance("hello", "world"));
            Console.ReadLine();
        }
    }
}
