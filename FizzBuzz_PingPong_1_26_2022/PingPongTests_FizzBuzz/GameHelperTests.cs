using FizzBuzz_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz_Tests
{
    public class GameHelperTests
    {
        private GameHelper _gameHelper;

        public GameHelperTests()
        {
            _gameHelper = new GameHelper();
        }

        [Fact]
        public void OnCreate_GameHelperExists()
        {
            Assert.NotNull(_gameHelper);
        }

        [Fact]
        public void DetermineIfGuessWasCorrect_GivenAnIncorrectGuess_ReturnsFalse()
        {
            var result = _gameHelper.DetermineIfGuessWasCorrect("","fizz");

            Assert.False(result);
        }

        [Theory]
        [InlineData("guess")]
        [InlineData("fezz")]
        [InlineData("1")]
        public void DetermineIfGuessWasCorrect_GivenAGuessThatIsNotPossible_ThrowsException(string badGuess)
        {
            Assert.Throws<Exception>(() => _gameHelper.DetermineIfGuessWasCorrect(badGuess,"") );
        }

        [Theory]
        [InlineData("FIZZ","fizz")]
        [InlineData("Buzz", "buzz")]
        [InlineData("fiZZBuZz", "fizzbuzz")]
        public void DetermineIfGuessWasCorrect_CorrectGuessWithMismatchStringCase_ReturnsTrue(string guess, string actual)
        {
            var result = _gameHelper.DetermineIfGuessWasCorrect(guess, actual);

            Assert.True(result);
        }
    }
}
