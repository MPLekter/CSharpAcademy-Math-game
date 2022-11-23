using System;
using System.Collections.Generic;
using System.Text;

namespace Math_game.Models
{
    internal class Game
    {
        #region properties
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public GameType Type { get; set; }
        #endregion
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
           

}
