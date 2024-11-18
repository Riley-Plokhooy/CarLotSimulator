﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            var carLotOne = new CarLot();
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carOne = new Car();
            carOne.Make = "Porsche";
            carOne.Model = "911";
            carOne.Year = 2020;
            carOne.IsDrivable = true;
            carOne.MakeEngineNoise("Neerom");
            carOne.MakeHonkNoise("Beep");

            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Sedan",
                Model = "Volkswagen",
                Year = 2022,
                IsDrivable = true,
            };

            carTwo.MakeEngineNoise("Vroom");
            carTwo.MakeHonkNoise("Beep Beep");

            carLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car("Subaru", "Hatchback", 2024, true);


            carThree.MakeEngineNoise("Nneow");
            carThree.MakeHonkNoise("bebeep beep");

            carLotOne.ParkingLot.Add(carThree);
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotOne.CheckCars();
        }
    }
}
