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

        public static void CreatePlayers()
        {
            Console.WriteLine("Enter player name: ");
            string playerName = Console.ReadLine();

            currentPlayer = new Player(playerName);
            Console.WriteLine($"Created new player {currentPlayer.Name}\n");
        }

        private static bool WordleGuessPhase()
        {
            DisplayProgress();

            return PlayerGuess();
        }

        public static void DisplayProgress()
        {
            Console.WriteLine($"Guesses remaining: {tries}");

            if(tries == 6)
            {
                currentWordProgress = "-----";
            }

            Console.WriteLine(currentWordProgress.ToUpper());
        }

        public static bool PlayerGuess()
        {
            Console.WriteLine("Enter guess: ");
            string userGuessInput = Console.ReadLine().ToLower();

            string result = words.GuessWord(userGuessInput);

            if (result == words.CurrentWord)
            {
                currentWordProgress = words.CurrentWord;
                Console.WriteLine("Nicely Done!");
                return true;
            }

            Console.WriteLine();
            currentWordProgress = result;
            tries--;

            return false;
        }

        public static bool AskUserToContinue()
        {
            Console.WriteLine("Continue Playing? y/n");
            string userAnswer = Console.ReadLine()[0].ToString().ToLower();

            if (userAnswer == "y")
            {
                tries = 6;
                return true;
            }

            else if(userAnswer == "n")
            {
                Console.WriteLine("Ending game");
            }
            else
            {
                Console.Write("Not a valid answer - Ending game");
            }
            return false;
        }
    }
}
