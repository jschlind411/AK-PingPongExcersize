using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Models.Words;

namespace WooordleTests
{
    public class WordsTests
    {
        public Words words;

        Mock<IRulesEngine> _engine;

        public WordsTests()
        {
            _engine = new Mock<IRulesEngine>();
            words = new Words(_engine.Object);
        }

        [Fact]
        public void Words_CanBeCreated_UsingConstructor_ThatReceivesRulesEngine()
        {
            Assert.NotNull(words);
        }

        public class BaseConstructorTests: Words
        {
            public BaseConstructorTests() : base()
            {

            }

            [Fact]
            public void WordList_ExistsOnCreation_WithListCreated()
            {
                Assert.IsType<List<string>>(WordList);
            }

            [Fact]
            public void CurrentWord_ExistsOnCreation_WithAWord_FromWordsList()
            {
                Assert.IsType<string>(CurrentWord);
                Assert.NotEqual(string.Empty, CurrentWord);
                Assert.Contains(CurrentWord, WordList);
            }

            [Fact]
            public void UsedWords_ExistsOnCreation_WithNoWordsInIt()
            {
                Assert.IsType<List<string>>(UsedWords);
                Assert.Empty(UsedWords);
            }

            [Fact]
            public void RulesEngine_ExistsOnCreation()
            {
                Assert.IsType<RulesEngine>(_engine);
                Assert.NotNull(_engine);
            }
        }

        public class OverloadedConstructorTests : Words
        {
            public static RulesEngine Rules { get; set; } = new RulesEngine();

            public OverloadedConstructorTests() : base(Rules)
            {

            }

            [Fact]
            public void WordList_ExistsOnCreation_WithListCreated()
            {
                Assert.IsType<List<string>>(WordList);
            }

            [Fact]
            public void CurrentWord_ExistsOnCreation_WithAWord_FromWordsList()
            {
                Assert.IsType<string>(CurrentWord);
                Assert.NotEqual(string.Empty, CurrentWord);
                Assert.Contains(CurrentWord, WordList);
            }

            [Fact]
            public void UsedWords_ExistsOnCreation_WithNoWordsInIt()
            {
                Assert.IsType<List<string>>(UsedWords);
                Assert.Empty(UsedWords);
            }

            [Fact]
            public void RulesEngine_ExistsOnCreation()
            {
                Assert.IsType<RulesEngine>(_engine);
                Assert.NotNull(_engine);
                Assert.Equal(Rules, _engine);
            }
        }

        public class SetupMethods: Words
        {
            [Fact]
            public void SetupWordList_PopulatesWordList_With5LetterWords()
            {
                WordList.Clear();

                SetupWordList();
                Assert.True(WordList.Count() > 0);

                foreach (string word in WordList)
                {
                    Assert.Equal(5, word.Length);
                }
            }
        }

        [Fact]
        public void GuessWord_GivenAnyString_Returns5LetterString()
        {
            var message = "guess";
            _engine.Setup(x => x.WordIsValid(It.IsAny<string>(), out message)).Returns(true);
            string result = words.GuessWord(message);

            Assert.IsType<string>(result);
            Assert.Equal(5, result.Length);
        }

        [Theory]
        [InlineData("Not5Letters")]
        [InlineData("TooManyLettersThanAccepted")]
        [InlineData("barber")]
        public void GuessWord_ThrowsWordTooLongException_GivenAStringGreaterThan5Letters(string wordLongerThan5)
        {
            var errorMessage = $"{wordLongerThan5} is too long";
            _engine.Setup(x => x.WordIsValid(It.IsAny<string>(), out errorMessage)).Returns(false);

            var ex = Assert.Throws<WordTooLongException>(() => words.GuessWord(wordLongerThan5));
            Assert.Equal($"{wordLongerThan5} is too long", ex.Message);
        }

        [Theory]
        [InlineData("one")]
        [InlineData("four")]
        [InlineData("hi")]
        [InlineData("I")]
        public void GuessWord_ThrowsWordTooShotException_GivenAStringShorterThan5Letters(string wordShorterThan5)
        {
            var errorMessage = $"{wordShorterThan5} is too short";
            _engine.Setup(x => x.WordIsValid(It.IsAny<string>(), out errorMessage)).Returns(false);

            var ex = Assert.Throws<WordTooShortException>(() => words.GuessWord(wordShorterThan5));
            Assert.Equal($"{wordShorterThan5} is too short", ex.Message);
        }

        [Theory]
        [InlineData("zZzZz")]
        public void GuessWord_ThrowsException_IfWordFailsWordRuleValidation(string invalidWord)
        {
            var errorMessage = $"{invalidWord} is not valid";
            _engine.Setup(x => x.WordIsValid(It.IsAny<string>(), out errorMessage)).Returns(false);

            var ex = Assert.Throws<WordNotValidException>(() => words.GuessWord("tests"));
            Assert.Equal($"{invalidWord} is not valid", ex.Message);
        }
    }
}
