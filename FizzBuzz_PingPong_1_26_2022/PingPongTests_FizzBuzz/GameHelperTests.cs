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

        [Theory]
        [InlineData("","")]
        [InlineData("fizz","fizz")]
        [InlineData("buzz","buzz")]
        [InlineData("fizzbuzz","fizzbuzz")]
        public void DetermineIfGuessWasCorrect_GivenACorrectGuess_ReturnTrue(string guess, string actual)
        {
            bool result = _gameHelper.DetermineIfGuessWasCorrect(guess, actual);

            Assert.True(result);
        }

        [Theory]
        [InlineData("","fizz")]
        [InlineData("fizz","buzz")]
        [InlineData("buzz", "fizzbuzz")]
        public void DetermineIfGuessWasCorrect_GivenAnIncorrectGuess_ReturnsFalse(string guess, string actual)
        {
            var result = _gameHelper.DetermineIfGuessWasCorrect(guess, actual);

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
