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
        public void Play_GivenACharacterAndValidPlacement_WillReturnTrueIfSuccessful()
        {
            var success = Game.Play('x', 1);
            
            Assert.True(success);
        }

        [Theory]
        [InlineData('x')]
        [InlineData('o')]
        public void Play_GivenACharacterAndValidPlacement_WillPutCharacterInCorrectSpace(char label)
        {
            var success = Game.Play(label, 1);

            Assert.Equal(label, Game.Board[0]);
        }

        [Theory]
        [InlineData('Y')]
        [InlineData('z')]
        public void Play_GivenAnInvalidCharacter_WillReturnFalse(char label)
        {
            var success = Game.Play(label, 1);

            Assert.False(success);
        }

        [Fact]
        public void Play_GivenACharacterAndValidPlacement_WillPlayMultipleTimes()
        {
            var success = Game.Play('x', 1);

            Assert.True(success);

            success = Game.Play('x', 6);

            Assert.True(success);

            success = Game.Play('x', 9);

            Assert.True(success);
        }

        [Fact]
        public void Play_GivenATakenPlacement_willReturnFalse()
        {
            Game.Play('x', 1);
            var success = Game.Play('x', 1);

            Assert.False(success);

            var success2 = Game.Play('x', 2);

            Assert.True(success2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(-50)]
        [InlineData(50)]
        public void Play_GivenAnOutOfBoundPlacement_willReturnFalse(int outOfBoundsLocation)
        {
            var success = Game.Play('x', outOfBoundsLocation);

            Assert.False(success);
        }
    }
}
