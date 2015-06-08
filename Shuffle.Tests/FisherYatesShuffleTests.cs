using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NSubstitute;
using Shuffle.Sources.content.Shuffle;
using Xunit;

namespace Shuffle.Tests
{
    public class FisherYatesShuffleTests
    {
        private readonly IRandomWrapper _randomWrapper;
        private readonly FisherYatesShuffle _fisherYates;

        public FisherYatesShuffleTests()
        {
            _randomWrapper = Substitute.For<IRandomWrapper>();

            _fisherYates = new FisherYatesShuffle(_randomWrapper);
        }

        [Fact]
        public void Shuffles_three_elements()
        {
            IEnumerable<object> elements = new object[] { "first", "second", "third" };
            _randomWrapper.Next(0, 3).Returns(2); // swap first with third  3 2 1
            _randomWrapper.Next(1, 3).Returns(0); // swap second with first 2 3 1

            var orderedSequence = elements.Shuffle(_fisherYates).ToList();

            orderedSequence.First().Should().Be("second");
            orderedSequence.ElementAt(1).Should().Be("third");
            orderedSequence.ElementAt(2).Should().Be("first");
        }
    }
}