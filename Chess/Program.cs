using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Board board = new Board();

                Console.WriteLine("Input first figure:");
                char column = char.Parse(Console.ReadLine().ToUpper());
                int row = int.Parse(Console.ReadLine());

                Console.WriteLine("Input second figure:");
                char column2 = char.Parse(Console.ReadLine().ToUpper());
                int row2 = int.Parse(Console.ReadLine());    

                try
                {
                    Cell cell = new Cell(column, row);
                    Cell cell2 = new Cell(column2, row2);

                    Console.WriteLine($"Is two figures on diagonal? {board.IsOnDiagonalLine(cell, cell2)}");
                    Console.WriteLine($"Is two figures on vertical? {board.IsOnVerticalLine(cell, cell2)}");
                    Console.WriteLine($"Is two figures on horizontal? {board.IsOnHorizontalLine(cell, cell2)}");

                    Console.WriteLine($"First figure color: {board.ColorCellDefinition(cell)}");
                    Console.WriteLine($"Second figure color: {board.ColorCellDefinition(cell2)}");

                    break;
                }
                catch (NotCorrectInputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
