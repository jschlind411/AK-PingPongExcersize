using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Models
{
    public class GameHelper :IGameHelper
    {
        public bool DetermineIfGuessWasCorrect(string guess, string result)
        {
            var wasSuccessful = false;

            if (result == guess)
            {
                wasSuccessful = true;
            }

            return wasSuccessful;
        }
    }
}
