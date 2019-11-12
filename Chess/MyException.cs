using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class NotCorrectInputException : Exception
    {
        public NotCorrectInputException(string message) : base(message) { }
    }
}
