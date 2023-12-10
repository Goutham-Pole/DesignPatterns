using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class Octopus : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("octopus sound..");
        }
    }
}
