using System;

namespace Bridge
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Received salary at the end of month");
        }
    }
}
