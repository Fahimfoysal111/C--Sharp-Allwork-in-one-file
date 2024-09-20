using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public class FourWheller<T> : Vehicle<T>, IFourWheller<T>
    {
        public string ExteriorDesign<T>(T data)where T: Vehicle<T>
        {
            return "This is Exterior Design";
        }
        
    }
}

