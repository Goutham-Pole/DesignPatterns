using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.DecoraterDP;
using DesignPatterns.FactoryDP;
using DesignPatterns.Proxy;
using DesignPatterns.SingleTon;

namespace DesignPatterns
{
    internal class Program
    {
        static void GetConnection()
        {
            DBConnection.GetConnection();
        }
        static void Main(string[] args)
        {
            //singleton
            /*var instance1=DBConnection.GetConnection();
            var instance2=DBConnection.GetConnection();*/
            /*Parallel.Invoke(
                () => DBConnection.GetConnection(),
                ()=> DBConnection.GetConnection(),
                () => DBConnection.GetConnection()
            ) ;*/

            //builder
            HP hp = new HP();
            LaptopDirector director = new LaptopDirector();
            var laptop1=director.Construct(hp);
            Console.WriteLine(laptop1);

            var laptop2=director.Construct(new MacBook());
            Console.WriteLine(laptop2);

            NotificationFactory notificationFactory = new NotificationFactory();
            notificationFactory.SetNotificationType(new EmailNotification());
            notificationFactory.notifyUser();

            //abstract factory
            var abstractFactory = AnimalFactory.GetFactory(new LandAnimalFactory());
            var animal=abstractFactory.GetAnimal("cat");
            animal.MakeSound();

            //proxy
            Console.WriteLine("--proxy design pattern--");
            Internet internet = new RealInternet();
            internet.ConnectTo("www.google.com");
            //internet.ConnectTo("www.abc.com");
            internet=new ProxyInternet();
            internet.ConnectTo("www.abc.com");

            //decorator
            Console.WriteLine("---decorator---");
            Decorator decorator=new PepperoniDecorator(new ChickenDecorator(new PlainPizza()));
            Console.WriteLine(decorator.makePizza());
            

        }

    }
}
