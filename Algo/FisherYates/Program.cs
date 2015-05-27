using System;
using System.Collections.Generic;
using System.Linq;

namespace FisherYates
{
	class Program
	{
		static void Main()
		{
			var nums = Enumerable.Range(0, 10);
			var numsShuffled = nums.Shuffle<int>();

			foreach (var item in numsShuffled)
				Console.Write("{0} ", item);
			Console.WriteLine();

			var list = new List<string> { "fisher", "yates", "havel", "hakimi" };
			var listShuffled = list.Shuffle<string>();
			foreach (var item in listShuffled)
				Console.Write("{0} ", item);
			Console.ReadLine();
		}
	}
}
