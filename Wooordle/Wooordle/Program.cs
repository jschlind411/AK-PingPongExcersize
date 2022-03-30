using Models;
using System;

namespace Wooordle
{
    public class Program
    {
        public static Player currentPlayer;
        public static Words words;
        public static string currentWordProgress;
        public static int tries = 6;

        public static void Main(string[] args)
        {
            PlayWordle();
        }

        public static void PlayWordle()
        {
            words = new Words();

            CreatePlayers();

            bool KeepPlaying = false;

            do
            {
                var wordGuessedCorrectly = false;

                do
                {
                    wordGuessedCorrectly = WordleGuessPhase();

                } while (!wordGuessedCorrectly);

                KeepPlaying = AskUserToContinue();

            } while (KeepPlaying);
        }

        private static bool WordleGuessPhase()
        {
            DisplayWord();

            return PlayerGuess();
        }

        public static void CreatePlayers()
        {
            Console.WriteLine("Enter player name: ");
            string playerName = Console.ReadLine();

            currentPlayer = new Player(playerName);
            Console.WriteLine($"Created new player {currentPlayer.Name}");
        }

        public static void DisplayWord()
        {
            Console.WriteLine($"Guesses remaining: {tries}");
            if(tries == 6)
            {
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine(currentWordProgress);
            }
        }

        public static bool PlayerGuess()
        {
            Console.WriteLine("Enter guess: ");
            string guessWord = Console.ReadLine();

            string result = words.GuessWord(guessWord);
            if (result == words.CurrentWord)
            {
                currentWordProgress = words.CurrentWord;
                Console.WriteLine("Nicely Done!");
                return true;
            }

            currentWordProgress = result;
            return false;
        }

        public static bool AskUserToContinue()
        {
            Console.WriteLine();
            return false;
        }
    }
}
