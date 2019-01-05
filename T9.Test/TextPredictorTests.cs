using System;
using System.Collections.Generic;
using Xunit;

namespace T9.Test
{
    public class TextPredictorTests
    {
        [Fact]
        public void RejectsNullInput()
        {
            var target = new TextPredictor();
            Assert.Throws<ArgumentNullException>(() => target.GetLetterCombinations(null));
        }

        [Fact]
        public void RejectsOutOfRangeInput()
        {
            var target = new TextPredictor();
            Assert.Throws<FormatException>(() => target.GetLetterCombinations("cat"));
        }

        [Theory]
        [InlineData("2", new[] { "a", "b", "c" })]
        [InlineData("3", new[] { "d", "e", "f" })]
        [InlineData("4", new[] { "g", "h", "i" })]
        [InlineData("5", new[] { "j", "k", "l" })]
        [InlineData("6", new[] { "m", "n", "o" })]
        [InlineData("7", new[] { "p", "q", "r", "s" })]
        [InlineData("8", new[] { "t", "u", "v" })]
        [InlineData("9", new[] { "w", "x", "y", "z" })]
        public void ReturnsSingleDigitCombinations(string input, IEnumerable<string> expected)
        {
            var target = new TextPredictor();

            var actual = target.GetLetterCombinations(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsExampleDoubleDigitCombinations()
        {
            var expected = new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            var target = new TextPredictor();

            var actual = target.GetLetterCombinations("23");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsBabyGotBack()
        {
            const string expected = "mixalot";

            var target = new TextPredictor();

            var actual = target.GetLetterCombinations("6492568");

            Assert.Contains(expected, actual);
        }
    }
}
