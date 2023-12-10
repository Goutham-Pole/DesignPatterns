using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public abstract class IBuilder
    {
        Laptop laptop;
        public void CreateLaptop()
        {
            laptop = new Laptop();
        }
        public Laptop GetLaptop() {
            return laptop; 
        }
        public abstract void BuildCPU();
        public abstract void BuildRAM();
        public abstract void BuildStorage();
        public abstract void BuildGraphicsCard();
        public abstract void BuildPeripherals();
        
    }
}
