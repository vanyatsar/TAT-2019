using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class Board
    {
        public bool IsOnVerticalLine(Cell firstCell, Cell secondCell) => firstCell.Column == secondCell.Column;

        public bool IsOnHorizontalLine(Cell firstCell, Cell secondCell) => firstCell.Row == secondCell.Row;

        public bool IsOnDiagonalLine(Cell firstCell, Cell secondCell) => Math.Abs(firstCell.Column - secondCell.Column) == Math.Abs(firstCell.Row - secondCell.Row);

        public string ColorCellDefinition(Cell cell)
        {
            if ((cell.Column + cell.Row) % 2 == 0)
            {
                return "Black";
            }
            else
            {
                return "White";
            }
        }
    }
}
