using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string name);
        static AnimalFactory abstractFactory;

        public static AnimalFactory GetFactory(AnimalFactory abstractFactoryType)
        {
            if(abstractFactoryType is SeaAnimalFactory) abstractFactory=new SeaAnimalFactory();
            if(abstractFactoryType is LandAnimalFactory) abstractFactory=new LandAnimalFactory();
            if(abstractFactory is null) throw new ArgumentNullException(nameof(abstractFactory));
            return abstractFactory;
        }

    }
}
