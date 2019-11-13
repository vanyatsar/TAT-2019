using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class Board
    {
        public bool IsOnLine(Cell firstCell, Cell secondCell)
        {
            if ((int)firstCell.Column == (int)secondCell.Column || (int)firstCell.Row == (int)secondCell.Row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOnDiagonal(Cell firstCell, Cell secondCell)
        {
            if (((int)firstCell.Column + (int)firstCell.Row) == ((int)secondCell.Column + (int)secondCell.Row) ||
                ((int)firstCell.Column - (int)firstCell.Row) == ((int)secondCell.Column - (int)secondCell.Row))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ColorCellDefinition(Cell cell)
        {
            if (((int)cell.Column + (int)cell.Row) % 2 == 0)
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
