namespace Autopark
{
    public class Bus : Auto
    {
        public int NumberOfPassengers { get; private set; }
        public Bus(Chassis chassis, Engine engine, Transmission transmission, int numberOfPassengers) : base(chassis, engine, transmission)
        {
            this.NumberOfPassengers = numberOfPassengers;
        }

        public override string ToString()
        {
            return base.ToString() + " " + NumberOfPassengers;
        }
    }
}
