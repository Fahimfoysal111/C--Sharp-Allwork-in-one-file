using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 2020, 2, 4, 1200, VehicleType.Car);
            Console.WriteLine($"Car Model {car.ModelNo}");
            Console.WriteLine($"Car Yearmake {car.YearMake}");
            Console.WriteLine($"Number Of Seat Car {car.NumberOfSeat}");
            Console.WriteLine($"Number of Gear Car { car.NumberOfGear}");
            Console.WriteLine($"Car EngineCapacitycc {car.EngineCapacityCC}");
            Console.WriteLine($"VehivcleType {car.Type}");
            Console.WriteLine($"Car Milage {car.Milage=2}");
            Console.WriteLine($"Car Number Of Door {car.NumberOfDoor=2}");
            car.EnteriorDesign();
            car.RearBreak();
            car.FrontBreak();
            car.StartEngine();
            MotorCycle motorcycle = new MotorCycle("R1 15", 2024, 2, 2, 3213, VehicleType.MotorCycle);
            Console.WriteLine($"MotorCycle Model {motorcycle.ModelNo}");
            Console.WriteLine($"MotorCycle Yearmake {motorcycle.YearMake}");
            Console.WriteLine($"Number Of Seat Car {motorcycle.NumberOfSeat}");
            Console.WriteLine($"Number of Gear MotorCycle {motorcycle.NumberOfGear}");
            Console.WriteLine($"MotorCycle EngineCapacitycc {motorcycle.EngineCapacityCC}");
            Console.WriteLine($"VehivcleType {motorcycle.Type}");
            Console.WriteLine($"MotorCycle Milage {motorcycle.Milage = 2}");
            motorcycle.ExteriorDesign();
            motorcycle.StartEngine();
            motorcycle.RearBreak();
            motorcycle.FrontBreak();
            Console.ReadLine();
        }
    }
}
