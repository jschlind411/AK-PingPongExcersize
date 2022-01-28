using FizzBuzz_Models;
using Moq;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzzGame_Tests
    {
        private FizzBuzzGame fizzBuzz;
        private Mock<IFizzBuzzer> _mockFizzBuzzer;
        private Mock<IGameHelper> _gameHelper;

        public FizzBuzzGame_Tests()
        {
            _mockFizzBuzzer = new Mock<IFizzBuzzer>();
            _gameHelper = new Mock<IGameHelper>();
            fizzBuzz = new FizzBuzzGame(_mockFizzBuzzer.Object, _gameHelper.Object);
        }

        public class FizzBuzzerPropertiesTests: FizzBuzzGame
        {
            [Fact]
            public void FizzBuzzer_IsCreated_WithinFizzBuzzGame()
            {
                Assert.NotNull(fizzBuzzer);
            }
        }


        [Fact]
        public void FizzBuzzGame_CanBeCreated()
        {
            Assert.NotNull(fizzBuzz);
        }

        [Fact]
        public void Verify_GivenAnyStringAndInteger_ReturnsBoolResult()
        {
            var result = fizzBuzz.Verify("", 0);

            Assert.IsType<bool>(result);
        }

        [Fact]
        public void Verify_GivenAValidGuess_ReturnsTrue()
        {
            //_mockFizzBuzzer.Setup(x => x.CalculateResult(It.IsAny<int>() )).Returns("");
            _gameHelper.Setup(x => x.DetermineIfGuessWasCorrect(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            var result = fizzBuzz.Verify("", 0);

            Assert.True(result);
        }

        [Fact]
        public void Verify_GivenAnInvalidGuess_ReturnsFalse()
        {
            //_mockFizzBuzzer.Setup(x => x.CalculateResult(It.IsAny<int>() )).Returns("");
            _gameHelper.Setup(x => x.DetermineIfGuessWasCorrect(It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            var result = fizzBuzz.Verify("", 0);

            Assert.False(result);
        }
    }
}
