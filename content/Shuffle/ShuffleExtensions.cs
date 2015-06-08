using System.Collections.Generic;

namespace Shuffle.Sources
{
    public static class ShuffleExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> elements, IShuffle shuffleAlgorithm)
        {
            var shuffledItems = shuffleAlgorithm.Shuffle(elements);
            return shuffledItems;
        }
    }
}