using System;

namespace VehicleSimulation
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }

        public void Start()
        {
            Console.WriteLine("Car started.");
            Engine.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
            Engine.Stop();
        }
    }
}
