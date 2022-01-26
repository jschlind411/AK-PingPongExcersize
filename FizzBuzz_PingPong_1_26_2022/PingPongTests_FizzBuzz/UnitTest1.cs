using PingPong_Models;
using System;
using Xunit;

namespace PingPongTests_FizzBuzz
{
    public class FizzBuzz_Tests
    {
        [Fact]
        public void ClassFizzBuzzer_exists()
        {
            var result = new FizzBuzzer();

            Assert.NotNull(result);
        }

        [Fact]
        public void Test1()
        {
            var fizzBuzzer = new FizzBuzzer();
            string result = fizzBuzzer.CalculateResult(2);
        }
    }
}
