using System;
using System.Collections.Generic;
using System.Linq;

namespace String
{
    public class NotRussianSymbol : Exception
    {
        public NotRussianSymbol(string message) : base(message) {}
    }
}
