﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WooordleTests
{
    public class WordsTests
    {
        [Fact]
        public void Words_CanBeCreated_UsingDefaultConstructor()
        {
            Words words = new Words();

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
        }

        public class Setups: Words
        {
            [Fact]
            public void SetupWordList_PopulatesWordList_WithOneStrings()
            {
                WordList.Clear();
                SetupWordList();

                Assert.True(WordList.Count() > 0);
            }
        }
    }
}
