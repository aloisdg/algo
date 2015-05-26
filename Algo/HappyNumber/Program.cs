using System;

namespace HappyNumber
{
	class Program
	{
		static void Main()
		{
			for (var i = 0; i < 100; i++)
				if (i.IsHappy())
					Console.Write(i + " ");
			Console.ReadLine();
		}
	}
}
