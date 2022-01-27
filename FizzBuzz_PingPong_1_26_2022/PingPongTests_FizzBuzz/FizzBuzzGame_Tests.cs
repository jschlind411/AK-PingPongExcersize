using FizzBuzz_Models;
using Moq;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzzGame_Tests
    {
        private FizzBuzzGame fizzBuzz;
        private Mock<FizzBuzzer> _mockFizzBuzzer;

        public FizzBuzzGame_Tests()
        {
            _mockFizzBuzzer = new Mock<FizzBuzzer>();
            fizzBuzz = new FizzBuzzGame(_mockFizzBuzzer);
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

            var result = fizzBuzz.Verify("", 0);

            Assert.True(result);
        }
    }
}
