using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGeneric
{
    public  interface ITwoWheller<T>
    {
        string EnteriorDesign(T data);
        
    }
}
