using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Laptop
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }
        public List<string> Peripherals { get; set; }


        public override string ToString()
        {
            string peripherals = string.Join(", ", Peripherals);
            return $"CPU: {CPU},RAM: {RAM}, Storage: {Storage},Graphics Card: {GraphicsCard},Peripherals: {peripherals}";
        }
    }
}
