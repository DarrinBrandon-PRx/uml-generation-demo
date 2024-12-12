using System;

namespace VehicleSimulation
{
    public class Transmission
    {
        public string TransmissionType { get; set; }
        public int GearCount { get; set; }

        public void ShiftUp()
        {
            Console.WriteLine("Shifting up.");
        }

        public void ShiftDown()
        {
            Console.WriteLine("Shifting down.");
        }
    }
}
