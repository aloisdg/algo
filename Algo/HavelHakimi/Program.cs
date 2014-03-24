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
            Console.WriteLine(HavelHakimi.isGraph(new List<int>() { 1, 1 }));
            Console.WriteLine(HavelHakimi.isGraph(new List<int>() { 2, 1 }));
            Console.ReadLine();
        }
    }
}
