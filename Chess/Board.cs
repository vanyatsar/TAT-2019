using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class Board
    {
        public bool IsOnLine(Cell firstCoordinate, Cell secondCoordinate) => (int)firstCoordinate.Column == (int)secondCoordinate.Column;

        public void ColorDefinition(Cell coordinate)
        {
            if (((int)coordinate.Column + (int)coordinate.Row) % 2 == 0)
            {
                Console.WriteLine("White");
            }
            else
            {
                Console.WriteLine("Black");
            }
        }
    }
}
