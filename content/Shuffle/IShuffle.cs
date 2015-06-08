using System.Collections.Generic;

namespace Shuffle.Sources
{
    public interface IShuffle
    {
        IEnumerable<T> Shuffle<T>(IEnumerable<T> items);
    }
}