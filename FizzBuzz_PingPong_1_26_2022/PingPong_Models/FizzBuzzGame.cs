using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Models
{
    public class FizzBuzzGame
    {
        protected IFizzBuzzer fizzBuzzer;
        protected IGameHelper _gameHelper;

        public int Score { get; private set; } = 0;

        public FizzBuzzGame() : this(new FizzBuzzer(), new GameHelper()) { }

        public FizzBuzzGame(IFizzBuzzer fizzbuzzer, IGameHelper gameHelper)
        {
            fizzBuzzer = fizzbuzzer;
            _gameHelper = gameHelper;
        }

        public bool Verify(string guess, int value)
        {
            var result = fizzBuzzer.CalculateResult(value);

            return _gameHelper.DetermineIfGuessWasCorrect(guess, result);
        }

        public void AddScore()
        {
            Score = 1;
        }
    }
}
