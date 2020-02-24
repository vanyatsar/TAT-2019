using System.Collections.Generic;

namespace CW_18_12_19
{
    class Stack<T>
    {
        private T Head { get; set; }
        private List<T> MyStack { get; set; }
        private int StackLength { get; set; }

        /// <summary>
        /// Stack constructor
        /// </summary>
        /// <param name="length">Stack length</param>
        public Stack(int length)
        {
            StackLength = length;
            MyStack = new List<T>(length);
        }

        /// <summary>
        /// Add value to stack
        /// </summary>
        /// <param name="value">Value which you need to ad in stack</param>
        public void Push(T value)
        {
            Head = value;
            if (MyStack.Count == StackLength)
            {
                throw new OutOfStackRangeException("Out of range!");
            }
            MyStack.Insert(0, value);
        }

        /// <summary>
        /// Return and delete last added value from stack
        /// </summary>
        /// <returns>Last added value</returns>
        public T Pop()
        {
            if (MyStack.Count != 0)
            {
                MyStack.RemoveAt(0);
            }
            return Head;
        }
    }
}
