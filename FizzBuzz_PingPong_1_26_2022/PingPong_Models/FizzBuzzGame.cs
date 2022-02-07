using FizzBuzz_Models.Interfaces;
using System;
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

        public void AddPlayer(string name)
        {
            Players.Add(new Player() { Name = name });
        }

        public Player GetStartPlayer()
        {
            return new Player();
        }
    }
}
