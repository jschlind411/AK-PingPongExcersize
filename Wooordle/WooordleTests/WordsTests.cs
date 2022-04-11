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

        public class SetupTests: Words
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

        public class WordChangeTests: Words
        {
            [Fact]
            public void ChangeCurrentWord_SetsWordFromWordList_AsCurrentWord()
            {
                string Current = CurrentWord;
                ChangeCurrentWord(CurrentWord);

                Assert.True(Current != CurrentWord);
                Assert.Contains(CurrentWord, WordList);
            }
        }

        [Fact]
        public void GuessWord_GivenAnyString_ReturnsStringResponse_FromCompareWordsResult()
        {
            _engine.Setup(x => x.ValidateWord(It.IsAny<string>())).Returns(true);

            string responseFromRulesEngine = "guess";
            _engine.Setup(x => x.CompareWords(It.IsAny<string>(), It.IsAny<string>())).Returns(responseFromRulesEngine);

            string result = words.GuessWord("");

            Assert.IsType<string>(result);
            Assert.Equal(responseFromRulesEngine, result);
        }

        [Fact]
        public void GuessWord_ReturnsEmptyLine_IfEngineValidateWord_ReturnsFalse()
        {
            _engine.Setup(x => x.ValidateWord(It.IsAny<string>())).Returns(false);

            string result = words.GuessWord("");

            Assert.Equal("", result);
        }
    }
}
