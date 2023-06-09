using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Cell
    {
        public Symbol symbol;        
        public Cell() => symbol = new Symbol();
    }
}
