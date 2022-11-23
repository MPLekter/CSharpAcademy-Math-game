using System;
using Math_game.Models;

namespace Math_game
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            var numberOfChances = 5;
            var score = 0;

            for (int i = 0; i < numberOfChances; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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
                    Helpers.AddToHistory(score, GameType.Division);
                    Helpers.ShowFinalScore(score);
                }
            }
        }

        internal void MultiplyGame(string message)
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
                result = Helpers.ValidateResult(result);

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
                    Helpers.AddToHistory(score, GameType.Multiplication);
                    Helpers.ShowFinalScore(score);
                }
            }
        }

        internal void SubtractionGame(string message)
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
                result = Helpers.ValidateResult(result);

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
                    Helpers.AddToHistory(score, GameType.Subtraction);
                    Helpers.ShowFinalScore(score);
                }
            }
        }

        internal void AdditionGame(string message)
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
                result = Helpers.ValidateResult(result);

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
                    Helpers.AddToHistory(score, GameType.Addition);
                    Helpers.ShowFinalScore(score);
                }
            }

        }
    }
}
