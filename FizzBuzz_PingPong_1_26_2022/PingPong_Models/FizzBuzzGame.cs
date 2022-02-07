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
            Players = new List<Player>() { new Player() { Name = "Bill" } } ;
        }

        public void AddPlayer(string name)
        {
            if(name == "Ted")
            {
                Players.Add(new Player() { Name = "Ted" } );
            }
        }

        public Player GetStartPlayer()
        {
            return new Player();
        }
    }
}
