using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringManager manager = new StringManager();

            manager.Testing(inputString);
            manager.DisplayResults();    
        }
    }
}
