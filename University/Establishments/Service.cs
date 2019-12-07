using System;

namespace University
{
    public class Service : Department
    {
        public Head Head { get; set; }

        public override string ToString()
        {
            return base.ToString() + Head.ToString();
        }
    }
}
