using FizzBuzz_Models.Interfaces;
using System.Collections.Generic;

namespace FizzBuzz_Models
{
    public class FizzBuzzGame
    {
        public List<Player> Players { get; set; }

        public FizzBuzzGame()
        {
            Players = new List<Player>();
        }
    }
}
