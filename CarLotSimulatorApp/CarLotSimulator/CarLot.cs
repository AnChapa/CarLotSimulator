using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        List<Car> carsInLot{get; set;}
        public static int numberOfCars;

        public void AddCar(Car car)
        {
            carsInLot.Add(car);
        }

        public void DisplayInfo()
        {
            foreach (Car car in carsInLot)
            {
                Console.WriteLine($"We have a {car.Year} {car.Make} {car.Model}! Let me start it up for you.");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.Write("\n");
            }
            Console.WriteLine("Thats all the cars we have for now!");
        }
        public static void NumberOfCars()
        {
            Console.WriteLine($"The number of cars in the lot is: {numberOfCars}\n");
        }
        public CarLot()
        {
            carsInLot = new List<Car>();
        }
    }
}
