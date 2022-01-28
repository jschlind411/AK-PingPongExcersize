using FizzBuzz_Models;
using Xunit;

namespace FizzBuzz_Tests
{
    public class PlayerClassTests
    {
        [Fact]
        public void Player_CanBeCreated()
        {
            var result = new Player();

            Assert.NotNull(result); 
        }

        [Fact]
        public void Player_hasIntScoreProperty()
        {
            var player = new Player();

            Assert.IsType<int>(player.Score);
        }

        [Fact]
        public void AddScore_ScoreAddsOne()
        {
            var player = new Player();

            player.AddScore();
        
            Assert.Equal(1, player.Score);
        
            player.AddScore();
        
            Assert.Equal(2, player.Score);
        }
    }
}
