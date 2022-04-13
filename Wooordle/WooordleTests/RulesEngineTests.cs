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

        public class ThrowExceptionTests: RulesEngine
        {
            [Theory]
            [InlineData("Not5Letters")]
            [InlineData("TooManyLettersThanAccepted")]
            [InlineData("barber")]
            public void ThrowWordException_ThrowsWordTooLongException_GiveAStringGreaterThan5Length(string wordLongerThan5)
            {
                WordTooLongException ex = Assert.Throws<WordTooLongException>(() => ThrowWordException(wordLongerThan5));
                Assert.Equal("The word entered is too long", ex.Message);
            }

            [Theory]
            [InlineData("one")]
            [InlineData("four")]
            [InlineData("hi")]
            [InlineData("I")]
            public void ThrowWordException_ThrowsWordTooShortException_GivenAStringShorterThan5Length(string wordShorterThan5)
            {
                WordTooShortException ex = Assert.Throws<WordTooShortException>(() => ThrowWordException(wordShorterThan5));
                Assert.Equal("The word entered is too short", ex.Message);
            }

            [Theory]
            [InlineData("aaaa&")]
            [InlineData("aa^aa")]
            [InlineData("$aaaa")]
            [InlineData("aAaaa")]
            [InlineData("aaa8a")]
            public void ThrowWordException_ThrowsWordNotValidException_IfWordContainsInvalidCharacter(string invalidCharacter)
            {
                WordNotValidException ex = Assert.Throws<WordNotValidException>(() => ThrowWordException(invalidCharacter));
                Assert.Equal("The word entered is not valid", ex.Message);
            }
        }
            
        [Theory]
        [InlineData("Not5Letters")]
        [InlineData("TooManyLettersThanAccepted")]
        [InlineData("barber#")]
        public void ValidateWords_ReturnsFalse_WhenGuessWordIsTooLong(string wordLongerThan5)
        {
            Assert.False(_engine.ValidateWord(wordLongerThan5));
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
