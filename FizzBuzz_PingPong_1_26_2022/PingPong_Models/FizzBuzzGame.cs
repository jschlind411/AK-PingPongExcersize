using FizzBuzz_Models.Interfaces;
using System.Collections.Generic;

namespace FizzBuzz_Models
{
    public class FizzBuzzGame
    {
        protected IFizzBuzzer fizzBuzzer;
        protected IGameHelper _gameHelper;

        public int Score { get; private set; } = 0;
        protected List<Player> Players { get; set; }

        public FizzBuzzGame() : this(new FizzBuzzer(), new GameHelper()) { }

        public FizzBuzzGame(IFizzBuzzer fizzbuzzer, IGameHelper gameHelper)
        {
            fizzBuzzer = fizzbuzzer;
            _gameHelper = gameHelper;
            Players = new List<Player>();
        }

        public bool Verify(string guess, int value)
        {
            var result = fizzBuzzer.CalculateResult(value);

            return _gameHelper.DetermineIfGuessWasCorrect(guess, result);
        }

        public Player GetWinner()
        {
            return new Player();
        }

        public void CreatePlayer(string name)
        {
            
        }
    }
}
