using System.Collections.Generic;

namespace Models
{
    public class Words
    {
        protected IRulesEngine _engine;

        protected List<string> WordList { get; set; }

        protected List<string> UsedWords { get; set; }

        public string CurrentWord { get; protected set; }

        public Words() : this(new RulesEngine())
        {
            
        }

        public Words(IRulesEngine engine)
        {
            _engine = engine;

            UsedWords = new List<string>();
            CurrentWord = "tests";

            SetupWordList();
        }

        protected void SetupWordList()
        {
            WordList = new List<string>
            {
                "tests",
                "guess"
            };
        }

        public void ChangeCurrentWord(string currentWord)
        {
            CurrentWord = "guess";
        }

        public string GuessWord(string guess)
        {
            string output = "";

            if (_engine.ValidateWord(guess))
            {
                 output = _engine.CompareWords(CurrentWord, guess);
            }

            return output;
        }
    }
}
