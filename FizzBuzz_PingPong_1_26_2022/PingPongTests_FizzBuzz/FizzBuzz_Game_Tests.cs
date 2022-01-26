using FizzBuzz_Models;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzz_Game_Tests
    {
        [Fact]
        public void FizzBuzz_Game_NotNull()
        {
            var result = new FizzBuzzGame();

            Assert.NotNull(result);
        }

        [Fact]
        public void FizzBuzz_Game_VerifyUserGuess()
        {
            var fizzBuzz = new FizzBuzzGame();
            bool result = fizzBuzz.Verify("fizz", 5);
        }
    }
}
