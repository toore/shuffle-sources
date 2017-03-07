using System.Collections.Generic;

namespace Toore.Shuffling
{
    public static class ShuffleExtensions
    {
        public static List<T> Shuffle<T>(this IEnumerable<T> elements, IShuffler shuffler)
        {
            return shuffler.Shuffle(elements);
        }
    }
}