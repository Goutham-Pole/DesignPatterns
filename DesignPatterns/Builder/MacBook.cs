using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class MacBook : IBuilder
    {
        public override void BuildCPU()
        {
            GetLaptop().CPU = "Intel Core i7";
        }

        public override void BuildGraphicsCard()
        {
            GetLaptop().GraphicsCard = "AMD Radeon RX 6800 XT";
        }

        public override void BuildPeripherals()
        {
            if (GetLaptop().Peripherals == null)
                GetLaptop().Peripherals = new List<string>();
            GetLaptop().Peripherals.AddRange(new string[] { "Keyboard", "Mouse" });
            /*GetLaptop().Peripherals.Add(peripharal1);
            int i = 0;
            while (i < peripherals.Length)
            {
                GetLaptop().Peripherals.Add(peripherals[i]);
                ++i;
            }*/



        }
        public override void BuildRAM()
        {
            GetLaptop().RAM = "32 GB";
        }

        public override void BuildStorage()
        {
            GetLaptop().Storage = "4 TB";
        }
    }
}
