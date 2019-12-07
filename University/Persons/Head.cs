using System;

namespace University
{
    public class Head : Person
    {
        public string Rank { get; set; }
   
        public override string ToString()
        {
            return base.ToString() + " " + Rank;
        }
    }
}
