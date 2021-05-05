using System;

namespace ChainOfResponsibility
{
    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10_000)
            {
                Console.WriteLine($"{GetType().Name} approved request#{purchase.Number}");
            }
            else
            {
                _successor?.ProcessRequest(purchase);
            }
        }
    }
}
