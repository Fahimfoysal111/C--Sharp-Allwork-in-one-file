using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleObject
{
    public sealed  class MotorCycle:TwoWheller
    {
        public MotorCycle()
        { }
        public MotorCycle(string modelno, int yearmake, int numberofgear, int numberofseat, int enginecapacitycc, VehicleType type)
        {
            this.ModelNo = modelno;
            this.YearMake = yearmake;
            this.NumberOfGear = numberofgear;
            this.NumberOfSeat = numberofseat;
            this.EngineCapacityCC = enginecapacitycc;
            this.Type = type;
        }
        public int Milage { get; set; }
        public string GetModel()
        {
            return $"Model No {ModelNo}";
        }
        public string GetModel(int year)
        {
            return $"Model No:{ModelNo} Year:{year}";
        }
        public override void StartEngine()
        {
            Console.WriteLine("MotorCycle Start Engine");
        }
        public override void RearBreak()
        {
            Console.WriteLine("MotorCycle Rear Break");
        }
        public override void FrontBreak()
        {
            Console.WriteLine("MotorCycle Front Break");
        }
    }
}
