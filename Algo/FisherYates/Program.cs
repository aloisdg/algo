using System;
using System.Collections.Generic;

namespace FisherYates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>( ) { 0, 1, 2, 3 };
            FisherYates.Shuffle<int>(nums);

            foreach (var item in nums)
                Console.WriteLine(String.Format("{0}", item));

            List<string> list = new List<string>() { "fisher", "yates", "havel", "hakimi" };
            FisherYates.Shuffle<string>(list);

            foreach (var item in list)
                Console.WriteLine(String.Format("{0}", item));
            Console.ReadLine();
        }
    }
}
