using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Models
{
    public class RulesEngine : IRulesEngine
    {
        public RulesEngine()
        {
        }

        public string CompareWords(string actualWord, string guessWord)
        {
            char[] actualArray = actualWord.ToCharArray();
            char[] guessArray = guessWord.ToCharArray();

            string formattedString = "";

            for (int i = 0; i < guessWord.Length; i++)
            {

                if (guessArray[i] == actualArray[i])
                {
                    formattedString += guessArray[i];
                }
                else if (LetterFromGuessIsAtCurrentIndex(guessArray[i], actualArray))
                {
                    formattedString += "?";
                }
                else if (guessArray[i] != actualArray[i])
                {
                    formattedString += "-";
                }

            }

            return formattedString;
        }

        private bool LetterFromGuessIsAtCurrentIndex(char guessLetter, char[] actualWord)
        {
            for (int i = 0; i < actualWord.Length; i++)
            {
                if (guessLetter == actualWord[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateWord(string guess)
        {
            try
            {
                ThrowWordException(guess);

                return true;
            }
            catch (WordTooLongException e )
            {
                Console.WriteLine(e.Message);
            }
            catch(WordTooShortException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(WordNotValidException e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        protected void ThrowWordException(string guess)
        {
            if (guess.Length > 5)
            {
                throw new WordTooLongException("The word entered is too long");
            }
            else if (guess.Length < 5)
            {
                throw new WordTooShortException("The word entered is too short");
            }
            else if (Regex.IsMatch(guess, "[^a-z]"))
            {
                throw new WordNotValidException("The word entered is not valid");
            }
        }

        //Handle Exceptions
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