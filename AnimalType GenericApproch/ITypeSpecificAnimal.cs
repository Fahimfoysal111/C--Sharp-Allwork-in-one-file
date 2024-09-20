using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType_GenericApproch
{
    public  interface ITypeSpecificAnimal<T>
    {
        string GetSpecificAnimal<T>(T obj) where T : Animal;
    }
}
