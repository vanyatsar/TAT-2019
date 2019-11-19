using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Translit translit = new Translit();
            string testIn = "schyot";

            StringBuilder testOut = translit.GetTranslitString(testIn);

            Console.WriteLine($"Source string \'{testIn}\'");
            Console.WriteLine($"Line after transliteration \'{testOut}\'");
        }
    }
}
