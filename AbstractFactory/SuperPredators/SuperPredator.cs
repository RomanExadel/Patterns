using AbstractFactory.Carnivores;

namespace AbstractFactory.SuperPredators
{
    abstract class SuperPredator
    {
        public abstract void Eat(Carnivore carnivore);
    }
}
