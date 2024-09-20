using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType_GenericApproch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "Cow", Age = 19, Type = AnimalType.HarNibo, Gendertype = Gender.Male };
            GenericBehavior<Animal> animal = new GenericBehavior<Animal>();
            Console.WriteLine(animal.GetGenericBehaviour(cow));
            Animal bear = new Animal { Name = "Bear", Age = 30, Gendertype = Gender.Female, Type = AnimalType.Carnivo };
            TypeSpecificAnimal<Animal> BEAR = new TypeSpecificAnimal<Animal>();
            Console.WriteLine(BEAR.GetSpecificAnimal(bear));
            Console.ReadLine();
        }
    }
}
