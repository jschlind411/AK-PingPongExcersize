using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Models
{
    public class Player
    {
        public int Score { get; set; }

        public void AddScore()
        {
            Score += 1;
        }
    }
}
