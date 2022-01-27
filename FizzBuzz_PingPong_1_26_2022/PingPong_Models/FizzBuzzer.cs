using System;

namespace FizzBuzz_Models
{
    public class FizzBuzzer: IFizzBuzzer
    {
        public string CalculateResult(int i)
        {
            if (i % 15 == 0)
            {
                return "fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                return "fizz";
            }
            else if(i % 5 == 0)
            {
                return "buzz";
            }

            return string.Empty;
        }
    }
}
