using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavelHakimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Why this one ? well http://jacquerie.github.io/hh/ appears on HN"
            Console.WriteLine(HavelHakimi.isGraphical(new List<int>() { 1, 1 }));
            Console.WriteLine(HavelHakimi.isGraphical(new List<int>() { 4, 3, 3, 3, 1 }));
            Console.WriteLine(HavelHakimi.isGraphical(new List<int>() { 7, 5, 5, 4, 4, 4, 4, 3 }));
            Console.WriteLine(HavelHakimi.isGraphical(new List<int>() { 2, 1 }));
            Console.ReadLine();
        }
    }
}
