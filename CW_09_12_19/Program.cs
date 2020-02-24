using System;

namespace CW_09_12_19
{
    /// <summary>
    /// Entry point class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main(string[] args)
        {
            MyList<object> myList = new MyList<object>();
            myList.AddTail('f');
            myList.AddHead(5);
            myList.AddHead(7);
            myList.AddTail(82);
            myList.AddHead(1);
            myList.AddHead("Hello");

            Console.WriteLine(myList.ToString());
            
            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString()); 
            }
            
        }
    }
}
