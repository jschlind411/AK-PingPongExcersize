using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Models
{
    public interface IGameHelper
    {
        bool DetermineIfGuessWasCorrect(string guess, string result);
    }
}
