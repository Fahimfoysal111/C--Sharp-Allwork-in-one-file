using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public abstract class Vehicle<T>
    {
        public string ModelId { get; set; }
        public int YearMake { get; set; }
        public int NumberOfSeat { get; set; }
        public int NumberOfGear { get; set; }
        public int EngineCapacitycc { get; set; }
        public int Milage { get; set; }
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
            Console.WriteLine("Front Break");
        }

    }
}
