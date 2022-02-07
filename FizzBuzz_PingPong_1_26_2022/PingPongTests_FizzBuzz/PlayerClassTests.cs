using FizzBuzz_Models;
using Xunit;

namespace FizzBuzz_Tests
{
    public class PlayerClassTests
    {
        private Player player;

        public PlayerClassTests()
        {
            player = new Player();
        }

        [Fact]
        public void Player_CanBeCreated()
        {
            Assert.NotNull(player); 
        }

        [Fact]
        public void Player_HasIntScoreProperty()
        {
            Assert.IsType<int>(player.Score);
            Assert.True(player.Score == 0);
        }

        [Fact]
        public void AddScore_ScoreAddsOne()
        {
            player.AddScore();
        
            Assert.Equal(1, player.Score);
        
            player.AddScore();
        
            Assert.Equal(2, player.Score);
        }

        [Fact]
        public void Player_HasStringNameProperty()
        {
            Assert.IsType<string>(player.Name);
        }
    }
}
