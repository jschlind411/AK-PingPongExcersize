using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
                "tests"
            };
        }

        public string GuessWord(string guess)
        {
            if (!_engine.WordIsValid(guess, out string message))
            {
                if (message.Contains("long"))
                {
                    throw new WordTooLongException(message);
                }
                else if (message.Contains("short"))
                {
                    throw new WordTooShortException(message);
                }
                else
                {
                    throw new WordNotValidException(message);
                }
            }

            return guess;
        }

        [Serializable]
        public class WordTooLongException : Exception
        {
            public WordTooLongException()
            {
            }

            public WordTooLongException(string message) : base(message)
            {
            }

            public WordTooLongException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected WordTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        [Serializable]
        public class WordTooShortException : Exception
        {
            public WordTooShortException()
            {
            }

            public WordTooShortException(string message) : base(message)
            {
            }

            public WordTooShortException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected WordTooShortException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        [Serializable]
        public class WordNotValidException : Exception
        {
            public WordNotValidException()
            {
            }

            public WordNotValidException(string message) : base(message)
            {
            }

            public WordNotValidException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected WordNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
