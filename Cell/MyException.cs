using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell
{
    public class NotCorrectInputExeption : Exception
    {
        public NotCorrectInputExeption(string message) : base(message) { }
    }
}
