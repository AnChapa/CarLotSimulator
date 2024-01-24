using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public int Year;
        public string Make;
        public string Model;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Model}'s {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Model} made a {HonkNoise}");
        }

        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrive)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrive;
        }
    }
}
