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
        public void Play_GivenACharacterAndPlacement_willReturnTrueIfSuccessful()
        {
            var success = Game.Play('x', 1);
            
            Assert.True(success);
        }

        [Fact]
        public void Play_GivenAPlacement_willReturnFalse_IfSpaceIsTaken()
        {
            var success = Game.Play('x', 1);
            var success2 = Game.Play('x', 1);

            Assert.False(success2);
        }
    }
}
