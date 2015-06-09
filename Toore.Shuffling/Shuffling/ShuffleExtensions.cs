using System.Collections.Generic;

namespace Toore.Shuffling
{
    public static class ShuffleExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> elements, IShuffle shuffle)
        {
            var shuffledItems = shuffle.Shuffle(elements);
            return shuffledItems;
        }
    }
}