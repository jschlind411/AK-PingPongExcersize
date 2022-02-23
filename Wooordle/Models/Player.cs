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

        public static string Name { get; private set; }
        public static int Score { get; } = 0;
    }
}
