using System.Collections.Generic;

namespace HappyNumber
{
	// http://en.wikipedia.org/wiki/Happy_number

	public static class HappyNumber
	{
		public static bool IsHappy(this int n)
		{
			var cache = new HashSet<int>();
			while (n != 1 && cache.Add(n))
			{
				var sum = 0;
				while (n != 0)
				{
					var digit = n % 10;
					sum += digit * digit;
					n /= 10;
				}
				n = sum;
			}
			return n == 1;
		}
	}
}
