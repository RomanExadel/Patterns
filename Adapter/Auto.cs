using System;

namespace Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Auto moving");
        }
    }
}
