using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Player
    {
        public string Name { get; set; }
        public Symbol GameSymbol { get; set; }
        public Player(string name) : this(name, Symbol.None) { }
        public Player(string name, Symbol gameItem)
        {
            Name = name;
            GameSymbol = gameItem;
        }
    }
}
