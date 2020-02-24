using System;

namespace CW_18_12_19
{
    class OutOfStackRangeException : Exception
    {
        /// <summary>
        /// My exception
        /// </summary>
        /// <param name="message">Text message of exception</param>
        public OutOfStackRangeException(string message) : base(message) { }
    }
}
