using System;
using System.Collections.Generic;

namespace Builder
{
    class Vehicle
    {
        private readonly string _vehicleType;
        private readonly Dictionary<string, string> _parts = new();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($"Engine: {_parts["engine"]}");
            Console.WriteLine($"Wheels: {_parts["wheels"]}");
            Console.WriteLine($"Doors: {_parts["doors"]}");
        }
    }
}
