using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Models
{
    public class FizzBuzzGame
    {
        protected FizzBuzzer fizzBuzzer;

        public FizzBuzzGame() : this(new FizzBuzzer()) { }

        public FizzBuzzGame(FizzBuzzer fizzbuzzer)
        {
            fizzBuzzer = fizzbuzzer;
        }

        public bool Verify(string v1, int v2)
        {
            return true;
        }
    }
}
