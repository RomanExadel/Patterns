using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new MathProxy();

            Console.WriteLine("2 + 2 = " + proxy.Add(2,2));

            Console.WriteLine("2 - 2 = " + proxy.Sub(2, 2));

            Console.WriteLine("2 * 2 = " + proxy.Mul(2, 2));

            Console.WriteLine("2 / 2 = " + proxy.Div(2, 2));
        }
    }
}
