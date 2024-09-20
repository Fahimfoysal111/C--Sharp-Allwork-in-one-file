using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleObject
{
    public class TwoWheller:Vehicle,ITwoWheller
    {
        public string ExteriorDesign()
        {
            return "This is ExteriorDesign";
        }
    }
}
