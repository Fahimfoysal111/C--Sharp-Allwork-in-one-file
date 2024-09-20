using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleGeneric;

namespace VehicleGeneric
{
    public  class TwoWheller<T>:Vehicle<T>,ITwoWheller<T>
    {
        public string EnteriorDesign(T data)
        {
            return "This is Enterior";
        }
    }
}
