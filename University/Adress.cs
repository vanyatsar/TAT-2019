namespace University
{
    public struct Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }

        public Adress (string city, string street, int house)
        {
            this.City = city;
            this.Street = street;
            this.House = house;
        }

        public override bool Equals(object obj)
        {
            Adress adress = (Adress)obj;
            return (this.City == adress.City && House == adress.House && Street == adress.Street);
        }

        public override string ToString() => City + " " + Street + " " + House;
    }
}
