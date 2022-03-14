﻿using System;
using System.Runtime.Serialization;

namespace Models
{
    public class RulesEngine: IRulesEngine
    {
        public RulesEngine()
        {
        }

        public string CompareWords(string actualWord, string guessWord)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateWord(string guess)
        {
            ThrowWordException(guess);

            return true;
        }

        private void ThrowWordException(string guess)
        {
            if (guess.Length > 5)
            {
                throw new WordTooLongException();
            }
            else if (guess.Length < 5)
            {
                throw new WordTooShortException();
            }
            else if (guess.Contains('&'))
            {
                throw new WordNotValidException();
            }
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