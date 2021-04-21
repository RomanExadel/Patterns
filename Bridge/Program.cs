using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ILanguage language = new CSharpLanguage();

            var freelance = new FreelanceProgrammer(language);
            freelance.DoWork();
            freelance.EarnMoney();

            Console.WriteLine();

            var corporate = new CorporateProgrammer(language);
            corporate.DoWork();
            corporate.EarnMoney();
        }
    }
}
