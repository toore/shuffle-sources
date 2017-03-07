using System.Collections.Generic;

namespace Toore.Shuffling
{
    public interface IShuffler
    {
        List<T> Shuffle<T>(IEnumerable<T> elements);
    }
}