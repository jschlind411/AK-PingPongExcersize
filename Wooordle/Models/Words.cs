using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string GuessWord()
        {
            return "string";
        }
    }
}
