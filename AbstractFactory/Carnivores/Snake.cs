using System;
using AbstractFactory.Herbivores;

namespace AbstractFactory.Carnivores
{
    class Snake : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"Snake eats {herbivore.GetType().Name}");
        }
    }
}
