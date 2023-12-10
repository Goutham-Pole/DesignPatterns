using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class LaptopDirector
    {
        public Laptop Construct(IBuilder builder)
        {
            builder.CreateLaptop();
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildGraphicsCard();
            builder.BuildPeripherals();
            return builder.GetLaptop();
        }
    }
}
