using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public  interface IFourWheller<T>
    {
        string ExteriorDesign<T>(T data) where T : Vehicle<T>;
    }
}
