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
        public void Player_CanBeCreated()
        {
            Assert.IsType<Player>(player);
        }

        [Fact]
        public void PlayerHas_IntScore_AndInitalizedToZero()
        {
            Assert.IsType<int>(player.Score);
            Assert.Equal(0, player.Score);
        }

        [Fact]
        public void PlayerHas_StringName_AndNoPassedString_IsEmpty()
        {
            Assert.IsType<string>(player.Name);
            Assert.Equal("", player.Name);
        }

        [Fact]
        public void PlayerHas_StringName_AndPassedString_SetsName()
        {
            Player player = new Player("Andy");

            Assert.Equal("Andy", player.Name);
        }
    }
}
