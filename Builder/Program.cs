using System;
using Builder.ConcreteVehicle;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilder();
            var motorCycle = new MotorCycleBuilder();

            var shop = new Shop();
            shop.Construct(car);
            car.Vehicle.Show();

            Console.WriteLine("---------------");

            shop.Construct(motorCycle);
            motorCycle.Vehicle.Show();
        }
    }
}
