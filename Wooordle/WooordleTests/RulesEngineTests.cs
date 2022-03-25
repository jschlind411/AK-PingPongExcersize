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

        [Theory]
        [InlineData("rocks","dealt")]
        [InlineData("water","books")]
        public void CompareWords_GivenWord_WithNoMatchingCharacters_WillReturnFormattedString_WithAllHyphens(string guess, string actual)
        {
            string result = _engine.CompareWords(actual,guess);

            Assert.Equal("-----", result);
        }

        [Theory]
        [InlineData("acccc", "babbb", "?----")]
        [InlineData("ccacc", "babbb", "--?--")]
        [InlineData("cccaa", "aabbb", "---??")]
        [InlineData("abcde", "cedba", "?????")]
        public void CompareWords_GivenWord_WithMatchingCharactersInWrongPlacement_WillReturnFormattedString_WithQuestionMarks(string guess, string actual, string expected)
        {
            string result = _engine.CompareWords(actual, guess);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("dears", "dzzzz", "d----")]
        [InlineData("zzzzt", "ddddt", "----t")]
        [InlineData("zozzt", "doddt", "-o--t")]
        [InlineData("zzzzz", "zzzzz", "zzzzz")]
        public void CompareWords_GivenWord_WithMatchingCharactersWithCorrectPlacement_WillReturnFormattedString_WithGuessedLetter(string guess, string actual, string expected)
        {
            string result = _engine.CompareWords(actual,guess);

            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData("plane", "cause", "--?-e")]
        [InlineData("crane", "carse", "c??-e")]
        public void CompareWords_GivenWord_WithAllUseCases_WillReturnFormattedStringWith_Letters_QuestionMarks_Dashes(string guess, string actual, string expectedResult)
        {
            string result = _engine.CompareWords(actual, guess);

            Assert.Equal(expectedResult, result);
        }
    }
}
