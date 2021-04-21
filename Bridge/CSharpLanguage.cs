using System;

namespace Bridge
{
    class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("CSharp build");
        }

        public void Execute()
        {
            Console.WriteLine("CSharp execute");
        }
    }
}
