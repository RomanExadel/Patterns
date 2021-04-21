using System;

namespace Bridge
{
    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Received money for the order");
        }
    }
}
