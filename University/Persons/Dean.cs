using System;

namespace University
{
    [Serializable]
    public class Dean : Person
    {
        public string Degree { get; set; }

        public Dean() { }

        public Dean(string firstName, string lastName, int year, string degree) : base (firstName, lastName, year)
        {
            this.Degree = degree;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Degree;
        }
    }
}
