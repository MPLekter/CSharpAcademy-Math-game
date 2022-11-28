using System;
using System.Collections.Generic;
using System.IO;
using Math_game.Models;
using Newtonsoft.Json;

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

        internal static void SaveGames() //TODO: make it save more than one in desired format.
        {
            Console.Clear();
            Console.WriteLine("Saving Games...");
            Console.WriteLine("-------------");
            #region Method 1: games -> string array -> text file
            /*
            //TODO: ask where to save
            string[] gamesAsStringArray = new string[games.Count];
            int size = 0;
            foreach (var game in games)
            {
                gamesAsStringArray[size++] = $"{game.Date} {game.Type} Score = {game.Score}"; //this means we start at gASA[0] and immediately go to gASA[1], but use it only if needed.
            }
            File.WriteAllLines("CSHARPGAME.txt", gamesAsStringArray);
            */
            #endregion
            #region Method 2: games -> dict -> streamwriter
            /*
            //TODO: DEBUG IT
            int index = 0;
            var gamesAsDictionary = new Dictionary<string, Dictionary<string, string>>();

            foreach (var game in games)
            {
                Dictionary<string, string> gameDetails = new Dictionary<string, string>()
                {
                    {"Date", game.Date.ToString()},
                    {"Type", game.Type.ToString()},
                    {"Score", game.Score.ToString()}
                };

                gamesAsDictionary.Add(index.ToString(), gameDetails);
                index++;
            }

            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in gamesAsDictionary)
            {
                string nestedKey;
                string nestedValue;
                foreach (KeyValuePair<string, string> nestedKvp in kvp.Value)
                {
                    nestedKey = nestedKvp.Key;
                    nestedValue = nestedKvp.Value;
                    File.AppendAllText("CSHARPGAME_saves.txt", $"save {kvp.Key}_contents_{nestedKey} , {nestedValue}"); //TODO: refactor a bit to print correctly, but generally works.
                }
            }

            Console.ReadLine();
            */
            #endregion
            #region Method 3: Json file
            int index = 0;
            var gamesAsDictionary = new Dictionary<string, Dictionary<string, string>>();

            foreach (var game in games)
            {
                Dictionary<string, string> gameDetails = new Dictionary<string, string>()
                {
                    {"Date", game.Date.ToString()},
                    {"Type", game.Type.ToString()},
                    {"Score", game.Score.ToString()}
                };

                gamesAsDictionary.Add(index.ToString(), gameDetails);
                index++;
            }

            string json = JsonConvert.SerializeObject(gamesAsDictionary, Formatting.Indented);
            File.AppendAllText("CSHARPGAME_saves.txt", json);
            #endregion

        }

        internal static void LoadGames() 
        {
            Console.Clear();
            Console.WriteLine("Loading Games...");
            Console.WriteLine("-------------");

            #region Retrieving data from JSON save file
            string saveDataJson = File.ReadAllText("CSHARPGAME_saves.txt");

            var gamesAsDictionary = new Dictionary<string, Dictionary<string, string>>();
            gamesAsDictionary = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(saveDataJson);

            foreach (string index in gamesAsDictionary.Keys)
            {
                var retrievedDate = gamesAsDictionary[index]["Date"];
                var retrievedScore = gamesAsDictionary[index]["Score"];
                var retrievedGameType = gamesAsDictionary[index]["Type"];
                //load to temp memory

                games.Add(new Game
                    {
                        Date = DateTime.Parse(retrievedDate),
                        Score = int.Parse(retrievedScore),
                        Type = Enum.Parse<Models.GameType>(retrievedGameType)
                    });
            }



            Console.ReadLine();
            #endregion
            #region Retrieving data from TEXT save file
            //string saveDataTxt = File.ReadAllText("CSHARPGAME.txt");

            #region Method 1
            //Method 1: cut the string based on conditions
            /*
            //DateTime.now is 19 characters long, so cut a substring
            string retrievedDate = load.Substring(0, 19);

            //GameType is between DateTime and "Score"
            string cutOne = load.Replace(retrievedDate, "").Trim();
            string retrievedGameType = cutOne.Substring(0, cutOne.IndexOf("Score")).Trim();

            //Score is located 2 characters after "="
            string retrievedScore = load.Substring(load.IndexOf("=") + 2); //TODO: FIX IT, it will not stop at for example 0, but will return 0 AND THE REST OF TEXT , E.G. ALL OTHER SAVES!
            */
            #endregion
            #region Method 2
            /*
            //Method 2: use Split and SubstringExtensions class to cut the strings and not think too much about numerical conditions
            string retrievedDate = saveDataTxt.Split(" ")[0] + " " + saveDataTxt.Split(" ")[1];
            string retrievedScore = SubstringExtensions.After(saveDataTxt, "=").Trim();
            string retrievedGameType = saveDataTxt.Split(" ")[2];

            #endregion
            Console.WriteLine(retrievedDate);
            Console.WriteLine(retrievedGameType);
            Console.WriteLine(retrievedScore);
            
            
            
            Console.ReadLine();
            */
            #endregion

            /*debug
            DateTime Date = DateTime.Parse(retrievedDate);
            GameType Type = Enum.Parse<GameType>(retrievedGameType);
            int Score = int.Parse(retrievedScore);
            */
            //load to temp memory
            /*
            games.Add(new Game
            {
                Date = DateTime.Parse(retrievedDate),
                Score = int.Parse(retrievedScore),
                Type = Enum.Parse<Models.GameType>(retrievedGameType)
            });
            */
            #endregion

            
            
        }

        internal static string ValidateResult(string result)
        {
            //validate if the answer is not null or empty. Also validate if you can parse it into an int.
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _)) //out _ means we don't expect a result.
            {
                Console.WriteLine("Your answer needs to be an integer (number)");
                result = Console.ReadLine();
            }
            return result;
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

        internal static string GetName()
        {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name) || Int32.TryParse(name, out _)) //out _ means we don't expect a result.
            {
                Console.WriteLine("Your name cannot be empty or an integer (number)");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
