using FizzBuzz_Models;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzzGame_Tests
    {
        private FizzBuzzGame fizzBuzz;

        public FizzBuzzGame_Tests()
        {
            fizzBuzz = new FizzBuzzGame();
        }

        public class FizzBuzzerTests
        {
            private FizzBuzzGame fizzBuzz;

            public FizzBuzzerTests()
            {
                fizzBuzz = new FizzBuzzGame();
            }

            [Fact]
            public void FizzBuzzer_IsCreated_WithinFizzBuzzGame()
            {
                Assert.NotNull(fizzBuzz.fizzBuzzer);
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
