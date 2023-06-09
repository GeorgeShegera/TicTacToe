using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public Point() : this(0, 0) { }
        public Point(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }
    }
}
