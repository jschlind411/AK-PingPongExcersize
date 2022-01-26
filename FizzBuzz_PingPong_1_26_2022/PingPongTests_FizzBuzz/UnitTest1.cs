using PingPong_Models;
using System;
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

        [Fact]
        public void CalculateResult_GivenANumberDivisibleBy3_OutputsFizz()
        {
            string result = fizzBuzzer.CalculateResult(3);

            Assert.Equal("fizz", result);
        }

        [Fact]
        public void CalculateResult_GivenANumberDivisibleBy5_OutputsBuzz()
        {
            string result = fizzBuzzer.CalculateResult(5);

            Assert.Equal("buzz", result);
        }

        [Fact]
        public void CalculateResult_GivenANumberDivisibleBy15_OutputsFizzBuzz()
        {
            string result = fizzBuzzer.CalculateResult(15);

            Assert.Equal("fizzbuzz", result);
        }
    }
}
