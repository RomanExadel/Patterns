using AbstractFactory.Herbivores;

namespace AbstractFactory.Carnivores
{
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}
