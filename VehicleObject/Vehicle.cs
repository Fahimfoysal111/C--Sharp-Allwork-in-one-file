using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleObject
{
    public abstract  class Vehicle
    {
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int NumberOfSeat { get; set; }
        public int NumberOfGear { get; set; }
        public int EngineCapacityCC { get; set; }
        public VehicleType Type { get; set; }
        public virtual void StartEngine()
        {
            Console.WriteLine("Start Engine");
        }
        public virtual void RearBreak()
        {
            Console.WriteLine("Rear Break");

        }
        public virtual void FrontBreak()
        {
            Console.WriteLine("Rear Break");
        }
    }
}
