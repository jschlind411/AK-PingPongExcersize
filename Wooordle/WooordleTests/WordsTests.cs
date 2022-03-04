using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Models.Words;

namespace WooordleTests
{
    public class WordsTests
    {
        public Words words;

        public WordsTests()
        {
            words = new Words();
        }

        [Fact]
        public void Words_CanBeCreated_UsingDefaultConstructor()
        {
            Assert.NotNull(words);
        }

        public class Properties: Words
        {
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
        }

        public class Setup: Words
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
            string result = words.GuessWord("guess");

            Assert.IsType<string>(result);
            Assert.Equal(5, result.Length);
        }

        [Fact]
        public void GuessWord_ThrowsArgException_GivenAStringGreaterThan5Letters()
        {
            Assert.Throws<WordTooLongException>(() => words.GuessWord("Not5Letters"));
        }
    }
}
