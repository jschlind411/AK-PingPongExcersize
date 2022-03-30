using System;

namespace Wooordle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayWordle();
        }

        public static void PlayWordle()
        {
            CreatePlayers();

            bool KeepPlaying = false;

            do
            {
                var wordGuessedCorrectly = false;

                do
                {
                    wordGuessedCorrectly = WordleGuessPhase();

                } while (!wordGuessedCorrectly);


            } while (!KeepPlaying);
        }

        private static bool WordleGuessPhase()
        {
            DisplayWord();

            return PlayerGuess();
        }

        public static void CreatePlayers()
        {

        }

        public static void DisplayWord()
        {

        }

        public static bool PlayerGuess()
        {
            return false;
        }
    }
}
