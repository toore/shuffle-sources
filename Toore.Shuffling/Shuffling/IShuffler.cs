using System.Collections.Generic;

namespace Toore.Shuffling
{
    public interface IShuffler
    {
        IEnumerable<T> Shuffle<T>(IEnumerable<T> elements);
    }
}