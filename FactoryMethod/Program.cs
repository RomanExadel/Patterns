using System;
using FactoryMethod.ConcreteCreator;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Resume();
            
            Console.WriteLine("\n" + document.GetType().Name + "--");

            foreach (var page in document.Pages)
            {
                Console.WriteLine(" " + page.GetType().Name);
            }
        }
    }
}
