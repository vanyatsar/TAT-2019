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
            try
            {
                Translit translit = new Translit();
                Console.WriteLine(translit.GetTranslitString(Console.ReadLine()));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }   
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
