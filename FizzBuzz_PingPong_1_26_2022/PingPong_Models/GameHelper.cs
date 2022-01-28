using System;

namespace FizzBuzz_Models
{
    public class GameHelper :IGameHelper
    {
        public bool DetermineIfGuessWasCorrect(string guess, string result)
        {
            if(!ValidateGuess(guess))
            {
                throw new Exception();
            }

            var wasSuccessful = false;

            if (guess.ToLower() == result)
            {
                wasSuccessful = true;
            }

            return wasSuccessful;
        }

        private bool ValidateGuess(string guess)
        {
            if(guess.ToLower() != "fizz" && guess.ToLower() != "buzz" && guess.ToLower() != "fizzbuzz")
            {
                return false;
            }

            return true;
        }
    }
}
