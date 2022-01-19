using System;
using PingPongModels;
using Xunit;

namespace PingPongTests
{
    public class TicTacToeTests
    {
        [Fact]
        public void Can_Create_TicTacToe_Object()
        {
            var TicTacToe = new TicTacToe();

            Assert.NotNull(TicTacToe);
        }

        [Fact]
        public void Play_GivenACharacterAndPlacement_willPlaceMove()
        {
            var TicTacToe = new TicTacToe();
            TicTacToe.Play('x', 1);
        }
    }
}
