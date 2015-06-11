using System.Collections.Generic;

namespace Toore.Shuffling
{
    public static class ShuffleExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> elements, IShuffler shuffler)
        {
            var shuffledSet = shuffler.Shuffle(elements);
            return shuffledSet;
        }
    }
}