using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var lb1 = LoadBalancer.GetLoadBalancer();
            var lb2 = LoadBalancer.GetLoadBalancer();
            
            if (lb1 == lb2)
            {
                Console.WriteLine("Same instance\n");
            }
            
            var balancer = LoadBalancer.GetLoadBalancer();

            for (var i = 0; i < 15; i++)
            {
                var server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
            
            Console.ReadKey();
        }
    }
}
