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
        [InlineData("guess")]
        public void DetermineIfGuessWasCorrect_GivenAGuessThatIsNotPossible_ThrowsException(string badGuess)
        {

            Assert.Throws<Exception>(() => _gameHelper.DetermineIfGuessWasCorrect(badGuess,"") );
        }
    }
}
