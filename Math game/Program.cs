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

            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();
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
            if (gameSelected.Trim() == "a" || gameSelected.Trim() == "A") 
            { AdditionGame("addition game start"); }
            else if (gameSelected.Trim() == "s" || gameSelected.Trim().Trim() == "S")
            { SubstractionGame("sub game start"); }
            else if (gameSelected.Trim() == "m" || gameSelected.Trim() == "M")
            { MultiplyGame("multi game start"); }
            else if (gameSelected.Trim() == "D" || gameSelected.Trim() == "D")
            { DivisionGame("division game start"); }
            else if (gameSelected.Trim() == "q" || gameSelected.Trim() == "Q")
            { Environment.Exit(1); }
            else
            { 
                Console.WriteLine("invalid input, try again");
                Console.ReadLine();
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
            throw new NotImplementedException();
        }
    }
}
