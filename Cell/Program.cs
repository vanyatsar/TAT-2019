using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input your cell:");
                char column = char.Parse(Console.ReadLine().ToUpper());
                int row = int.Parse(Console.ReadLine());

                try
                {
                    Cell cell = new Cell(column, row);
                    break;
                }
                catch (NotCorrectInputExeption exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
