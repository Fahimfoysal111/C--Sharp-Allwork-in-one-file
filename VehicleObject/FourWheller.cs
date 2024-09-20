using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleObject
{
    public  class FourWheller:Vehicle,IFourWheller
    {
        public string EnteriorDesign()
        {
            return "This is EnteriorDesign";
        }
    }
}
