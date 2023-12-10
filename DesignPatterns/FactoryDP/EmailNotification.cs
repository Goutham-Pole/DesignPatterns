using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDP
{
    internal class EmailNotification : INotification
    {
        public void SendMessage()
        {
            Console.WriteLine("This is email notification");
        }
    }
}
