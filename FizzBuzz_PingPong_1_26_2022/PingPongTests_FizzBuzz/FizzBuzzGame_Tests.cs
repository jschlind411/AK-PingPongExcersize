using FizzBuzz_Models;
using FizzBuzz_Models.Interfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz_Tests
{
    public class FizzBuzzGame_Tests
    {
        FizzBuzzGame game;

        public FizzBuzzGame_Tests()
        {
            game = new FizzBuzzGame();
        }

        [Fact]
        public void FizzBuzzGame_CanBeCreated()
        {
            Assert.NotNull(game);
        }

        [Fact]
        public void PlayersList_IsInFizzBuzzGame()
        {
            Assert.IsType<List<Player>>(game.Players);
        }

        [Fact]
        public void AddPlayer_AddsPlayer_ToPlayersList()
        {
            game.AddPlayer("Bill");

            Assert.True(game.Players.Count == 1);

            game.AddPlayer("Ted");

            Assert.True(game.Players.Count == 2);
        }

    }
        
}
