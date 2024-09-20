using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType_GenericApproch
{
    public  class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType Type { get; set; }
        public Gender Gendertype { get; set; }
    }
}
