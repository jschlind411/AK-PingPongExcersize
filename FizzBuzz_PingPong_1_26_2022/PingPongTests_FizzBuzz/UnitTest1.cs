using FizzBuzz_Models;
using Xunit;

namespace PingPongTests_FizzBuzz
{
    public class FizzBuzz_Tests
    {
        private FizzBuzzer fizzBuzzer;

        public FizzBuzz_Tests()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [Fact]
        public void ClassFizzBuzzer_exists()
        {
            Assert.NotNull(fizzBuzzer);
        }

        [Fact]
        public void CalculateResult_GivenANumber_WillNotReturnNull()
        {
            string result = fizzBuzzer.CalculateResult(2);

            Assert.NotNull(result);
        }

        [Fact]
        public void CalculateResult_GivenANumber_OutputsEmptyString_IfNoCriteriaMet()
        {
            string result = fizzBuzzer.CalculateResult(2);

            Assert.Equal("", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(36)]
        [InlineData(18)]
        public void CalculateResult_GivenANumberDivisibleBy3_OutputsFizz(int value)
        {
            string result = fizzBuzzer.CalculateResult(value);

            Assert.Equal("fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(20)]
        public void CalculateResult_GivenANumberDivisibleBy5_OutputsBuzz(int value)
        {
            string result = fizzBuzzer.CalculateResult(value);

            Assert.Equal("buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void CalculateResult_GivenANumberDivisibleBy15_OutputsFizzBuzz(int value)
        {
            string result = fizzBuzzer.CalculateResult(value);

            Assert.Equal("fizzbuzz", result);
        }
    }
}
