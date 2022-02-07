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
            Assert.True(game.Players.Count == 0);
        }

        [Theory]
        [InlineData("Bill")]
        [InlineData("Ted")]
        [InlineData("Rufus")]
        public void AddPlayer_GivenAStringName_AddsPlayerToPlayersList(string name)
        {
            game.AddPlayer(name);

            Assert.True(game.Players.Count == 1);
            Assert.Equal(name, game.Players[0].Name);
        }

        [Fact]
        public void GetStartPlayer_ReturnsPlayerObject()
        {
            
            var result = game.GetStartPlayer();

            Assert.IsType<Player>(result);
        }

        [Fact]
        public void GetStartPlayer_GivenAPlayerList_WithOnePlayer_ReturnsCorrectPlayer()
        {
            game.AddPlayer("Bob");
            Player player = game.GetStartPlayer();

            Assert.Equal("Bob", player.Name);
            Assert.Equal(game.Players[0], player);
        }
    }
        
}
