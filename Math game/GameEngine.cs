using System;

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
                    Helpers.AddToHistory(score, "Division");
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
                    Helpers.AddToHistory(score, "Multiply");
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
                    Helpers.AddToHistory(score, "Subtraction");
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
                    Helpers.AddToHistory(score, "Addition");
                    Helpers.ShowFinalScore(score);
                }
            }

        }
    }
}
