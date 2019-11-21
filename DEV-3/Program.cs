using System;

namespace DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Translit translit = new Translit();
            string testIn = "schyotпри";

            string testOut = translit.GetTranslitString(testIn);

            Console.WriteLine($"Source string \'{testIn}\'");
            Console.WriteLine($"Line after transliteration \'{testOut}\'");
        }
    }
}
