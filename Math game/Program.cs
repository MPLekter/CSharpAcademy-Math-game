using System;
using System.Collections.Generic;

namespace Math_game
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> games = new List<string>();
            #region initial_lesson
            /* int index = 1;
             string name = "Pablo";
             char initial = 'P';
             int year = 2022;
             double onethreethree = 1.33d;
             bool loveToCode = true;


             //by using $@ in string, you can make bigger chunks of info in multiple lines without using multiple statements. Useful.
             string myParagraph = $@"These are the datatypes: 
             {index++} -string, example: {name}
             {index++} -int, example: {year}
             {index++} -bool, example: {loveToCode}
             {index++} -char, example: {initial}
             {index++} -double, example: {onethreethree}";

             //works the same as below

             Console.WriteLine("These are the datatypes:\n");
             Console.WriteLine($"{index++} -string, example: {name}");
             Console.WriteLine($"{index++} -int, example: {year}");
             Console.WriteLine($"{index++} -bool, example: {loveToCode}");
             Console.WriteLine($"{index++} -char, example: {initial}");
             Console.WriteLine($"{index++} -double, example: {onethreethree}");
             */
            //Console.WriteLine(myParagraph);
            #endregion
            string name = GetName();
            Menu(name);

            static string GetName()
            {
                Console.WriteLine("What is your name?");

                var name = Console.ReadLine();
                return name;
            }

            void Menu(string name)
            {
                var date = DateTime.UtcNow;
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
                            GetGames();
                            break;
                        case "a":
                            AdditionGame("addition game start");
                            break;
                        case "s":
                            SubtractionGame("sub game start");
                            break;
                        case "m":
                            MultiplyGame("multi game start");
                            break;
                        case "d":
                            DivisionGame("division game start");
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
            void GetGames()
            {
                Console.Clear();
                Console.WriteLine("Games History");
                Console.WriteLine("-------------");
                foreach (var game in games)
                { 
                    Console.WriteLine(game); 
                }
                Console.WriteLine("-------------\n");
                Console.WriteLine("Press any key to return to menu");
                Console.ReadLine();
            }
            void DivisionGame(string message)
            {
                var numberOfChances = 5;
                var score = 0;

                for (int i = 0; i < numberOfChances; i++)
                {
                    var divisionNumbers = GetDivisionNumbers();
                    var firstNumber = divisionNumbers[0];
                    var secondNumber = divisionNumbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber / secondNumber)
                    {
                        Console.WriteLine("correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    if (i == numberOfChances - 1)
                    {
                        AddToHistory(games, score, "Division");
                        ShowFinalScore(score);
                    }
                }
            }

            void MultiplyGame(string message)
            {
                var random = new Random(); //random integer
                var score = 0;
                var numberOfChances = 5;

                int firstNumber;
                int secondNumber;

                for (int i = 0; i < numberOfChances; i++)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} * {secondNumber}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber * secondNumber) //result is a string, so it needs to be parsed back into an int.
                    {
                        Console.WriteLine("correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer!");
                    }

                    if (i == numberOfChances - 1)
                    {
                        AddToHistory(games, score, "Multiply");
                        ShowFinalScore(score);
                    }
                }
            }

            void SubtractionGame(string message)
            {
                var random = new Random(); //random integer
                var score = 0;
                var numberOfChances = 5;

                int firstNumber;
                int secondNumber;

                for (int i = 0; i < numberOfChances; i++)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber - secondNumber) //result is a string, so it needs to be parsed back into an int.
                    {
                        Console.WriteLine("correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer!");
                    }

                    if (i == numberOfChances - 1)
                    {
                        AddToHistory(games, score, "Subtraction");
                        ShowFinalScore(score);
                    }
                }
            }

            void AdditionGame(string message)
            {
                var random = new Random(); //random integer
                var score = 0;
                var numberOfChances = 5;

                int firstNumber;
                int secondNumber;

                for (int i = 0; i < numberOfChances; i++)
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} + {secondNumber}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber + secondNumber) //result is a string, so it needs to be parsed back into an int.
                    {
                        Console.WriteLine("correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("wrong answer!");
                    }

                    if (i == numberOfChances - 1)
                    {
                        AddToHistory(games, score, "Addition");
                        ShowFinalScore(score);
                    }
                }

            }

            static int[] GetDivisionNumbers()
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
            static void ShowFinalScore(int score)
            {
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to continue");
                Console.ReadLine();
            }

        }

        private static void AddToHistory(List<string> games, int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score={score}");
        }
    }
}
