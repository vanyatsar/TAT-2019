using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Cell
    {
        char column;
        int row;

        public Cell(char column, int row)
        {
            if ((column >= 'A' && column <= 'H') && (row <= 8 && row >= 1))
            {
                this.column = column;
                this.row = row;
            }
            else
                throw new NotCorrectInputException("Input your cell again!");
        }
    }
}
