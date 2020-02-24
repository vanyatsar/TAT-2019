namespace Autopark
{
    public struct Transmission
    {
        public string Type { get; private set; }
        public int NumberOfGears { get; private set; }
        public string Manufacturer { get; private set; }
        public Transmission(string type, string manufacturer, int numberOfGears)
        {
            this.Type = type;
            this.Manufacturer = manufacturer;
            this.NumberOfGears = numberOfGears;
        }

        public override string ToString() => Type + " " + NumberOfGears + " " + Manufacturer; 

        public override bool Equals(object obj)
        {
            Transmission transmission = (Transmission)obj;
            return (this.Type == transmission.Type &&
                    this.NumberOfGears == transmission.NumberOfGears &&
                    this.Manufacturer == transmission.Manufacturer);
        }
    }
}
