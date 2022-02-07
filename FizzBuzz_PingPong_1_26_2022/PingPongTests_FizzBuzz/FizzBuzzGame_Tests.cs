using FizzBuzz_Models;
using FizzBuzz_Models.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzzGame_Tests
    {
        [Fact]
        public void FizzBuzzGame_CanBeCreated()
        {
            var game = new FizzBuzzGame();

            Assert.NotNull(game);
        }

        [Fact]
        public void PlayersList_IsInFizzBuzzGame()
        {
            var game = new FizzBuzzGame();

            Assert.IsType<List<Player>>(game.Players);
        }

    }
        
}
