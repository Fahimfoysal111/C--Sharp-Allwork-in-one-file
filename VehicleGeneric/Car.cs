using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public sealed class Car<T>:FourWheller<T>
    {
        public Car()
        { }
        public Car(string modelid, int yearmake, int numberofseat, int numberofgear, int enginecapacitycc, VehicleType type, int milage)
        {
            this.ModelId = modelid;
            this.YearMake = yearmake;
            this.NumberOfSeat = numberofseat;
            this.NumberOfGear = numberofgear;
            this.EngineCapacitycc = enginecapacitycc;
            this.Milage = milage;
            Type = type;
        }
        public int NumberofDoor { get; set; }
        public override void StartEngine()
        {
            Console.WriteLine("Car Start Engine");
        }
        public override void RearBreak()
        {
            Console.WriteLine("Car Rear Break");
        }
        public override void FrontBreak()
        {
            Console.WriteLine("Car Front Break");
        }


    }
}
