namespace University
{
    class Autopark : Department
    {
        public Owner Owner { get; set; }

        public override string ToString() => base.ToString() + " " + Owner.ToString();

    }
}
