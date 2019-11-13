using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class Board
    {
        public bool IsOnLine(Cell firstCoordinate, Cell secondCoordinate)
        {
            if ((int)firstCoordinate.Column == (int)secondCoordinate.Column || (int)firstCoordinate.Row == (int)secondCoordinate.Row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ColorDefinition(Cell coordinate)
        {
            if (((int)coordinate.Column + (int)coordinate.Row) % 2 == 0)
            {
                Console.WriteLine("Black");
            }
            else
            {
                Console.WriteLine("White");
            }
        }
    }
}
