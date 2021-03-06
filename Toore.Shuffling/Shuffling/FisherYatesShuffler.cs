﻿using System.Collections.Generic;
using System.Linq;

namespace Toore.Shuffling
{
    // http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
    //
    // To shuffle an array a of n elements (indices 0..n-1):
    //  for i from 0 to n − 1 do
    //       j ← random integer with i ≤ j < n
    //       exchange a[j] and a[i]

    public class FisherYatesShuffler : IShuffler
    {
        private readonly IRandomWrapper _random;

        public FisherYatesShuffler(IRandomWrapper random)
        {
            _random = random;
        }

        /// <summary>
        /// Shuffles a collection of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements">A collection of elements.</param>
        /// <returns>A shuffled list.</returns>
        public List<T> Shuffle<T>(IEnumerable<T> elements)
        {
            var a = elements.ToList();
            var n = a.Count;

            for (var i = 0; i < n - 1; i++)
            {
                var j = _random.Next(i, n);

                var temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }

            return a;
        }
    }
}