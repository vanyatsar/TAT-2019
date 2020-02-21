namespace University
{
    public class Director : Person
    {
        public string Category { get; set; }
        public Director()
        {
        }
        public Director(string firstName, string lastName, int year, string category) : base(firstName, lastName, year)
        {
            this.Category = category;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Category;
        }
    }
}
