using System;
using Xunit;
using Models;

namespace WooordleTests
{
    public class PlayerTests
    {
        [Fact]
        public void Player_Exists()
        {
            var player = new Player();

            Assert.IsType<Player>(player);
        }

        [Fact]
        public void Name_Exists()
        {
            var player = new Player();

            Assert.IsType<string>(Player.Name);
        }
    }
}
