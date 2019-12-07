using System;

namespace University
{
    public class Director : Person
    {
        public string Category { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Category;
        }
    }
}
