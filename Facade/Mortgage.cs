using System;

namespace Facade
{
    class Mortgage
    {
        private readonly Bank _bank;
        private readonly Loan _loan;

        public Mortgage(Bank bank, Loan loan)
        {
            _bank = bank;
            _loan = loan;
        }

        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                c, amount);

            var eligible = true;
            
            if (!_bank.HasSufficientSavings(c, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(c))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
