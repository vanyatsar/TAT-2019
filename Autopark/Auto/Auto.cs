namespace Autopark
{
    public abstract class Auto
    {
        public Chassis Chassis { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public Auto(Chassis chassis, Engine engine, Transmission transmission)
        {
            this.Chassis = chassis;
            this.Engine = engine;
            this.Transmission = transmission;
        }

        public override string ToString()
        {
            return Chassis.ToString() + " " + Engine.ToString() + " " + Transmission.ToString() ;
        }

        public override bool Equals(object obj)
        {
            Auto auto = obj as Auto;
            return (Chassis.Equals(auto.Chassis) && Engine.Equals(auto.Engine) && Transmission.Equals(auto.Transmission));
        }
    }
}
