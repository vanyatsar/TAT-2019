using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Cell
    {
        public char Column { get; private set; }
        public int Row { get; private set; }

        public Cell(char column, int row)
        {
            if ((column >= 'A' && column <= 'H') && (row <= 8 && row >= 1))
            {
                this.Column = column;
                this.Row = row;
            }
            else
                throw new NotCorrectInputException("Input your cell again!");
        }
    }
}
