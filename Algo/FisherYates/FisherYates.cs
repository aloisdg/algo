using System;
using System.Collections.Generic;

namespace FisherYates
{
    public static class FisherYates
    {
        /*
        ** http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        */

        static readonly Random Rand = new Random();

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list)
	{
		var rand = Rand;
		var enumerable = list as T[] ?? list.ToArray();
		for (var i = enumerable.Length; i > 1; i--)
		{
			// First step : Pick random element to swap.
			var j = rand.Next(i);
			
			// Second step : Swap.
			var tmp = enumerable[j];
			enumerable[j] = enumerable[i - 1];
			enumerable[i - 1] = tmp;
		}
		return enumerable;
	}
    }
}
