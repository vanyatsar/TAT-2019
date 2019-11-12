using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input word: ");
            string name = Console.ReadLine();

            int count = 1;
            int maxCount = 0;
            int length = name.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (name[i] == name[i + 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine($"Answer: {maxCount}");
        }
    }
}
