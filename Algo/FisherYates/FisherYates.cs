using System;
using System.Collections.Generic;

namespace FisherYates
{
    public static class FisherYates
    {
        /*
        ** http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        */

        static Random _rand = new Random();

        public static void Shuffle<T>(IList<T> list)
        {
            var rand = _rand;
            for (int i = list.Count; i > 1; i--)
            {
                // First step : Pick random element to swap.
                int j = rand.Next(i);

                // Second step : Swap.
                T tmp = list[j];
                list[j] = list[i - 1];
                list[i - 1] = tmp;
            }
        }
    }
}
