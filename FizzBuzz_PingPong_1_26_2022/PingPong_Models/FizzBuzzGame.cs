﻿using FizzBuzz_Models.Interfaces;

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

        public void GetWinner()
        {

        }
    }
}
