using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType_GenericApproch
{
    public  class GenericBehavior<T>:IGenericBehavior<T>
    {
        public string GetGenericBehaviour(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal A = obj as Animal;
                switch (A.Type)
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

            }
            else 
            {
                behavior = "Not An Animal";
            }
            return behavior;
        }

    }
}
