using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark
{
    public class Autopark
    {
        List<Auto> cars = new List<Auto>();

        public bool AddAuto(Auto car)
        {
            if (cars.Count == 0)
            {
                cars.Add(car);
            }
            else
            {
                foreach (Auto auto in cars)
                {
                    if (!cars.Equals(auto))
                    {
                        cars.Add(car);
                        return true;
                    }
                }     
            }
            return false;
        }
            

        public void PrintInfoCarsSpaceOfEngineMoreThan1500()
        {
            var selectedCars = cars.Where(t => t.Engine.Space > 1500);

            foreach (var s in selectedCars)
            {
                Console.WriteLine(s.ToString());
            }       
        }

        public void PrintInfoAboutEngineForAllBusesAndTrucks()
        {
            var selectedCars = cars.Where(t => t is Truck || t is Bus);

            foreach (var s in selectedCars)
            {
                Console.WriteLine(s.Engine.ToString());
            }
        }
        public void PrintInfoAboutCarsWithIdetnicalTypeTransmission()
        {
            
        }
    }
}
