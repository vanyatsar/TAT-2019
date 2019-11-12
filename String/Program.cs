using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                const string symbols = ",.:; !?";
                string word = Console.ReadLine();
                String myWord = new String(word);

                try
                {
                    myWord.CheckRussianSymdols();
                    Console.WriteLine(word.VowelsCount());
                    Console.WriteLine(word.ConsonantsCount());
                    Console.WriteLine(word.ReverseString());
                }
                catch (NotRussianSymbol exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }             
        }
    }
}
