using System.Linq;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Toore.Shuffling.Tests
{
    public class FisherYatesShufflerTests
    {
        private readonly IRandomWrapper _randomWrapper;
        private readonly FisherYatesShuffler _sut;

        public FisherYatesShufflerTests()
        {
            _randomWrapper = Substitute.For<IRandomWrapper>();

            _sut = new FisherYatesShuffler(_randomWrapper);
        }

        [Fact]
        public void Shuffles_three_elements()
        {
            var elements = new object[] { "first", "second", "third" };
            SwapFirstWithThird();
            SwapSecondWithFirst();

            var orderedSequence = elements.Shuffle(_sut).ToList();

            orderedSequence.First().Should().Be("second");
            orderedSequence.ElementAt(1).Should().Be("third");
            orderedSequence.ElementAt(2).Should().Be("first");
        }

        private void SwapSecondWithFirst()
        {
            _randomWrapper.Next(1, 3).Returns(0);
        }

        private void SwapFirstWithThird()
        {
            _randomWrapper.Next(0, 3).Returns(2);
        }
    }
}