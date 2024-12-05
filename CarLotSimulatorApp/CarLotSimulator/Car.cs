using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    //this line is cursed apparently
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }


    public void MakeEngineNoise(string enginenoise)
    {
        EngineNoise = enginenoise;
        Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}.");
    }

    public void MakeHonkNoise(string honknoise)
    {
        HonkNoise = honknoise;
        Console.WriteLine($"{Make} {Model} has a honk noise that sounds like {HonkNoise}.");
    }

    public Car()
    {
        CarLot._numberOfCars++;
    }

    public Car(string make, string model, int year, bool isDrivable)
    {
        CarLot._numberOfCars++;
        Make = make;
        Model = model;
        Year = year;
        IsDrivable = isDrivable;
    }

}

