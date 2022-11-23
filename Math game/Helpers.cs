using System;
using System.Collections.Generic;
using Math_game.Models;

namespace Math_game
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>(); //using field here to have the games usable throughout the whole class, not just one method.

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} {game.Type} Score = {game.Score}");
            }
            Console.WriteLine("-------------\n");
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0) //% gives you a reminder of division. So: 4/4 = 4.0. -> false (good). 5/4 = 1.25 ->true (not what is intended). While true, regenerate numbers.
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static void ShowFinalScore(int score)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to continue");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, GameType gameType)
        {
            //games.Add($"{DateTime.Now} - {gameType}: Score={score}"); //old code when games was a list of strings
            games.Add(new Game 
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }
    }
}
