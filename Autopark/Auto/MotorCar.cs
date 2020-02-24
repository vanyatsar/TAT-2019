namespace Autopark
{
    public class MotorCar : Auto
    {
        public string Name { get; private set; }
        public MotorCar(Chassis chassis, Engine engine, Transmission transmission, string name) : base (chassis, engine, transmission)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Name; 
        }
    }
}
