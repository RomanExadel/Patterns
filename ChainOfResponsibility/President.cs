using System;

namespace ChainOfResponsibility
{
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100_000)
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
