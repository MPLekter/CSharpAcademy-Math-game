using System;

namespace Math_game
{
    class Program
    {

        static void Main(string[] args)
        {
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

        }

        private static string GetName()
        {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();
            return name;
        }

        private static void Menu(string name)
        {
            
            var date = DateTime.UtcNow;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is such a fun thing.\n");
            Console.WriteLine($@"What game would you like to play today?
            Choose:
             A - Addition
             S - Substraction
             M - Multiplication
             D - Division
             Q - Quit the program");
            Console.WriteLine("---------------------");

            var gameSelected = Console.ReadLine();

            //.Trim() is needed to remove whitespaces from before and after input.
            switch (gameSelected.Trim().ToLower())
            {
                case "a":
                    AdditionGame("addition game start");
                    break;
                case "s":
                    SubstractionGame("sub game start");
                    break;
                case "m":
                    MultiplyGame("multi game start");
                    break;
                case "d":
                    DivisionGame("division game start");
                    break;
                case "q":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("invalid input, try again");
                    Console.ReadLine();
                    break;
            }
        }

        private static void DivisionGame(string message)
        {
            throw new NotImplementedException();
        }

        private static void MultiplyGame(string message)
        {
            throw new NotImplementedException();
        }

        private static void SubstractionGame(string message)
        {
            throw new NotImplementedException();
        }

        private static void AdditionGame(string message)
        {
            var random = new Random(); //random integer
            var score = 0;

            int firstNumber;
            int secondNumber;

            for(int i = 0; i < 5; i++)
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

                if (i ==4) { Console.WriteLine($"Game over. Your final score is {score}"); }
            }
        }
    }
}
