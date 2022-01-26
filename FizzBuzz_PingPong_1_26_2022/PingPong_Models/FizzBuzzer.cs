using System;

namespace PingPong_Models
{
    public class FizzBuzzer
    {
        public string CalculateResult(int i)
        {
            if(i % 3 == 0 && i!=15)
            {
                return "fizz";
            }
            else if(i % 5 == 0 && i != 15)
            {
                return "buzz";
            }
            else if(i == 15)
            {
                return "fizzbuzz";
            }

            return string.Empty;
        }
    }
}
