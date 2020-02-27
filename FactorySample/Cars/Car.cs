using System;

namespace FactorySample.Cars
{
    class Car
    {
        protected string Name = "";
        protected string Engine = "Diesel";
        protected string PaintColor = "White";
        protected string Wheels = "16 inch";
        protected string Body = "Caravan";
        public void Configure()
        {
            Console.WriteLine($"Configuring {Name}");
            Console.WriteLine($"Engine is: {Engine}");
            Console.WriteLine($"Body is: {Body}");
            Console.WriteLine($"Paint color: {PaintColor}");
            Console.WriteLine($"Whils are {Wheels}");
        }
        public void AssembleBody()
        {
            Console.WriteLine("Body is assembled");

        }
        public void InstallEngine()
        {
            Console.WriteLine("Engine is in its place");
            
        }
        public void Paint()
        {
            Console.WriteLine("Car is painted");

        }
        public void InstallWheels()
        {
            Console.WriteLine("Wheels are installed");

        }

    }
}
