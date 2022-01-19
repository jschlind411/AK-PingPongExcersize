using System;

namespace PingPongModels
{
    public class TicTacToe
    {
        private bool hasMoved = false;
        public bool Play(char character, int gridLocation)
        {
            if(hasMoved == false)
            {
                hasMoved = true;
                return hasMoved;
            }
            else
            {
                return false;
            }
        }
    }
}
