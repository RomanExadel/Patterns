using System;

namespace ChainOfResponsibility
{
    class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 50_000)
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
