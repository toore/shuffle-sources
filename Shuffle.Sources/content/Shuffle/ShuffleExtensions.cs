using System.Collections.Generic;

namespace Shuffle.Sources.content.Shuffle
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