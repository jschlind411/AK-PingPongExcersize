﻿using System.Collections.Generic;

namespace Models
{
    public class Words
    {
        protected List<string> WordList { get; set; }

        protected List<string> UsedWords { get; set; }

        protected string CurrentWord { get; set; }

        public Words()
        {
            UsedWords = new List<string>();
            CurrentWord = "tests";

            SetupWordList();
        }

        protected void SetupWordList()
        {
            WordList = new List<string>
            {
                "tests"
            };
        }

        public string GuessWord(string guess)
        {
            return guess;
        }
    }
}
