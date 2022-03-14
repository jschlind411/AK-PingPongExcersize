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
        public void CompareWords_ThrowsWordTooLongException_GivenAStringGreaterThan5Letters(string wordLongerThan5)
        {
            Assert.Throws<WordTooLongException>(() => _engine.ValidateWord(wordLongerThan5));
        }

        [Theory]
        [InlineData("one")]
        [InlineData("four")]
        [InlineData("hi")]
        [InlineData("I")]
        public void GuessWord_ThrowsWordTooShotException_GivenAStringShorterThan5Letters(string wordShorterThan5)
        {
            Assert.Throws<WordTooShortException>(() => _engine.ValidateWord(wordShorterThan5));
        }

        [Theory]
        [InlineData("&")]
        [InlineData("^")]
        [InlineData("$")]
        [InlineData("a")]
        [InlineData("8")]
        public void GuessWord_ThrowsWordNotValidException_IfWordContainsInvalidCharacter(string invalidCharacter)
        {
            string invalidWord = "four" + invalidCharacter;
            Assert.Throws<WordNotValidException>(() => _engine.ValidateWord(invalidWord));
        }

    }
}
