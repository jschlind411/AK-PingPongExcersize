using FizzBuzz_Models.Interfaces;
using System;
using System.Collections.Generic;

namespace FizzBuzz_Models
{
    public class FizzBuzzGame
    {
        public List<Player> Players { get; set; }

        public Random RandomGenerator { get; set; }

        public int CurrentNumber { get; set; }

        public FizzBuzzGame()
        {
            Players = new List<Player>();
            RandomGenerator = new Random();
            CurrentNumber = 1;
        }

        public void AddPlayer(string name)
        {
            Players.Add(new Player() { Name = name });
        }

        public Player GetStartPlayer()
        {
            if(Players.Count != 0)
            {
                return Players[RandomGenerator.Next(0, Players.Count)];
            }

            return new Player();
        }
    }
}
