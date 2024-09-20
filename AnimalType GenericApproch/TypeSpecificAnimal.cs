using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType_GenericApproch
{
    public  class TypeSpecificAnimal<T>:ITypeSpecificAnimal<T>
    {
        public string GetSpecificAnimal<T>(T obj) where T : Animal
        {
            string behavior = string.Empty;
            switch (obj.Type)
            {
                case AnimalType.HarNibo:
                    behavior = "Two feet";
                    break;
                case AnimalType.Ornivo:
                    behavior = "Meat Eat";
                    break;
                case AnimalType.Carnivo:
                    behavior = "Adaptable";
                    break;
                default:
                    behavior = "Not Found Any Animal";
                    break;
            }
            return behavior;
        }

    }
}
