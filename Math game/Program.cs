﻿using System;

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

            //by using $@ in string, you can make bigger chunks of info in multiple lines without using multiple statements. Useful.
            string myParagraph = $@"These are the datatypes: 
            {index++} -string, example: {name}
            {index++} -int, example: {year}
            {index++} -bool, example: {loveToCode}
            {index++} -char, example: {initial}
            {index++} -double, example: {onethreethree}";

            //works the same as below
            /*
            Console.WriteLine("These are the datatypes:\n");
            Console.WriteLine($"{index++} -string, example: {name}");
            Console.WriteLine($"{index++} -int, example: {year}");
            Console.WriteLine($"{index++} -bool, example: {loveToCode}");
            Console.WriteLine($"{index++} -char, example: {initial}");
            Console.WriteLine($"{index++} -double, example: {onethreethree}");
            */
            Console.WriteLine(myParagraph);
            Console.ReadLine();
        }
    }
}
