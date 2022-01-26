using System;

namespace PingPong_Models
{
    public class FizzBuzzer
    {
        public string CalculateResult(int i)
        {
            if(i == 3)
            {
                return "fizz";
            }
            else if(i == 5)
            {
                return "buzz";
            }

            return string.Empty;
        }
    }
}
