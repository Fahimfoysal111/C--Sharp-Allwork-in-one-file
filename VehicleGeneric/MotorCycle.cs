using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public sealed class MotorCycle<T>:TwoWheller<T>
    {
        public MotorCycle()
        { }
        public MotorCycle(string modelno, int yearmake, int numberofseat, int numberofgear, int milage, VehicleType type, int enginecapacitycc)
        {
            this.ModelId = modelno;
            this.YearMake = yearmake;
            this.NumberOfSeat = numberofseat;
            this.NumberOfGear = numberofgear;
            this.Milage = milage;
            this.Type = type;
            this.EngineCapacitycc = enginecapacitycc;
        }
        public int NumberOfDoor { get; set; }
        public override void StartEngine()
        {
            Console.WriteLine("MotorCycle Start Engine");
        }
        public override void RearBreak()
        {
            Console.WriteLine("Motorcycle RearBreak");
        }
        public override void FrontBreak()
        {
            Console.WriteLine("MotorCycle FrontBreak");
        }
    }
}
