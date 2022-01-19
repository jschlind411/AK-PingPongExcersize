using System;
using System.Collections.Generic;

namespace PingPongModels
{
    public class TicTacToe
    {
        private char[] Board;

        public TicTacToe()
        {
            Board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        }

        public bool Play(char character, int gridLocation)
        {
            if(IsValidMove(gridLocation))
            {
                Board[gridLocation - 1] = character;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidMove(int gridLocation)
        {
            if(gridLocation == 0 || gridLocation == 10)
            {
                return false;
            }

            if (Board[gridLocation-1] == ' ')
            {
                return true;
            }

            return false;
        }
    }
}
