using System;
using System.Collections.Generic;
using System.Text;

namespace Math_game
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is such a fun thing.\n");
            Console.WriteLine("Press a key to continue");
            Console.ReadLine();
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today?

            Choose:
             V - View previously played games
             A - Addition
             S - Subtraction
             M - Multiplication
             D - Division
             Q - Quit the program");
                Console.WriteLine("---------------------");

                var gameSelected = Console.ReadLine();

                //.Trim() is needed to remove whitespaces from before and after input.
                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("addition game start");
                        break;
                    case "s":
                        engine.SubtractionGame("sub game start");
                        break;
                    case "m":
                        engine.MultiplyGame("multi game start");
                        break;
                    case "d":
                        engine.DivisionGame("division game start");
                        break;
                    case "q":
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("invalid input, try again");
                        Console.ReadLine();
                        break;
                }

            }
            while (isGameOn);
        }
    }
}
