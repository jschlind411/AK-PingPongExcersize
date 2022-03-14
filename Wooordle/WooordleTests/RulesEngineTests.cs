using Models;
using Xunit;
using static Models.RulesEngine;

namespace WooordleTests
{
    public class RulesEngineTests
    {
        public RulesEngine _engine;

        public RulesEngineTests()
        {
            _engine = new RulesEngine();
        }

        [Fact]
        public void CanCreateRulesEngine_UsingDefaultConstructor()
        {
            Assert.NotNull(_engine);
        }

        [Theory]
        [InlineData("Not5Letters")]
        [InlineData("TooManyLettersThanAccepted")]
        [InlineData("barber")]
        public void ValidateWords_ThrowsWordTooLongException_GivenAStringGreaterThan5Letters(string wordLongerThan5)
        {
            Assert.Throws<WordTooLongException>(() => _engine.ValidateWord(wordLongerThan5));
        }

        [Theory]
        [InlineData("one")]
        [InlineData("four")]
        [InlineData("hi")]
        [InlineData("I")]
        public void ValidateWord_ThrowsWordTooShotException_GivenAStringShorterThan5Letters(string wordShorterThan5)
        {
            Assert.Throws<WordTooShortException>(() => _engine.ValidateWord(wordShorterThan5));
        }

        [Theory]
        [InlineData("&")]
        [InlineData("^")]
        [InlineData("$")]
        [InlineData("a")]
        [InlineData("8")]
        public void ValidateWord_ThrowsWordNotValidException_IfWordContainsInvalidCharacter(string invalidCharacter)
        {
            string invalidWord = "four" + invalidCharacter;
            Assert.Throws<WordNotValidException>(() => _engine.ValidateWord(invalidWord));
        }

        [Fact]
        public void CompareWords_ReturnsString_WhenPassedActualWordAndGuessWord()
        {
            string result = _engine.CompareWords("", "");

            Assert.IsType<string>(result);
        }

        [Fact]
        public void CompareWords_ReplacesCharacter_WithHyphen_ThatDoNotMatch_ActualWord()
        {
            string result = _engine.CompareWords("word", "deal");

            Assert.Equal("-----", result);
        }
    }
}
