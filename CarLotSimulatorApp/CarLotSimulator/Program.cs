using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            CarLot carSale = new CarLot();

            Car car1 = new Car();
            car1.Year = 2005;
            car1.Make = "Ford";
            car1.Model = "Mustang"; 
            car1.EngineNoise = "V8 engine ROARS with a deep rrrumble";
            car1.HonkNoise = "BOLD and AUTHORITATIVE HONK";
            car1.IsDriveable = true;
            carSale.AddCar(car1);
            CarLot.NumberOfCars();

            Car car2 = new Car() { Year = 1998, Make = "Toyota", Model = "Camry", EngineNoise = "smooooth and quiet inline - 4 engine HUMS", HonkNoise = "polite and moderate HONK",  IsDriveable = true };
            carSale.AddCar(car2);
            CarLot.NumberOfCars();

            Car car3 = new Car(2002, "BMW", "3 Series", "inline-6 engine produces a sporty and distinctive GROWL", "elegant and slightly assertive HONK", true);
            carSale.AddCar(car3);
            CarLot.NumberOfCars();

            carSale.DisplayInfo();
            

        }
    }
}
