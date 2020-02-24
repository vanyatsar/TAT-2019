namespace Autopark
{
    public class Truck : Auto
    {
        public double Weight { get; private set; }

        public Truck(Chassis chassis, Engine engine, Transmission transmission, double weight) : base(chassis, engine, transmission)
        {
            this.Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Weight; 
        }
    }
}
