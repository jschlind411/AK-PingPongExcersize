using System;
using PingPongModels;
using Xunit;

namespace PingPongTests
{
    public class TicTacToeTests
    {
        private TicTacToe Game;

        public TicTacToeTests()
        {
            Game = new TicTacToe();
        }

        [Fact]
        public void Can_Create_TicTacToe_Object()
        {
            Assert.NotNull(Game);
        }

        [Fact]
        public void Play_GivenACharacterAndPlacement_willPlaceMove()
        {
            var success = Game.Play('x', 1);          
        }
    }
}
