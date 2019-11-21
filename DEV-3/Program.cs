using System;

namespace DEV_3
{
    /// <summary>
    /// Entry point class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Translit translit = new Translit();
            string testIn = "ghbdtn ";

            string testOut = translit.GetTranslitString(testIn);

            Console.WriteLine($"Source string \'{testIn}\'");
            Console.WriteLine($"Line after transliteration \'{testOut}\'");
        }
    }
}
