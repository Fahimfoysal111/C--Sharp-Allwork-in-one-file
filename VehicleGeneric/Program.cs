using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car<string> car = new Car<string>("BMW", 2021, 2, 2, 2121, VehicleType.Car, 1212);
            Console.WriteLine($"Car Model {car.ModelId}");
            Console.WriteLine($"Car YearMake {car.YearMake}");
            Console.WriteLine($"Car NumberOfDoor {car.NumberofDoor=2}");
            Console.WriteLine($"Car Gear {car.NumberOfGear}");
            Console.WriteLine($"Car Seat {car.NumberOfSeat}");
            Console.WriteLine($"Car Milage {car.Milage}");
            car.StartEngine();
            car.RearBreak();
            car.FrontBreak();
            MotorCycle<string> motorcycle = new MotorCycle<string>("BMW", 2021, 2, 2, 2121, VehicleType.Car, 1212);
            Console.WriteLine($"motocycle Model {motorcycle.ModelId}");
            Console.WriteLine($"motocycle YearMake {motorcycle.YearMake}");
            Console.WriteLine($"motocycle Gear {motorcycle.NumberOfGear}");
            Console.WriteLine($"motocycle Seat {motorcycle.NumberOfSeat}");
            Console.WriteLine($"motocycle Milage {motorcycle.Milage}");
            motorcycle.StartEngine();
            motorcycle.RearBreak();
            motorcycle.FrontBreak();
            Console.ReadLine();

        }
    }
}
