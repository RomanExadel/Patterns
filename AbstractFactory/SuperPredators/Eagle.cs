using System;
using AbstractFactory.Carnivores;

namespace AbstractFactory.SuperPredators
{
    class Eagle : SuperPredator
    {
        public override void Eat(Carnivore carnivore)
        {
            Console.WriteLine($"Eagle eats {carnivore.GetType().Name}");
        }
    }
}
