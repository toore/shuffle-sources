using System;

namespace Toore.Shuffling
{
    public interface IRandomWrapper
    {
        int Next(int minValueInclusive, int maxValueExclusive);
    }

    public class RandomWrapper : IRandomWrapper 
    {
        private readonly Random _random = new Random();

        public int Next(int minValueInclusive, int maxValueExclusive)
        {
            return _random.Next(minValueInclusive, maxValueExclusive);
        }
    }
}