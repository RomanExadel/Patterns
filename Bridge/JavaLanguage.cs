using System;

namespace Bridge
{
    class JavaLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Java build");
        }

        public void Execute()
        {
            Console.WriteLine("Java execute");
        }
    }
}
