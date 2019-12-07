using System;

namespace University
{
    public class Institute : Department
    {
        public Director Director { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Director.ToString();
        }
    }
}
