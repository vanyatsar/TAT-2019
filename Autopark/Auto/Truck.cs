using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Truck : Auto
    {
        public Truck(Chassis chassis, Engine engine, Transmission transmission) : base(chassis, engine, transmission)
        {

        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
