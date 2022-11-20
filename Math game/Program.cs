using System;

namespace Math_game
{
    class Program
    {

        static void Main(string[] args)
        {
            int index = 1;
            string name = "Pablo";
            char initial = 'P';
            int year = 2022;
            double onethreethree = 1.33d;
            bool loveToCode = true;

            Console.WriteLine("These are the datatypes:\n");
            Console.WriteLine($"{index++} -string, example: {name}");
            Console.WriteLine($"{index++} -int, example: {year}");
            Console.WriteLine($"{index++} -bool, example: {loveToCode}");
            Console.WriteLine($"{index++} -char, example: {initial}");
            Console.WriteLine($"{index++} -double, example: {onethreethree}");
            Console.ReadLine();
        }
    }
}
