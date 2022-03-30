using System;

namespace Models
{
    public class Player
    {
        public Player() : this(string.Empty) { }

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int Score { get; set; } = 0;
    }
}
