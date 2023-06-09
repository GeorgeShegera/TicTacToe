using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Field
    {
        private List<List<Cell>> Cells { get; set; }
        public bool IsClear { get; set; }
        public Field() 
        {
            Cells = new List<List<Cell>>
            {
                new List<Cell>(){ new Cell(), new Cell(), new Cell() },
                new List<Cell>(){ new Cell(), new Cell(), new Cell() },
                new List<Cell>(){ new Cell(), new Cell(), new Cell() }
            };
            IsClear = true;
        }
        public bool FreeCell(Point point) => Cells[point.CoordY][point.CoordX].symbol == Symbol.None;
        public int GetLength() => Cells.Count;
        public bool IsFull()
        {
            foreach(List<Cell> cells in Cells)
            {
                foreach(Cell cell in cells)
                {
                    if(cell.symbol == Symbol.None) return false;
                }
            }
            return true;
        }

        public Point RandomFreeCell()
        {
            List<Point> freeCells = new List<Point>();
            for(int i = 0; i < Cells.Count; i++)
            {
                for(int j = 0; j < Cells[i].Count; j++)
                {
                    if (Cells[i][j].symbol == Symbol.None) freeCells.Add(new Point(j, i));
                }
            }
            return freeCells[new Random().Next(0, freeCells.Count)];
        }

        public static bool CheckVictory(Field field, Symbol symbol)
        {
            for (int i = 0; i < field.GetLength(); i++)
            {
                if ((field[0, i].symbol == symbol &&
                   field[1, i].symbol == symbol &&
                   field[2, i].symbol == symbol) ||
                   (field[i, 0].symbol == symbol &&
                   field[i, 1].symbol == symbol &&
                   field[i, 2].symbol == symbol)) return true;
            }
            if (field[0, 0].symbol == symbol &&
               field[1, 1].symbol == symbol &&
               field[2, 2].symbol == symbol) return true;
            if (field[2, 0].symbol == symbol &&
               field[1, 1].symbol == symbol &&
               field[0, 2].symbol == symbol) return true;
            return false;
        }
        public static bool CheckDraw(Field field) => field.IsFull();

        public Cell this[Point point]
        {
            get 
            {
                return Cells[point.CoordY][point.CoordX];
            }
            set
            {
                Cells[point.CoordY][point.CoordX] = value;
            }
        }
        public Cell this[int coordY, int coordX]
        {
            get
            {
                return Cells[coordY][coordX];
            }
            set
            {
                Cells[coordY][coordX] = value;
            }
        }
    }
}
