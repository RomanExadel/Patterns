using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Roman");

            var mortgage = new Mortgage(new Bank(), new Loan());

            Console.WriteLine(mortgage.IsEligible(customer, 1000)
                ? $"Mortgage approved for {customer}"
                : $"Mortgage rejected {customer}");
        }
    }
}
