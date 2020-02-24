namespace Autopark
{
    public class Scooter : Auto
    {
        public double MaxSpeed { get; private set; }

        public Scooter(Chassis chassis, Engine engine, Transmission transmission, double maxSpeed) : base(chassis, engine, transmission)
        {
            this.MaxSpeed = maxSpeed;
        }

        public override string ToString()
        {
            return base.ToString() + " " + MaxSpeed;
        }
    }
}
