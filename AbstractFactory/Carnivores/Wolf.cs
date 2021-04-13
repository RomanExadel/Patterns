using System;
using AbstractFactory.Herbivores;

namespace AbstractFactory.Carnivores
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"Wolf eats {herbivore.GetType().Name}");
        }
    }
}
