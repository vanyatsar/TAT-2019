using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public struct Chassis
    {
        public int NumberOfWheels { get; private set; }
        public int SerialNumber { get; private set; }
        public double PermissibleLoad { get; private set; }

        public Chassis(int numberOfWheels, int serialNumber, double permissionLoad)
        {
            this.NumberOfWheels = numberOfWheels;
            this.SerialNumber = serialNumber;
            this.PermissibleLoad = permissionLoad;
        }

        public override string ToString() => NumberOfWheels + " " + SerialNumber + " " + PermissibleLoad;

        public override bool Equals(object obj)
        {
            Chassis chassis = (Chassis)obj;
            return (this.NumberOfWheels == chassis.NumberOfWheels &&
                    this.SerialNumber == chassis.SerialNumber && 
                    this.PermissibleLoad == chassis.PermissibleLoad);
        }
    }
}
