using System;
using Xunit;
using Models;

namespace WooordleTests
{
    public class PlayerTests
    {
        public Player player;

        public PlayerTests()
        {
            player = new Player();
        }
            
        [Fact]
        public void Player_Exists()
        {
            Assert.IsType<Player>(player);
        }

        [Fact]
        public void Name_Exists()
        {
            Assert.IsType<string>(Player.Name);
        }

        [Fact]
        public void Score_Exists()
        {
            Assert.IsType<int>(Player.Score);
        }

        [Fact]
        public void Score_InitalizedToZero()
        {
            Assert.Equal(0, Player.Score);
        }

        [Fact]
        public void Name_NoPassedString_InitalizedToEmpty()
        {
            Assert.Equal("", Player.Name);
        }

        [Fact]
        public void Name_PassedString_InitalizedToString()
        {
            Player player = new Player("Andy");
        }
    }
}
