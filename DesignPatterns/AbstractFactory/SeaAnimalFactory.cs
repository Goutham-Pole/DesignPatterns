using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class SeaAnimalFactory: AnimalFactory
    {
        private static Animal animal;
        public override Animal GetAnimal(string animalType)
        {
            animalType=animalType.ToLower();
            if (animalType.Equals("octopus"))
                animal = new Octopus();
            if(animalType.Equals("shark"))
                animal=new Shark();
            if (animal == null) throw new Exception("Not a valid input");
            return animal;  
         
        }
    }
}
