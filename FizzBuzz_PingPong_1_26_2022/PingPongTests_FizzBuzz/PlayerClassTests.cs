﻿using FizzBuzz_Models;
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

        //[Fact]
        //public void FizzBuzzGame_CanHoldMultipleScores()
        //{
        //    var result = fizzBuzz.Score[0];
        //}
        //
        //[Fact]
        //public void AddScore_ScoreAddsOne()
        //{
        //    fizzBuzz.AddScore();
        //
        //    Assert.Equal(1, fizzBuzz.Score);
        //
        //    fizzBuzz.AddScore();
        //
        //    Assert.Equal(2, fizzBuzz.Score);
        //}
    }
}
