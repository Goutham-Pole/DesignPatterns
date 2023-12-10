using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class HP : IBuilder
    {
        public override void BuildCPU()
        {
            GetLaptop().CPU = "Intel Core i7";
        }

        public override void BuildGraphicsCard()
        {
            GetLaptop().GraphicsCard = "NVIDIA GeForce RTX 3070";
        }

        public override void BuildPeripherals()
        {
            if(GetLaptop().Peripherals==null)
                GetLaptop().Peripherals=new List<string>();
            GetLaptop().Peripherals.AddRange(new string[] { "Keyboard", "Mouse", "Monitor" });
            /*GetLaptop().Peripherals.Add(peripharal1);
            int i=0;
            while(i<peripherals.Length)
            {
                GetLaptop().Peripherals.Add(peripherals[i]);
                ++i;
            }*/



        }
        public override void BuildRAM()
        {
            GetLaptop().RAM = "16 GB";
        }

        public override void BuildStorage()
        {
            GetLaptop().Storage = "512 GB SSD";
        }
    }
}
