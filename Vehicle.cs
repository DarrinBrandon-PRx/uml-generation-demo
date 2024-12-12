using System;

namespace VehicleSimulation
{
    public class Engine
    {
        public string Type { get; set; }
        public int Horsepower { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}
