using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class LandAnimalFactory: AnimalFactory
    {
        private static Animal animal;
        public override Animal GetAnimal(string animalType)
        {
            animalType = animalType.ToLower();
            if (animalType.Equals("cat"))
                animal = new Cat();
            if (animalType.Equals("dog"))
                animal = new Dog();
            if (animal == null) throw new Exception("Not a valid input");
            return animal;

        }
    }
}
