using System;

namespace CW_18_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            const int STACK_LENGTH = 10;

            Stack<string> stack = new Stack<string>(STACK_LENGTH);
            try
            {
                Console.WriteLine(stack.Pop());
                stack.Push("1");
                stack.Push("2");
                stack.Push("1");
                stack.Push("2");
                stack.Push("1");
                stack.Push("2");
                stack.Push("1");
                Console.WriteLine(stack.Pop());
            }
            catch (OutOfStackRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
