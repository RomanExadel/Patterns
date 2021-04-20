using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();

            var auto = new Auto();
            var camel = new CamelToTransportAdapter(new Camel());

            driver.Travel(auto);
            driver.Travel(camel);
        }
    }
}
