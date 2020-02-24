namespace Autopark
{
    public struct Engine
    {
        public double Power { get; private set; }
        public double Space { get; private set; }
        public int SerialNumber { get; private set; }

        public Engine(double power, double space, int serialNumber)
        {
            this.Power = power;
            this.Space = space;
            this.SerialNumber = serialNumber;
        }
        public override bool Equals(object obj)
        {
            Engine engine = (Engine)obj;
            return (this.Power == engine.Power && Space == engine.Space && this.SerialNumber == engine.SerialNumber);
        }

        public override string ToString() => Power + " " + Space + " " + SerialNumber;
    }
}
