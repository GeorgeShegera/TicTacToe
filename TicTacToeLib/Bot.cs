using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Bot
    {
        public Symbol symbol;

        private readonly List<Point> defaultPoints;

        public Bot(Symbol gameItem)
        {
            symbol = gameItem;
            defaultPoints = new List<Point>
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 2),
                new Point(2, 0),
                new Point(0, 2),
            };
        }
        public Point SelectPoint(Field field)
        {
            Random rnd = new Random();
            Point point = new Point();
            if (field.IsClear) return defaultPoints[rnd.Next(0, defaultPoints.Count)];
            else if (CheckVictory(symbol)) return point;
            else if (CheckVictory(symbol == Symbol.X ? Symbol.O : Symbol.X)) return point;
            else if (CheckProbableVictory(symbol)) return point;
            else return field.RandomFreeCell();

            bool CheckVictory(Symbol symbol)
            {
                bool victory = false;
                for (int i = 0; i < field.GetLength(); i++)
                {
                    for (int j = 0; j < field.GetLength(); j++)
                    {
                        Point curPoint = new Point(j, i);
                        if (field.FreeCell(curPoint))
                        {
                            field[curPoint].symbol = symbol;
                            victory = Field.CheckVictory(field, symbol);
                            field[curPoint].symbol = Symbol.None;
                            if (victory)
                            {
                                point = curPoint;
                                return victory;
                            }
                        }
                    }
                }
                return victory;
            }

            bool CheckProbableVictory(Symbol symbol)
            {
                bool probableVict = false;
                for (int i = 0; i < field.GetLength(); i++)
                {
                    for (int j = 0; j < field.GetLength(); j++)
                    {
                        Point curPoint = new Point(j, i);
                        if (field.FreeCell(curPoint))
                        {
                            field[curPoint].symbol = symbol;
                            probableVict = CheckVictory(symbol);
                            field[curPoint].symbol = Symbol.None;
                            if (probableVict)
                            {
                                point = curPoint;
                                return probableVict;
                            }
                        }
                    }
                }
                return probableVict;
            }
        }
    }
}
