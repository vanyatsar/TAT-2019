namespace Autopark
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorCar motorCar = new MotorCar(new Chassis(4, 102, 10.1), 
                                             new Engine(1200, 1600, 5454),
                                             new Transmission("A", "Russia", 5), "Audi");


            Autopark autopark = new Autopark();
            autopark.AddAuto(motorCar);
            autopark.AddAuto(motorCar);
            autopark.AddAuto(new Truck(new Chassis(4, 102, 10.1),
                                       new Engine(1200, 10, 5454),
                                       new Transmission("A", "Russia", 5)));
            autopark.AddAuto(new Bus(new Chassis(4, 102, 10.1),
                                       new Engine(1200, 1600, 5454),
                                       new Transmission("A", "Russia", 5), 25));

            autopark.PrintInfoCarsSpaceOfEngineMoreThan1500();
            autopark.PrintInfoAboutEngineForAllBusesAndTrucks();
            autopark.PrintInfoAboutCarsWithIdetnicalTypeTransmission();
        }
    }
}
