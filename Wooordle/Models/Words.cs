using System.Collections.Generic;

namespace Models
{
    public class Words
    {
        protected IRulesEngine _engine;

        protected List<string> WordList { get; set; }

        protected List<string> UsedWords { get; set; }

        protected string CurrentWord { get; set; }

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

        protected void ChangeCurrentWord(string currentWord)
        {
            CurrentWord = "guess";
        }

        public string GuessWord(string guess)
        {
            _engine.ValidateWord(guess);

            string output = _engine.CompareWords(CurrentWord, guess);

            if(output == guess)
            {
                return $"{output} Nicely Done!";
            }

            return output;
        }
    }
}
