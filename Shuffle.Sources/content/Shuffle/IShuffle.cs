using System.Collections.Generic;

namespace Shuffle.Sources.content.Shuffle
{
    public interface IShuffle
    {
        IEnumerable<T> Shuffle<T>(IEnumerable<T> elements);
    }
}